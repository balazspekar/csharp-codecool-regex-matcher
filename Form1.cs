﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            var pattern = txtPattern.Text;
            Regex regex = new Regex(pattern);
            MatchCollection mc = regex.Matches(txtText.ToString());

            foreach (var match in mc)
            {
                lstBox.Items.Add(match);
            }
            
            

            
        }
    }
}
