using MongoDB.Driver;
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
    public partial class Form2 : Form
    {
        System.Windows.Forms.Panel MainPanel;
        static MongoClient mongoClient = new MongoClient("mongodb://W60113:asd123@13.53.159.1:27017");
        static IMongoDatabase db = mongoClient.GetDatabase("my_cinema");
        static IMongoCollection<Movie> collection = db.GetCollection<Movie>("movies");


        private void ReadAllDocuments()
        {
            List<Movie> list = collection.AsQueryable().ToList<Movie>();
            dataGridView.DataSource = list;
        }

        public Form2(System.Windows.Forms.Panel panel)
        {
            this.MainPanel = panel;
            InitializeComponent();
            ReadAllDocuments();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            setMainForm(new Form3(id));
            
        }


        private void setMainForm(Form passedForm)
        {


            passedForm.TopLevel = false;
            passedForm.FormBorderStyle = FormBorderStyle.None;
            passedForm.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(passedForm);
            MainPanel.Tag = passedForm;

            passedForm.Show();

        }
    }
}
