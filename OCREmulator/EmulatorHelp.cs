﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OCREmulator
{
    public partial class EmulatorHelp : Form
    {
        public EmulatorHelp()
        {
            InitializeComponent();
            richTextBox1.Text=Resource1.EmulatorHelp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChipPinout d1 = new ChipPinout();
            d1.ShowDialog();
        }
    }
}
