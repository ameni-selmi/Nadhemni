﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nadhemni
{
    public partial class heal1 : Form
    {
        public heal1()
        {
            InitializeComponent();
            panel1.Hide();
            med.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    
            private const int cGrip = 16;      // Grip size
            private const int cCaption = 32;   // Caption bar height;

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
                ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
                rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x84)
                {  // Trap WM_NCHITTEST
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < cCaption)
                    {
                        m.Result = (IntPtr)2;  // HTCAPTION
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                        return;
                    }
                }
                base.WndProc(ref m);
            }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Job h = new Job();
            h.Show();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parents h = new Parents();
            h.Show();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if(sideMenu.Width== 196)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 43;
                bunifuTransition1.ShowSync(sideMenu);
                bunifuTransition1.ShowSync(logo);

            }
            else
            {
                sideMenu.Visible = false;
                sideMenu.Width = 196;
                bunifuTransition1.ShowSync(sideMenu);
                bunifuTransition1.ShowSync(logo);
            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_in h = new sign_in();
            h.Show();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            med.Show();
        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            med.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            healthy h = new healthy();
            h.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            water eau = new water();
            eau.Show();
        }

        private void med_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            //events ev = new events();
            //ev.Show();
            planning p = new planning();
            p.Show();
        }

        private void Beauty_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pets h = new Pets();
            h.Show();
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            events h = new events();
            h.Show();
        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bills h = new Bills();
            h.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            //events ev = new events();
            //ev.Show();
            planning p = new planning();
            p.Show();

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Health_Click(object sender, EventArgs e)
        {

        }

        private void Events_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beauty h = new Beauty();
            h.Show();
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Treasury h = new Treasury();
            h.Show();
        }
    }
}
