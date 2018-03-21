using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class DataEntry : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;

        public DataEntry()
        {
            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = "data source=BRD-PF0UYTG9-L\\MSSQL;initial catalog='exam';user id=ACS\\Khyati.Shah;Integrated Security=true";            

            cmd = new SqlCommand();
            cmd.Connection = con;

        }

        private void DataEntry_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string etype = cbExamtype.SelectedItem.ToString();
                string subcode = cbSubcode.SelectedItem.ToString();
                string subdate = dateTimePicker1.Text;          //tbExamdate.Text;
                string classno = cbClassno.SelectedItem.ToString() + '-' + tbclassno.Text;
                string blno = tbBlockno.Text;
                string sno = cbSeatno.SelectedItem.ToString() + "-" + tbSeatno.Text;
                string eno = tbEnrlno.Text;

                //validation 
                string query = string.Format("insert into Exam_Details values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                        etype, subcode, subdate, classno, blno, sno, eno);

                cmd.CommandText = query;

                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("The Data is Saved  Successfully", "Saving Data");
                }

                else
                {
                    MessageBox.Show("Data Entry Failed", "Saving Data");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Sorry Exception");
            }

            finally
            {
                con.Close();
                btnReset_Click(null, null);
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbExamtype.Text = "";
            tbSeatno.Text = "";
            tbEnrlno.Text = "";
            tbclassno.Text = "";
            tbBlockno.Text = "";
            cbSeatno.Text = "";
            cbSubcode.Text = "";
            cbClassno.Text = "";
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbSubcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


