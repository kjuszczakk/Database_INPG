﻿using System;
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

            UpdateBringing();
        }
        private void UpdateBringing()
        {
            ListaMlek.DataSource = milks;
            ListaMlek.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            milks = db.GetMilks(WpiszMleko.Text);
            UpdateBringing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            milks = db.GetAll();
            UpdateBringing();
            
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertMilk(NazwaText.Text, IloscText.Text, CenaText.Text, MiejsceText.Text);
            NazwaText.Text = "";
            IloscText.Text = "";
            CenaText.Text = "";
            MiejsceText.Text = "";
            milks = db.GetAll();
            UpdateBringing();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteMilk(milks[ListaMlek.SelectedIndex].NazwaMleka);
            milks = db.GetAll();
            UpdateBringing();
        }
    }
}
