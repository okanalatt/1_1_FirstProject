using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1_FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region İLKPROJE
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToShortDateString()); // Display the current date in short format
            //MessageBox.Show(
            //    Environment.UserDomainName + "|\n" + // Display the domain name of the user
            //    Environment.UserName); // Display the user name
            //MessageBox.Show(Environment.MachineName); // Display the name of the machine
            HaftaninGunu(); // Call the method to display the day of the week
        }

        private void HaftaninGunu()
        {
            MessageBox.Show(DateTime.Today.ToLongDateString()); // Display the current date in long format
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
