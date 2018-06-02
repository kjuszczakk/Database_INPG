using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Milk> milks = new List<Milk>();
        public Dashboard()
        {
            InitializeComponent();

            ListaMlek.DataSource = milks;
            ListaMlek.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            milks = db.GetMilks(WpiszMleko.Text);
            ListaMlek.Refresh();

            ListaMlek.DataSource = milks;
            ListaMlek.DisplayMember = "FullInfo";
        }

     
    }
}
