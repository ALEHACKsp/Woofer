namespace ZeroWoofer
{
    partial class loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loader));
            this.loader1 = new System.Windows.Forms.PictureBox();
            this.oldmodz = new System.Windows.Forms.Timer(this.components);
            this.changeoldmodz = new System.Windows.Forms.Timer(this.components);
            this.oldmodzlabel = new Bunifu.Framework.UI.BunifuTileButton();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.load = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loader1)).BeginInit();
            this.SuspendLayout();
            // 
            // loader1
            // 
            this.loader1.Image = global::ZeroWoofer.Properties.Resources.chargement;
            this.loader1.Location = new System.Drawing.Point(-6, 41);
            this.loader1.Name = "loader1";
            this.loader1.Size = new System.Drawing.Size(474, 360);
            this.loader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loader1.TabIndex = 0;
            this.loader1.TabStop = false;
            this.loader1.Visible = false;
            this.loader1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // oldmodzlabel
            // 
            this.oldmodzlabel.BackColor = System.Drawing.Color.Transparent;
            this.oldmodzlabel.color = System.Drawing.Color.Transparent;
            this.oldmodzlabel.colorActive = System.Drawing.Color.Transparent;
            this.oldmodzlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldmodzlabel.Font = new System.Drawing.Font("Bebas Neue", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldmodzlabel.ForeColor = System.Drawing.Color.White;
            this.oldmodzlabel.Image = null;
            this.oldmodzlabel.ImagePosition = 91;
            this.oldmodzlabel.ImageZoom = 50;
            this.oldmodzlabel.LabelPosition = 115;
            this.oldmodzlabel.LabelText = "ZERO WOOFER";
            this.oldmodzlabel.Location = new System.Drawing.Point(-42, -1);
            this.oldmodzlabel.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.oldmodzlabel.Name = "oldmodzlabel";
            this.oldmodzlabel.Size = new System.Drawing.Size(544, 119);
            this.oldmodzlabel.TabIndex = 12;
            // 
            // load
            // 
            this.load.Tick += new System.EventHandler(this.load_Tick);
            // 
            // loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(466, 354);
            this.Controls.Add(this.oldmodzlabel);
            this.Controls.Add(this.loader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Woofer - Loader";
            ((System.ComponentModel.ISupportInitialize)(this.loader1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loader1;
        private System.Windows.Forms.Timer oldmodz;
        private System.Windows.Forms.Timer changeoldmodz;
        private Bunifu.Framework.UI.BunifuTileButton oldmodzlabel;
        private System.Windows.Forms.Timer MyTimer;
		private System.Windows.Forms.Timer load;
	}
}
