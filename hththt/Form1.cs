﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibsss;

namespace hththt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LucidDreams lucidDreams = new LucidDreams(); lucidDreams.Correct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LucidDreams lucidDreams = new LucidDreams(); lucidDreams.InCorrect();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Witchblades witchblades = new Witchblades(); witchblades.Correct();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Witchblades witchblades = new Witchblades(); witchblades.InCorrect();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(); bankAccount.Correct();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(); bankAccount.InCorrect();
        }
    }
}
