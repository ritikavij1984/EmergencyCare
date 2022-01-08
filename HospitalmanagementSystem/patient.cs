using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalmanagementSystem
{
    public partial class patient : Form
    {
        public String Home = "";
        
        BedSelection bed;
        Add_Doctor AddDoctor;
        String Status = "";
        SqlConnection c = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=emergency;Integrated Security=True");
        bool st = true;
        int IdNo = 100000;
       
        public patient()
        {

            InitializeComponent();
            setPatientId();
            Display();
           
        }

        private void RefreshAll()
        {
           
            Display();
            setPatientId();
            pid.Text = "";
            pname.Text = "";
            pgender.SelectedIndex = -1;
            page.Text = "";
            pcity.Text = "";
            pmobile.Text = "";
            admitdate.Text = "";
            pbednumber.Text = "";

        }

        void setPatientId()
        {
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter("SELECT p_id FROM patient", c);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {


                    String wn = item[0].ToString();

                    IdNo = Convert.ToInt32(wn);

                }

                
                    IdNo = IdNo + 1;
                    pid.Text =  IdNo.ToString();
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     
        private void InsertPatient()
        {
            try
            {
                c.Open();
                if (pbednumber.Text == "")
                {

                    SqlCommand cm = new SqlCommand("INSERT INTO patient (p_id, p_name, p_age, p_gender,city, p_mobile, admit_date  ) " +
                        "VALUES ('" + pid.Text + "','" + pname.Text + "','" + page.Text + "','" + pgender.Text + "','" + pcity.Text + "','" + pmobile.Text + "','"  + Convert.ToDateTime(admitdate.Text) + "')", c);
                    cm.ExecuteNonQuery();
                }
                else
                {

                    SqlCommand cm = new SqlCommand("INSERT INTO patient (p_id, p_name, p_age, p_gender,city, p_mobile, bed_no, admit_date  ) " +
                        "VALUES ('" + pid.Text + "','" + pname.Text + "','" + page.Text + "','" + pgender.Text + "','" + pcity.Text + "','" + pmobile.Text + "','" + pbednumber.Text + "','" + Convert.ToDateTime(admitdate.Text) + "')", c);

                    SqlCommand cm1 = new SqlCommand("INSERT INTO bed (bed_no,room_no, P_id, status ) " +
                        "VALUES ('" + pbednumber.Text + "','" + "2" + "','" + pid.Text + "','" + "In Use" + "')", c);

                   
                    cm1.ExecuteNonQuery();
                    cm.ExecuteNonQuery();
                    

                }

                c.Close();


                MessageBox.Show("Successfully Added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DeletePatient()
        {

            try
            {
                c.Open();
                SqlCommand cm = new SqlCommand(@"DELETE FROM patient WHERE (p_id = '" + pid.Text + "') ", c);
                cm.ExecuteNonQuery();
                c.Close();

                MessageBox.Show("Successfully Deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                c.Close();
            }
        }



        private void addDataGridViewRows(DataRow item)
        {
           int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
            dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
            dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
            dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
            dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
            dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();

            dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
            dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();

        }

        void Display()
        {
            

            SqlDataAdapter cm = new SqlDataAdapter("SELECT p.p_name,p.p_age," + "p.admit_date,p.bed_no,b.status,t.issues," +
                "t.last_comment,t.last_updated, n.n_name , p.p_id " + "FROM patient p left join treat t on p.p_id = t.p_id " +
                "Left join bed b on p.bed_no=b.bed_no " + "Left join nurse n on t.n_id=n.n_id", c);


            DataTable dt = new DataTable();

            cm.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                addDataGridViewRows(item);
            }

        }

       

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {

                pid.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                pname.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                page.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                admitdate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
                
                
            

        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter cc = new SqlDataAdapter(" SELECT p_id FROM patient", c);

                DataTable dw = new DataTable();

                cc.Fill(dw);


                foreach (DataRow item in dw.Rows)
                {

                    int n = 0;
                    string[] wn = new string[4];
                    wn[n] = item[0].ToString();


                    if (pid.Text == wn[n])
                    {
                        MessageBox.Show("ID Already used.\n Select another.");

                        st = false;
                    }
                }

                if (st)
                {
                    if (pid.Text == "" || pname.Text == "" || pgender.Text == "" || pcity.Text == ""  || pmobile.Text == ""  || admitdate.Text == "")
                    {
                        MessageBox.Show("Fill all boxes");

                    }
                    else
                    {

                        InsertPatient();

                        Display();
                        RefreshAll();
                        st = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (pid.Text == "")
                {
                    MessageBox.Show("Select an patient's information to update");
                }
                else
                {

                   
                    Display();
                   
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DeletePatient();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

          

        private void F5_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }    

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Home != "")
            {
                switch (Home)
                {
                    case "Admin":
                        this.Close();
                        Main m = new Main();
                        Home = "";
                         m.Show();
                    break;

                    case "Administration":
                    this.Close();
                    Administration am = new Administration();
                    Home = "";
                    am.Show();
                    break;

                }
            }
        }

       

        private void SelectBedButton_Click(object sender, EventArgs e)
        {

            bed  = new BedSelection();


            bed.ShowDialog();
        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddDoctor = new Add_Doctor();
            AddDoctor.ShowDialog();
        }

        

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void FreeBed()
        {
            try
            {
                c.Open();
                

                SqlCommand cm = new SqlCommand(@"UPDATE  bed set  status = '" + "Free" + "' WHERE (p_id = '" + pid.Text + "')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("The bed is free now.");
            }
            catch (Exception ex)
            {
                c.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                FreeBed();

                c.Open();
               
                SqlCommand cm = new SqlCommand(@"INSERT INTO doctorCheckPatient
                         (p_id, d_id, discharge_date)
VALUES        ('"+pid.Text+"','"+DoctorId.Text+"','"+dischargeDate.Text+"')", c);
                cm.ExecuteNonQuery();
                c.Close();


                MessageBox.Show("Successfully Discharged.");
                
                Display();
                Status = "Discharged";
                RefreshAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                c.Close();
            }


        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            admitdate.Text = dateTimePicker2.Text;
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            dischargeDate.Text = dateTimePicker1.Text;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
