namespace morroco_cartes
{
    partial class frmSelect_jocker_type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelect_jocker_type));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flsICON = new System.Windows.Forms.PictureBox();
            this.jbnICON = new System.Windows.Forms.PictureBox();
            this.sifICON = new System.Windows.Forms.PictureBox();
            this.hrwtICON = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flsICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbnICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrwtICON)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flsICON
            // 
            this.flsICON.Image = ((System.Drawing.Image)(resources.GetObject("flsICON.Image")));
            this.flsICON.Location = new System.Drawing.Point(83, 105);
            this.flsICON.Name = "flsICON";
            this.flsICON.Size = new System.Drawing.Size(116, 110);
            this.flsICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flsICON.TabIndex = 1;
            this.flsICON.TabStop = false;
            this.flsICON.Tag = "0";
            this.flsICON.Click += new System.EventHandler(this.gitType);
            // 
            // jbnICON
            // 
            this.jbnICON.Image = ((System.Drawing.Image)(resources.GetObject("jbnICON.Image")));
            this.jbnICON.Location = new System.Drawing.Point(257, 105);
            this.jbnICON.Name = "jbnICON";
            this.jbnICON.Size = new System.Drawing.Size(116, 110);
            this.jbnICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jbnICON.TabIndex = 2;
            this.jbnICON.TabStop = false;
            this.jbnICON.Tag = "1";
            this.jbnICON.Click += new System.EventHandler(this.gitType);
            // 
            // sifICON
            // 
            this.sifICON.Image = ((System.Drawing.Image)(resources.GetObject("sifICON.Image")));
            this.sifICON.Location = new System.Drawing.Point(431, 105);
            this.sifICON.Name = "sifICON";
            this.sifICON.Size = new System.Drawing.Size(116, 110);
            this.sifICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sifICON.TabIndex = 3;
            this.sifICON.TabStop = false;
            this.sifICON.Tag = "2";
            this.sifICON.Click += new System.EventHandler(this.gitType);
            // 
            // hrwtICON
            // 
            this.hrwtICON.Image = ((System.Drawing.Image)(resources.GetObject("hrwtICON.Image")));
            this.hrwtICON.Location = new System.Drawing.Point(605, 105);
            this.hrwtICON.Name = "hrwtICON";
            this.hrwtICON.Size = new System.Drawing.Size(116, 110);
            this.hrwtICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hrwtICON.TabIndex = 4;
            this.hrwtICON.TabStop = false;
            this.hrwtICON.Tag = "3";
            this.hrwtICON.Click += new System.EventHandler(this.gitType);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Joker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmSelect_jocker_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hrwtICON);
            this.Controls.Add(this.sifICON);
            this.Controls.Add(this.jbnICON);
            this.Controls.Add(this.flsICON);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelect_jocker_type";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flsICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbnICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrwtICON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox flsICON;
        private System.Windows.Forms.PictureBox jbnICON;
        private System.Windows.Forms.PictureBox sifICON;
        private System.Windows.Forms.PictureBox hrwtICON;
        private System.Windows.Forms.Label label1;
    }
}