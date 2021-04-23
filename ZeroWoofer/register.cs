using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroWoofer
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Hide();
            new Form1().Show();
        }

        private void kaar_Click(object sender, EventArgs e)
        {
			base.Hide();
			new Form1().Show();
			this.Hide();
		}

        private void joinServerDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/3t2568W");
        }
    }
}
