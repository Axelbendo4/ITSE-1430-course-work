﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class    MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void fileToolStripMenuItem_Click(object sender , EventArgs e)
        {

        }
        
        private void OnExit (object sender , EventArgs e)
        {
            if (MessageBox.Show("you want to exit ?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }
    }
}
