using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace st2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void names_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(names.SelectedIndex.ToString());
            Mtext.Text = names.SelectedItem.ToString();
        }

        private void mybut_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            names.Items.Add("yura");
            names.Items.Add("tina");
            names.Items.Add("slavko");
            names.Items.Add("cvetka");
        }
    }
}
