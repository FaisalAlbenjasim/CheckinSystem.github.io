using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highschool_check_in_system__HCI_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label1.Text))
            {
                MessageBox.Show("Please select the type of person checking in","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(comboBox1, "select one of the options");
            }
            else
            {
                if (label1.Text == "Visitor")
                {
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                }
                if (label1.Text == "Staff")
                {
                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
                if (label1.Text == "Student")
                {
                    Form5 f5 = new Form5();
                    f5.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this stage of check in process?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
              this.Close();
            Form1 f1 = new Form1();
            f1.Show();        
            }
        }
    }
}
