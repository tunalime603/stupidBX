using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stupidGX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            webbrowser.Source = new Uri("https://");
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            webbrowser.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webbrowser.GoForward();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            webbrowser.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gosearch_Click(object sender, EventArgs e)
        {
            webbrowser.Source = new Uri("https://www." + textBox1.Text);
            textBox1.Text = webbrowser.Source.ToString();
        }

        private void switchengine_Click(object sender, EventArgs e)
        {
            
        }
    }
}
