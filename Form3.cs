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
    public partial class Form3 : Form
    {
        private Movie movie;
        public Form3(Movie movie)
        {
            this.movie = movie;
            InitializeComponent();
        }
    }
}
