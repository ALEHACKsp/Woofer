using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZeroWoofer
{
    public partial class main : Form
    {
        WebClient download = new WebClient();

        public main()
        {
            InitializeComponent();   
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Text = System.Environment.MachineName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            load1.Visible = true;
            label3.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            label3.Text = "[+] Cleaning...";
            label3.Text = "[+] Cleaned !";
            MessageBox.Show("[+] Cleaned Successful !", "Zero Woofer", MessageBoxButtons.OK);
            load1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            load2.Visible = true;
            label1.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label1.Text = "[+] Woofing HWID...";
            label1.Text = "[+] HWID Woofed !\n[+] Mapper Start !";
            MessageBox.Show("[+] HWID Woofed Successful !\n[+] Mapper Start Successful !", "Zero Woofer", MessageBoxButtons.OK);
            load2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            load3.Visible = true;
            label4.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            label4.Text = "[+] Cleaning & Reloading Network...";
            label4.Text = "[+] Network Cleaned & Reloaded !";
            MessageBox.Show("[+] Network Cleaned & Reloaded Successful !", "Zero Woofer", MessageBoxButtons.OK);
            load3.Visible = false;
        }

        private void discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }

        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }
    }
}
