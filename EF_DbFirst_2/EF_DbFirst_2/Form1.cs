﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DbFirst_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hOkul_VTEntities okul_ctx = new hOkul_VTEntities();
            Notlar Not1 = new Notlar();
            Not1.Not1 = 50;
            Not1.Not2 = 30;
            okul_ctx.Notlars.Add(Not1);
            okul_ctx.SaveChanges();
        }
    }
}
