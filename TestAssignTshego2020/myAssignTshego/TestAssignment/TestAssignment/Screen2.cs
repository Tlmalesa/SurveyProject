using System;
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
    public partial class Screen2 : Form
    {
        DateTime dt = new DateTime();
        public Screen2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-29TU5HG\\SQLEXPRESS;Initial Catalog=SurveyDB;Integrated Security=True");
        private void Screen2_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {          
            try
            {
                con.Open();
                int pizza = checkPizza.Checked ? 1 : 0;
                int pasta = checkPasta.Checked ? 1 : 0;
                int papWors = checkPapWors.Checked ? 1 : 0;
                int chicken = checkChicken.Checked ? 1 : 0;
                int beef = checkBeef.Checked ? 1 : 0;
                int other = checkOther.Checked ? 1 : 0;
                int EatOut = 0, wMovie=0, wTV=0, lRadio=0;
        
                if(radEatOut1.Checked)
                    EatOut = 1;
                else if (radEatOut2.Checked)
                    EatOut = 2;
                else if (radioEatOut3.Checked)
                   EatOut = 3;
                else if (radEatOut4.Checked)
                    EatOut = 4;
                else if (radEatOut5.Checked)
                    EatOut = 5;
                if (radMovie1.Checked)
                    wMovie = 1;
                else if (radMovie2.Checked)
                    wMovie = 2;
                else if (radMovie3.Checked)
                    wMovie = 3;
                else if (radMovie4.Checked)
                    wMovie = 4;
                else if (radMovie5.Checked)
                    wMovie = 5;
                if (radTV1.Checked)
                    wTV=1;
                else if (radTv2.Checked)
                    wTV = 2;
                else if (radTv3.Checked)
                    wTV = 3;
                else if (radTV4.Checked)
                    wTV = 4;
                else if (radTV5.Checked)
                    wTV = 5;
                if (radRadio1.Checked)
                    lRadio = 1;
                else if (radRadio2.Checked)
                    lRadio = 2;
                else if (radRadio3.Checked)
                    lRadio = 3;
                else if (radRadio4.Checked)
                    lRadio = 4;
                else if (radRadio5.Checked)
                    lRadio = 5;
                string query = "Insert into PersonalDetails(Surname, FirstNames, ContactNo,Age,pizza,pasta,papNvors,ChickenStirFry,BeefStirFry,OtherMenu,EatOut,WatchMovies,WatchTv,ListenRadio,date) values ('" + txtSurname.Text + "','" + txtFullNames.Text + "','" + txtContactNum.Text + "','" + txtAge.Text + "','" + pizza + "','" + pasta + "','" + papWors + "','" + chicken + "','" + beef + "','" + other + "','" + EatOut + "','" + wMovie + "','" + wTV + "','" + lRadio + "','" + dateTimePicker1.Value.Date + "')";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery(); 
                
                con.Close();
                
            }
            catch (SqlException err)       
            {
                MessageBox.Show("Age should not be empty");
               
                con.Close();
            }
            int validate = Convert.ToInt32(txtAge.Text);
          if (validate <= 5 || validate >= 120)
            {
                MessageBox.Show("Age must be between 5 and 120");
                txtAge.Clear();
                
                
            }
            else if (txtSurname.Text == "" || txtFullNames.Text == "" || txtContactNum.Text == "")
            {
                MessageBox.Show("fill all the text boxes");
            }
            else if (checkBeef.Checked == false && checkChicken.Checked == false && checkOther.Checked == false && checkPapWors.Checked == false && checkPasta.Checked == false && checkPizza.Checked == false)
            {
                MessageBox.Show("choose item/s");
            }
            else if (radEatOut1.Checked == false && radEatOut2.Checked == false && radEatOut4.Checked == false && radEatOut5.Checked == false &&
                 radioEatOut3.Checked == false || radMovie1.Checked == false && radMovie2.Checked == false && radMovie3.Checked == false &&
                 radMovie4.Checked == false && radMovie5.Checked == false || radRadio1.Checked == false && radRadio2.Checked == false &&
                 radRadio3.Checked == false && radRadio4.Checked == false && radRadio5.Checked == false || radTV1.Checked == false &&
                 radTv2.Checked == false && radTv3.Checked == false && radTV4.Checked == false && radTV5.Checked == false)
            {
                MessageBox.Show("Select rating for each of the four organisation");
            }
            else
            {

                MessageBox.Show("Survey Submitted");
                DialogResult d;
                d = MessageBox.Show("Do you want to add more surveys?", "details", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.No)
                {
                    Screen1 s1 = new Screen1();
                    this.Hide();
                    s1.Show();
                }
                else
                    MessageBox.Show("Add another Survey details");
                txtAge.Clear();
                txtContactNum.Clear();
                txtFullNames.Clear();
                txtSurname.Clear();

                checkPizza.Checked = false;
                checkPasta.Checked = false;
                checkPapWors.Checked = false;
                checkOther.Checked = false;
                checkChicken.Checked = false;
                checkBeef.Checked = false;

                radEatOut1.Checked = false;
                radEatOut2.Checked = false;
                radEatOut4.Checked = false;
                radEatOut5.Checked = false;
                radioEatOut3.Checked = false;

                radMovie1.Checked = false;
                radMovie2.Checked = false;
                radMovie3.Checked = false;
                radMovie4.Checked = false;
                radMovie5.Checked = false;

                radRadio1.Checked = false;
                radRadio2.Checked = false;
                radRadio3.Checked = false;
                radRadio4.Checked = false;
                radRadio5.Checked = false;

                radTV1.Checked = false;
                radTv2.Checked = false;
                radTv3.Checked = false;
                radTV4.Checked = false;
                radTV5.Checked = false;
            }
            
        }

        private void checkPizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
