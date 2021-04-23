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
    public partial class Form1 : Form
    {

        WebClient download = new WebClient();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            fond.Visible = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
                base.Hide();
                new main().Show();
                this.Hide();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            new register().Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            base.Hide();
            new register().Show();
        }

        private void joinServerDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }
    }
}
