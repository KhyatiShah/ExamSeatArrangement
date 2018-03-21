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
    public partial class DataView : Form
    {


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;


        public DataView()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "data source=BRD-PF0UYTG9-L\\MSSQL;initial catalog='exam';user id=ACS\\Khyati.Shah;Integrated Security=true";

            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private void DataView_Load(object sender, EventArgs e)
        {

        }

        private void tbEnrlno_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSeatno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string eno = tbEnrlno.Text;
            string query = " select * from Exam_Details A join Student_Info B on A.Enrl_no = B.Enrl_No Where ";

            if (eno != null && eno != string.Empty)
            {
                query += " A.Enrl_no = '" + eno + "' order by Sub_Date  Desc";
            }
            else
            {

                string sno = (cbSeatno.SelectedItem != null) ? (cbSeatno.SelectedItem.ToString() + "-" + tbSeatno.Text) : null;

                if (sno == null || sno == string.Empty)
                {
                    //so error message
                    MessageBox.Show("Enter Some Appropriate value", "Error: Nothing To Display");
                    return;
                }

                query += "A.Seat_no = '" + sno + "'  order by Sub_Date  Desc";
            }
            try
            {
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                // SqlDataReader rdr = cmd.ExecuteReader();
                if (dt.Rows.Count > 0)
                {


                    //  tb_Enrlno.Text = dt.Rows[0]["Enrl_No"].ToString();
                    //  tbStname.Text = dt.Rows[0]["St_firstnname"].ToString() + " " + dt.Rows[0]["St_middlename"].ToString() + " " + dt.Rows[0]["St_lastname"].ToString();
                    // tbStdept.Text = dt.Rows[0]["St_dept"].ToString();
                    lblEnrlno.Text = dt.Rows[0]["Enrl_no"].ToString();
                    lblStname.Text = dt.Rows[0]["St_firstname"].ToString() + " " + dt.Rows[0]["St_middlename"].ToString() + " " + dt.Rows[0]["St_lastname"].ToString();
                    lblstdept.Text = dt.Rows[0]["St_dept"].ToString();
                    tbExamtype.Text = dt.Rows[0]["Exam_type"].ToString();
                    tbSubcode.Text = dt.Rows[0]["Sub_code"].ToString();
                    tbSubdate.Text = dt.Rows[0]["Sub_date"].ToString();
                    tbClassno.Text = dt.Rows[0]["Class_no"].ToString();
                    tbBlockno.Text = dt.Rows[0]["Block_no"].ToString();
                    tb_seatno.Text = dt.Rows[0]["Seat_no"].ToString();

                }
                else
                {
                    MessageBox.Show("Your Data Is Not Found. Please Enter Your Number Again ", "ERROR:Data Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please Enter Any Value");
            }
            finally
            {
                tbEnrlno.Text = "";
                cbSeatno.Text = "";
                tbSeatno.Text = "";

                con.Close();
            }

        }

        private void tb_Enrlno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSubdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_seatno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            tbExamtype.Text = "";
            // tbStname.Text = "";
            // tbStdept.Text = "";
            tbSeatno.Text = "";
            lblEnrlno.Text = "";
            lblstdept.Text = "";
            lblStname.Text = "";
            tbClassno.Text = "";
            tbBlockno.Text = "";
            tb_seatno.Text = "";
            cbSeatno.Text = "";
            tbSubcode.Text = "";
            tbSubdate.Text = "";
            //tbEnrlno.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DataEntry form = new DataEntry();
            form.Show();
        }

        private void DataView_Load_1(object sender, EventArgs e)
        {

        }












    }
}
