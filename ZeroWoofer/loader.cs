using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroWoofer
{
    public partial class loader : Form
    {


		//Pour le loader ajouter un bouton qui redirige vers la Form1 et aller dans Program.cs et changer la form de démarrage
		//For the loader add a button which redirects to Form1 and go to Program.cs and change the form of startup
		public loader()
        {
            InitializeComponent();
			loader1.Visible = false;
			load.Start();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Form1().Show();
			this.Hide();
		}

		private void load_Tick(object sender, EventArgs e)
		{
			loader1.Visible = true;
		}
	}
}
