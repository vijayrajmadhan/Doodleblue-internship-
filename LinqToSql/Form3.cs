using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Form3 : Form
    {
        CompanyDBDataContext dc;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if(dgview.SelectedRows.Count>0)
            {
                Form4 f = new Form4();
                f.textBox1.ReadOnly = true;
                f.button2.Enabled = false;
                f.button1.Text = "Update";
                f.textBox1.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                f.textBox2.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox3.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox4.Text = dgview.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox5.Text = dgview.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                Load_data();
            }
            else
            {
                MessageBox.Show("Select the rows");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        private void Load_data()
        {
            dc = new CompanyDBDataContext();
            dgview.DataSource = dc.Employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f= new Form4();
            f.ShowDialog();
            Load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgview.SelectedRows.Count > 0)
            {
               if(MessageBox.Show("Are you sure of deleting the selected Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Eno =Convert.ToInt32(dgview.SelectedRows[0].Cells[0].Value.ToString());
                    Employee obj=dc.Employees.SingleOrDefault(E=>E.Eno==Eno);
                    dc.Employees.DeleteOnSubmit(obj);
                    dc.SubmitChanges();
                    Load_data();
                }
            }
            else
            {
                MessageBox.Show("Select the Data thet need to be deleted");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
