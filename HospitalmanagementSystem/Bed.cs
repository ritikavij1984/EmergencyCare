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
    public partial class BedSelection : Form
    {

        SqlConnection c = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=emergency;Integrated Security=True");
        
        public BedSelection()
        {
            

            InitializeComponent();
            Display();
        }
        void Display()
        {
            SqlDataAdapter sd = new SqlDataAdapter(@"select * from Bed",c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
              {
                int n = dataGridView1.Rows.Add();

                  dataGridView1.Rows[n].Cells[0].Value = item[1].ToString();
                  dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();

              

                    if (item[3].ToString() == "Free")
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "Free";
                    }
                    else 
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "In Use";
                    }
               
            }
        }
        
       


       

       

       


        
      
        private void BedSelection_Load(object sender, EventArgs e)
        {

        }



        
    }
}
