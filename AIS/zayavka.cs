using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS
{
    public partial class zayavka : Form
    {
        public zayavka()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zayavka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uTT_dbDataSet6.vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter2.Fill(this.uTT_dbDataSet6.vehicles);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True";
            //string sqlExpression = "INSERT INTO dbo.zayavka (zayavka_perevozchik, zayavka_object, zayavka_gruz, zayavka_gruz_weight, zayavka_gruz_gabarit, zayavka_polychatel, zayavka_date_dostavka, zayavka_contact_info, zayavka_oplata) VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "''" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "''" + textBox10.Text + "', '" + textBox11.Text + "')";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression, connection);
            //    int number = command.ExecuteNonQuery();

            //}
            //SqlConnection conn = new SqlConnection(@"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True"); // создаем подключение
            //conn.Open(); // открываем подключение

            //SqlCommand cmd = new SqlCommand("Insert Into dbo.zayavka Values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text +"')", conn); // создаем SQL запрос
            //cmd.ExecuteNonQuery();
            //conn.Close();


            //using (SqlConnection con = new SqlConnection(@"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True"))
            //{
            //    con.Open();
            //    using (SqlCommand command = new SqlCommand(
            //   "INSERT INTO zayavka VALUES(@zayavka_id, @zayavka_perevozchik, @zayavka_object, @zayavka_gruz,@zayavka_gruz_weight, @zayavka_gruz_gabarit, @zayavka_polychatel, @zayavka_date_dostavka, @zayavka_contact_info, @zayavka_oplata, @zayavka_vehicle)", con))
            //    {
            //        command.Parameters.Add(new SqlParameter("@zayavka_id", Convert.ToInt32(textBox1.Text)));
            //        command.Parameters.Add(new SqlParameter("@zayavka_perevozchik", textBox2.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_object", textBox3.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_gruz", textBox4.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_gruz_weight", textBox5.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_gruz_gabarit", Convert.ToInt32(textBox6.Text)));
            //        command.Parameters.Add(new SqlParameter("@zayavka_polychatel", textBox8.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_date_dostavka", textBox9.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_contact_info", textBox10.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_oplata", textBox11.Text));
            //        command.Parameters.Add(new SqlParameter("@zayavka_vehicle", comboBox1.Text));
            //        command.ExecuteNonQuery();
            //        con.Close();
            //    }
            //}

            reg(Int32.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, comboBox1.SelectedText);

        }

        public void reg(int z_id, string z_perevozchik, string z_object,string z_gruz,string z_g_w, string z_g_g, string z_polychatel,string z_date, string z_contact,string z_oplata, string z_vehilce)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=ALEX-ПК\SQLEXPRESS;Initial Catalog=UTT_db;Integrated Security=True"))
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO zayavka (zayavka_id, zayavka_perevozchik, zayavka_object,zayavka_gruz,zayavka_gruz_weight,zayavka_gruz_gabarit,zayavka_polychatel,zayavka_date_dostavka,zayavka_contact_info,zayavka_oplata,zayavka_vehicle)" +
                    " VALUES (@z_id,@z_perevozchik, @z_object,@z_gruz,@z_g_w,@z_g_g,@z_polychatel,@z_date,@z_contact,@z_oplata, @z_vehilce)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@z_id", z_id);
                cmd.Parameters.AddWithValue("@z_perevozchik", z_perevozchik);
                cmd.Parameters.AddWithValue("@z_object", z_object);
                cmd.Parameters.AddWithValue("@z_gruz", z_gruz);
                cmd.Parameters.AddWithValue("@z_g_w", z_g_w);
                cmd.Parameters.AddWithValue("@z_g_g", z_g_g);
                cmd.Parameters.AddWithValue("@z_polychatel", z_polychatel);
                cmd.Parameters.AddWithValue("@z_date", z_date);
                cmd.Parameters.AddWithValue("@z_contact", z_contact);
                cmd.Parameters.AddWithValue("@z_oplata", z_oplata);
                cmd.Parameters.AddWithValue("@z_vehilce", z_vehilce);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}

