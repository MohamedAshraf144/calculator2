﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "+";
                txtstore.Clear();
                count = 2;
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            txtstore.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;

            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "2";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "1";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + "9";
        }
        float num;
        int count;
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "-";
                txtstore.Clear();
                count = 1;
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {

            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "*";
                txtstore.Clear();
                count = 3;
            }
        }

        private void btndedvide_Click(object sender, EventArgs e)
        {

            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "/";
                txtstore.Clear();
                count = 4;
            }
        }

        private void btnrd_Click(object sender, EventArgs e)
        {

            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "%";
                txtstore.Clear();
                count = 5;
            }
        }
    }
}
