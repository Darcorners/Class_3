﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_3
{
    public partial class Form1 : Form
    {
        public static Monster monster = new Monster();
        public Form1()
        {
            InitializeComponent();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            monster.max_HP = Convert.ToInt32(textBox1.Text);
            monster.max_mass = Convert.ToInt32(textBox2.Text);
            monster.healthVer = Convert.ToInt32(textBox3.Text);
            monster.Maxcost = Convert.ToInt32(textBox4.Text);
            monster.damageVer = Convert.ToInt32(textBox5.Text);
            monster.Maxdamage = Convert.ToInt32(textBox6.Text);

            string data = monster.GetData();
            label1.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monster.Attack();

            string data = monster.GetData();
            label1.Text = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monster.Srez();

            string data = monster.GetData();
            label1.Text = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monster.Sell();

            string data = monster.GetData();
            label1.Text = data;
        }
    }
}
