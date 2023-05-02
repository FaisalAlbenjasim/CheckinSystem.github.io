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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (label4.Text == "Year 7")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TG");
                comboBox2.Items.Add("AD");
                comboBox2.Items.Add("MS");
                comboBox2.Items.Add("AH");
            }
            if (label4.Text == "Year 8")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CB"); 
                comboBox2.Items.Add("RK");
                comboBox2.Items.Add("CW");
                comboBox2.Items.Add("MB");
            }
            if (label4.Text == "Year 9")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("YG");
                comboBox2.Items.Add("RK");
                comboBox2.Items.Add("WI");
                comboBox2.Items.Add("JOD");
            }
            if (label4.Text == "Year 10")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ML");
                comboBox2.Items.Add("LG");
                comboBox2.Items.Add("PB");
                comboBox2.Items.Add("HN");
            }
            if (label4.Text == "Year 11")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("PH");
                comboBox2.Items.Add("OJ");
                comboBox2.Items.Add("US");
                comboBox2.Items.Add("WR");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(label4.Text))
            {
                MessageBox.Show("Please select the age group","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(comboBox1, "select one of the options");
            }
            if (String.IsNullOrEmpty(label6.Text))
            {
                MessageBox.Show("Please select the Form ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider2.SetError(comboBox2, "select one of the options");
            }
            if (String.IsNullOrEmpty(label8.Text))
            {
                MessageBox.Show("Please select the student name checking in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider3.SetError(comboBox3, "select one of the options");
            }
            else
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox3.GetItemText(comboBox3.SelectedItem);
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
