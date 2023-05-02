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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in your Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(textBox1, "Text Field cannot be empty");
                
               
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please fill in your First Name","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(textBox2, "Text Field cannot be empty");

            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please fill in your Last Name", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider3.SetError(textBox3, "Text Field cannot be empty");
                

            }
            else if(String.IsNullOrEmpty(label7.Text))
                {
                MessageBox.Show("Please select the Staff you are visiting","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider4.SetError(comboBox1, "select one of the options");
            }
            else
            {

                Form6 f6 = new Form6();
                f6.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this stage of check in process?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to abort your check in?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
