using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema
{
    public partial class AboutUsForm : Form
    {
        /// <summary>
        /// Default form contstructor
        /// </summary>
        public AboutUsForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Method opening web-app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/falc0m");
        }

    }
}
