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
    public partial class Add_Doctor : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=emergency;Integrated Security=True");
        public String getWord = "";
        public Add_Doctor()
        {
            InitializeComponent();
            Display();
          
        }

     

        void Display()
        {

            SqlDataAdapter cm1 = new SqlDataAdapter(@"select count(p_id) AdmittedCount from patient 
            where CAST(CONVERT(varchar, admit_date, 5) AS DATE) = CAST(convert(varchar, getdate(), 5) AS DATE)", c);

            

            DataTable dt1 = new DataTable();
            
                cm1.Fill(dt1);
                dataGridView1.Rows.Clear();

                try
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dt1.Rows[0]["AdmittedCount"].ToString(); 
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

    }
}
