using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCinema2
{
    public partial class Form3 : Form
    {
        public Form3(String id)
        {
            Console.WriteLine("PASSED ID " + id);
            InitializeComponent();
        }
    }
}
