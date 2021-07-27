using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestAssignment
{
    public partial class Screen3 : Form
    {
        public Screen3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-29TU5HG\\SQLEXPRESS;Initial Catalog=SurveyDB;Integrated Security=True");

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Screen3_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "Select COUNT(*) from PersonalDetails where Age Between 5 and 120";
                int count = 0;
                SqlCommand com2 = new SqlCommand(query, con);
                count = (int)com2.ExecuteScalar();
                lblTotNumSurv.Text = count.ToString();

                string query2 = "select CAST(ROUND(AVG(Age),1) AS DEC(3,1)) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                    lblAvAge.Text = rdr[0].ToString();
                rdr.Close();

                string query3 = "select MAX(Age) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd2 = new SqlCommand(query3, con);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read())
                    lblMaxAge.Text = rdr2[0].ToString();
                rdr2.Close();

                string query4 = "select MIN(Age) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd3 = new SqlCommand(query4, con);
                SqlDataReader rdr3 = cmd3.ExecuteReader();
                while (rdr3.Read())
                    lblMinAge.Text = rdr3[0].ToString();
                rdr3.Close();

                string query5 = "select CAST(ROUND(AVG(WatchMovies),1) AS DEC(3,1)) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd4 = new SqlCommand(query5, con);
                SqlDataReader rdr4 = cmd4.ExecuteReader();
                while (rdr4.Read())
                   lblWatchMov.Text = rdr4[0].ToString();
                rdr4.Close();

                string query6 = "select CAST(ROUND(AVG(ListenRadio),1) AS DEC(3,1)) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd5 = new SqlCommand(query6, con);
                SqlDataReader rdr5 = cmd5.ExecuteReader();
                while (rdr5.Read())
                   lblListRadio.Text = rdr5[0].ToString();
                rdr5.Close();

                string query7 = "select CAST(ROUND(AVG(WatchTv),1) AS DEC(3,1)) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd6 = new SqlCommand(query7, con);
                SqlDataReader rdr6 = cmd6.ExecuteReader();
                while (rdr6.Read())
                   lblWatchTv.Text = rdr6[0].ToString();
                rdr6.Close();

                string query8 = "select CAST(ROUND(AVG(EatOut),1) AS DEC(3,1)) from PersonalDetails where Age Between 5 and 120";
                SqlCommand cmd7 = new SqlCommand(query8, con);
                SqlDataReader rdr7 = cmd7.ExecuteReader();
                while (rdr7.Read())
                    lblEatOut.Text = rdr7[0].ToString();
                rdr7.Close();

                string query9 = "select concat((count(*) * 100 / (Select count(*) from PersonalDetails where Age Between 5 and 120)), '%') as Perc from PersonalDetails where Age Between 5 and 120 and Pasta = 1 GROUP BY Pasta";
                SqlCommand cmd8 = new SqlCommand(query9, con);
                SqlDataReader rdr8 = cmd8.ExecuteReader();
                while (rdr8.Read())
               lblPercPasta.Text = rdr8[0].ToString();
                rdr8.Close();

                string query10 = "select concat((count(*) * 100 / (Select count(*) from PersonalDetails where Age Between 5 and 120 )), '%') from PersonalDetails where Age Between 5 and 120 and Pizza = 1 GROUP BY Pizza";
                SqlCommand cmd9 = new SqlCommand(query10, con);
                SqlDataReader rdr9 = cmd9.ExecuteReader();
                while (rdr9.Read())
                 lblPercPizza.Text = rdr9[0].ToString();
                rdr9.Close();

                string query11 = "select concat((count(*) * 100 / (Select count(*) from PersonalDetails where Age Between 5 and 120 )), '%') from PersonalDetails where Age Between 5 and 120 and PapNVors = 1 GROUP BY PapNVors";
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlDataReader rdr11 = cmd11.ExecuteReader();
                while (rdr11.Read())
               lblPercPapWors.Text = rdr11[0].ToString();
                rdr11.Close();
                con.Close();
            }
            catch (SqlException err)       
            {
                MessageBox.Show("Error message: " + err);
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Screen1 s1 = new Screen1();
            this.Hide();
            s1.Show();
        }
    }
}
