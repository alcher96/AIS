using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS
{
    public partial class uchet : Form
    {
        string date = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
        int idx = 750;
        Image<Gray, Byte> frameforpic;
        private detector _licensePlateDetector;
        Image<Bgr, Byte> imgGray;
        Image<Bgr, Byte> imgGray2;
        int CurrentFrameNo = 0;
        int TotalFrames;
        bool Pause = false;
        // private VideoCapture _capture;
        Image<Bgr, Byte> _capture;
        Image<Bgr, Byte> imgeOrigenal;
        Point MouseDownStart = new Point(); //Точка начала выделения области
        Image<Bgr, Byte> frame; //Текущий кадр
        int NumOfSavedImage = 184; 
        object locker = new object(); //Контроль доступа к изображению
        string FoulderAdress; 
        public uchet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uchet_Load(object sender, EventArgs e)
        {
          

            try
            {
                _capture = new Image<Bgr, byte>(Properties.Resources.test1); //Проверка доступа 
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            //  timer1.Enabled = true;
            //  TotalFrames = Convert.ToInt32(_capture);
            //   trackBar1.Minimum = 0;
            //   trackBar1.Maximum = TotalFrames - 1;
            //  trackBar1.Value = 0;
            frame = _capture; //Текущий кадр с камеры
            frameforpic = frame.Convert<Gray, Byte>().Clone();
            // if (Rec != null)
            //    frameforpic.Draw(Rec, new Gray(150), 3); //нарисуем область выделения
            imageBox2.Image = frameforpic;
            // trackBar1.Value = CurrentFrameNo;
            //  CurrentFrameNo += 1;
            DetectFaceHaar();
            _licensePlateDetector = new detector("");
            // Mat m = new Mat("plate.jpg");
            Mat m = imgGray2.Mat;
            UMat um = m.GetUMat(AccessType.ReadWrite);
            imageBox2.Image = um;
            ProcessImage(m);
            label6.Text = label6.Text.Substring(0, label6.Text.Length - 9) + idx.ToString();
            label6.Text = label6.Text.Substring(1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTT_dbDataSet7.reg". При необходимости она может быть перемещена или удалена.
            //this.regTableAdapter.Fill(this.uTT_dbDataSet7.reg);

            //string myConnectionString = @"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True";
            //string mySelectQuery = "SELECT [vehicle_num] FROM [vehicles].[dbo] WHERE [vehicle_num] = '" + label6.Text + "'";
            //using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
            //{
            //    DataTable table = new DataTable();
            //    dataAdapter.Fill(table);
            //    // if (reader.HasRows)
            //    // { }
            //    if (table.Rows.Count == 0) 
            //    {
            //        var cmd = new SqlCommand("INSERT INTO [reg] ([veh_num], [veh_data]) VALUES (@veh_num, @veh_data)"); 
            //        cmd.Parameters.Add(label6.Text,date);
            //        cmd.ExecuteNonQuery();
            //    }   
            //}
        }
        private void ProcessImage(IInputOutputArray image)
        {
            Stopwatch watch = Stopwatch.StartNew(); // time the detection process

            List<IInputOutputArray> licensePlateImagesList = new List<IInputOutputArray>();
            List<IInputOutputArray> filteredLicensePlateImagesList = new List<IInputOutputArray>();
            List<RotatedRect> licenseBoxList = new List<RotatedRect>();
            List<string> words = _licensePlateDetector.DetectLicensePlate(
               image,
               licensePlateImagesList,
               filteredLicensePlateImagesList,
               licenseBoxList);

            watch.Stop(); //stop the timer
            

            panel2.Controls.Clear();
            Point startPoint = new Point(10, 10);
            for (int i = 0; i < words.Count; i++)
            {
                Mat dest = new Mat();
                CvInvoke.VConcat(licensePlateImagesList[i], filteredLicensePlateImagesList[i], dest);
                AddLabelAndImage(
                   ref startPoint,
                   String.Format( words[i].Replace('S','5')),
                   dest);
               
                PointF[] verticesF = licenseBoxList[i].GetVertices();
                Point[] vertices = Array.ConvertAll(verticesF, Point.Round);
                using (VectorOfPoint pts = new VectorOfPoint(vertices))
                    CvInvoke.Polylines(image, pts, true, new Bgr(Color.Red).MCvScalar, 2);

            }
            

        }
        public void DetectFaceHaar()
        {
            try
            {
                /*string facePath = Path.GetFullPath("cascade.xml");
                string eyePath = Path.GetFullPath("haarcascade_russian_plate_number.xml");*/


                CascadeClassifier classifierFace = new CascadeClassifier("cascade.xml");
                CascadeClassifier classifierEye = new CascadeClassifier("haarcascade_russian_plate_number.xml");

                imgGray = frame.Convert<Bgr, byte>().Clone();
                imgGray2 = frame.Convert<Bgr, byte>().Clone();
                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.7, 10);

                foreach (var face in faces)
                {
                    frameforpic.Draw(face, new Gray(), 4);
                    imgGray.ROI = face;

                    label6.Text = faces.Length.ToString();

                    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray2, 1.7, 9);
                    foreach (var eye in eyes)
                    {
                        var e = eye;

                        // e.X += face.X;
                        // e.Y += face.Y;
                        frameforpic.Draw(e, new Gray(), 4);
                        imgGray2.ROI = eye;
                    }
                }

                imageBox2.Image = imgGray2;
                //pictureBox1.Image = imgGray.ToImage<Gray, Byte>();
                imageBox3.Image = frame;
              //  imageBox4.Image = imgGray2;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AddLabelAndImage(ref Point startPoint, String labelText, IImage image)
        {
          
            label6.Text = labelText;

            ImageBox box = new ImageBox();
            panel2.Controls.Add(box);
            box.ClientSize = image.Size;
            box.Image = image;
            box.Location = startPoint;
            startPoint.Y += box.Height + 10;

           // bd();
        }

        void bd()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("Select vehicle_num from [vehicles] where vehicle_num=@zip", conn);
            command.Parameters.AddWithValue("@zip", label6.Text);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                }
            }

            conn.Close();

        }
    }
}
