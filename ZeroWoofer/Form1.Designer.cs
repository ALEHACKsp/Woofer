namespace ZeroWoofer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flatClose1 = new theme.FlatClose();
            this.oldmodz95 = new System.Windows.Forms.Panel();
            this.flatContextMenuStrip1 = new theme.FlatContextMenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinServerDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fond = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kaageee = new ZBobb.AlphaBlendTextBox();
            this.insoweb = new ZBobb.AlphaBlendTextBox();
            this.copyoldmodz = new System.Windows.Forms.Label();
            this.songoldmoudz = new System.Windows.Forms.Timer(this.components);
            this.musicstart = new System.Windows.Forms.Timer(this.components);
            this.music = new System.Windows.Forms.Timer(this.components);
            this.oldmodz95.SuspendLayout();
            this.flatContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fond)).BeginInit();
            this.SuspendLayout();
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.Black;
            this.flatClose1.BaseColor = System.Drawing.Color.Transparent;
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(360, 6);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // oldmodz95
            // 
            this.oldmodz95.BackColor = System.Drawing.Color.Transparent;
            this.oldmodz95.ContextMenuStrip = this.flatContextMenuStrip1;
            this.oldmodz95.Controls.Add(this.flatClose1);
            this.oldmodz95.Location = new System.Drawing.Point(-5, -1);
            this.oldmodz95.Name = "oldmodz95";
            this.oldmodz95.Size = new System.Drawing.Size(384, 39);
            this.oldmodz95.TabIndex = 2;
            // 
            // flatContextMenuStrip1
            // 
            this.flatContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatContextMenuStrip1.ForeColor = System.Drawing.Color.White;
            this.flatContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.joinServerDiscordToolStripMenuItem});
            this.flatContextMenuStrip1.Name = "flatContextMenuStrip1";
            this.flatContextMenuStrip1.ShowImageMargin = false;
            this.flatContextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // joinServerDiscordToolStripMenuItem
            // 
            this.joinServerDiscordToolStripMenuItem.Name = "joinServerDiscordToolStripMenuItem";
            this.joinServerDiscordToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.joinServerDiscordToolStripMenuItem.Text = "Join Server Discord";
            this.joinServerDiscordToolStripMenuItem.Click += new System.EventHandler(this.joinServerDiscordToolStripMenuItem_Click);
            // 
            // fond
            // 
            this.fond.Image = global::ZeroWoofer.Properties.Resources.mp4;
            this.fond.Location = new System.Drawing.Point(-5, 1);
            this.fond.Name = "fond";
            this.fond.Size = new System.Drawing.Size(384, 450);
            this.fond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fond.TabIndex = 26;
            this.fond.TabStop = false;
            this.fond.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.oldmodz95;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 19;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 24;
            this.bunifuTileButton1.LabelText = "Login";
            this.bunifuTileButton1.Location = new System.Drawing.Point(148, 309);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(71, 23);
            this.bunifuTileButton1.TabIndex = 11;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // kaageee
            // 
            this.kaageee.BackAlpha = 100;
            this.kaageee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kaageee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kaageee.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaageee.ForeColor = System.Drawing.Color.White;
            this.kaageee.Location = new System.Drawing.Point(69, 265);
            this.kaageee.Name = "kaageee";
            this.kaageee.PasswordChar = '*';
            this.kaageee.Size = new System.Drawing.Size(235, 24);
            this.kaageee.TabIndex = 8;
            this.kaageee.Tag = "";
            this.kaageee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insoweb
            // 
            this.insoweb.BackAlpha = 100;
            this.insoweb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.insoweb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insoweb.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insoweb.ForeColor = System.Drawing.Color.White;
            this.insoweb.Location = new System.Drawing.Point(69, 212);
            this.insoweb.Name = "insoweb";
            this.insoweb.Size = new System.Drawing.Size(235, 24);
            this.insoweb.TabIndex = 7;
            this.insoweb.Tag = "";
            this.insoweb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyoldmodz
            // 
            this.copyoldmodz.AutoSize = true;
            this.copyoldmodz.BackColor = System.Drawing.Color.Transparent;
            this.copyoldmodz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.copyoldmodz.Location = new System.Drawing.Point(106, 437);
            this.copyoldmodz.Name = "copyoldmodz";
            this.copyoldmodz.Size = new System.Drawing.Size(147, 13);
            this.copyoldmodz.TabIndex = 25;
            this.copyoldmodz.Text = "Copyright © 2020 OldModz95";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ZeroWoofer.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 453);
            this.ContextMenuStrip = this.flatContextMenuStrip1;
            this.Controls.Add(this.oldmodz95);
            this.Controls.Add(this.copyoldmodz);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaageee);
            this.Controls.Add(this.insoweb);
            this.Controls.Add(this.fond);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Woofer - Login";
            this.oldmodz95.ResumeLayout(false);
            this.flatContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private theme.FlatClose flatClose1;
        private System.Windows.Forms.Panel oldmodz95;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZBobb.AlphaBlendTextBox kaageee;
        private ZBobb.AlphaBlendTextBox insoweb;
        private theme.FlatContextMenuStrip flatContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.Label copyoldmodz;
        private System.Windows.Forms.ToolStripMenuItem joinServerDiscordToolStripMenuItem;
        private System.Windows.Forms.Timer songoldmoudz;
        private System.Windows.Forms.Timer musicstart;
        private System.Windows.Forms.Timer music;
        private System.Windows.Forms.PictureBox fond;
    }
}

