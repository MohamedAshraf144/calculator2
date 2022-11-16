namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btndedvide = new Guna.UI2.WinForms.Guna2Button();
            this.btnplus = new Guna.UI2.WinForms.Guna2Button();
            this.btnmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnmulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnnine = new Guna.UI2.WinForms.Guna2Button();
            this.btnthree = new Guna.UI2.WinForms.Guna2Button();
            this.btnsix = new Guna.UI2.WinForms.Guna2Button();
            this.btnrd = new Guna.UI2.WinForms.Guna2Button();
            this.btnseven = new Guna.UI2.WinForms.Guna2Button();
            this.btnone = new Guna.UI2.WinForms.Guna2Button();
            this.btnfour = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btneight = new Guna.UI2.WinForms.Guna2Button();
            this.btntwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.btnzero = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.txtstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtresualt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageRotate = 0F;
            this.btnexit.Location = new System.Drawing.Point(308, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(53, 47);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(2, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(229, 46);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "calculator";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndedvide
            // 
            this.btndedvide.BackColor = System.Drawing.Color.Transparent;
            this.btndedvide.BorderRadius = 15;
            this.btndedvide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndedvide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndedvide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndedvide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndedvide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndedvide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndedvide.ForeColor = System.Drawing.Color.Red;
            this.btndedvide.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btndedvide.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndedvide.Location = new System.Drawing.Point(286, 254);
            this.btndedvide.Name = "btndedvide";
            this.btndedvide.ShadowDecoration.BorderRadius = 15;
            this.btndedvide.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btndedvide.ShadowDecoration.Enabled = true;
            this.btndedvide.Size = new System.Drawing.Size(58, 47);
            this.btndedvide.TabIndex = 2;
            this.btndedvide.Text = "/";
            this.btndedvide.Click += new System.EventHandler(this.btndedvide_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.BorderRadius = 15;
            this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnplus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnplus.ForeColor = System.Drawing.Color.Red;
            this.btnplus.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnplus.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnplus.Location = new System.Drawing.Point(286, 379);
            this.btnplus.Name = "btnplus";
            this.btnplus.ShadowDecoration.BorderRadius = 15;
            this.btnplus.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnplus.ShadowDecoration.Enabled = true;
            this.btnplus.Size = new System.Drawing.Size(58, 47);
            this.btnplus.TabIndex = 3;
            this.btnplus.Text = "+";
            this.btnplus.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BorderRadius = 15;
            this.btnmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmin.ForeColor = System.Drawing.Color.Red;
            this.btnmin.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnmin.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmin.Location = new System.Drawing.Point(286, 444);
            this.btnmin.Name = "btnmin";
            this.btnmin.ShadowDecoration.BorderRadius = 15;
            this.btnmin.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnmin.ShadowDecoration.Enabled = true;
            this.btnmin.Size = new System.Drawing.Size(58, 47);
            this.btnmin.TabIndex = 4;
            this.btnmin.Text = "-";
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.Transparent;
            this.btnmulti.BorderRadius = 15;
            this.btnmulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmulti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnmulti.ForeColor = System.Drawing.Color.Red;
            this.btnmulti.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnmulti.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnmulti.Location = new System.Drawing.Point(286, 317);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.ShadowDecoration.BorderRadius = 15;
            this.btnmulti.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnmulti.ShadowDecoration.Enabled = true;
            this.btnmulti.Size = new System.Drawing.Size(58, 47);
            this.btnmulti.TabIndex = 5;
            this.btnmulti.Text = "*";
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BorderRadius = 15;
            this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnnine.ForeColor = System.Drawing.Color.Red;
            this.btnnine.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnnine.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnnine.Location = new System.Drawing.Point(201, 317);
            this.btnnine.Name = "btnnine";
            this.btnnine.ShadowDecoration.BorderRadius = 15;
            this.btnnine.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnnine.ShadowDecoration.Enabled = true;
            this.btnnine.Size = new System.Drawing.Size(58, 47);
            this.btnnine.TabIndex = 9;
            this.btnnine.Text = "9";
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BorderRadius = 15;
            this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnthree.ForeColor = System.Drawing.Color.Red;
            this.btnthree.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnthree.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnthree.Location = new System.Drawing.Point(201, 444);
            this.btnthree.Name = "btnthree";
            this.btnthree.ShadowDecoration.BorderRadius = 15;
            this.btnthree.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnthree.ShadowDecoration.Enabled = true;
            this.btnthree.Size = new System.Drawing.Size(58, 47);
            this.btnthree.TabIndex = 8;
            this.btnthree.Text = "3";
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BorderRadius = 15;
            this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnsix.ForeColor = System.Drawing.Color.Red;
            this.btnsix.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnsix.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnsix.Location = new System.Drawing.Point(201, 379);
            this.btnsix.Name = "btnsix";
            this.btnsix.ShadowDecoration.BorderRadius = 15;
            this.btnsix.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnsix.ShadowDecoration.Enabled = true;
            this.btnsix.Size = new System.Drawing.Size(58, 47);
            this.btnsix.TabIndex = 7;
            this.btnsix.Text = "6";
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnrd
            // 
            this.btnrd.BackColor = System.Drawing.Color.Transparent;
            this.btnrd.BorderRadius = 15;
            this.btnrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrd.ForeColor = System.Drawing.Color.Red;
            this.btnrd.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnrd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnrd.Location = new System.Drawing.Point(201, 254);
            this.btnrd.Name = "btnrd";
            this.btnrd.ShadowDecoration.BorderRadius = 15;
            this.btnrd.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnrd.ShadowDecoration.Enabled = true;
            this.btnrd.Size = new System.Drawing.Size(58, 47);
            this.btnrd.TabIndex = 6;
            this.btnrd.Text = "%";
            this.btnrd.Click += new System.EventHandler(this.btnrd_Click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BorderRadius = 15;
            this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnseven.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnseven.ForeColor = System.Drawing.Color.Red;
            this.btnseven.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnseven.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnseven.Location = new System.Drawing.Point(30, 317);
            this.btnseven.Name = "btnseven";
            this.btnseven.ShadowDecoration.BorderRadius = 15;
            this.btnseven.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnseven.ShadowDecoration.Enabled = true;
            this.btnseven.Size = new System.Drawing.Size(58, 47);
            this.btnseven.TabIndex = 17;
            this.btnseven.Text = "7";
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BorderRadius = 15;
            this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnone.ForeColor = System.Drawing.Color.Red;
            this.btnone.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnone.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnone.Location = new System.Drawing.Point(30, 444);
            this.btnone.Name = "btnone";
            this.btnone.ShadowDecoration.BorderRadius = 15;
            this.btnone.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnone.ShadowDecoration.Enabled = true;
            this.btnone.Size = new System.Drawing.Size(58, 47);
            this.btnone.TabIndex = 16;
            this.btnone.Text = "1";
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BorderRadius = 15;
            this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfour.ForeColor = System.Drawing.Color.Red;
            this.btnfour.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnfour.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfour.Location = new System.Drawing.Point(30, 379);
            this.btnfour.Name = "btnfour";
            this.btnfour.ShadowDecoration.BorderRadius = 15;
            this.btnfour.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnfour.ShadowDecoration.Enabled = true;
            this.btnfour.Size = new System.Drawing.Size(58, 47);
            this.btnfour.TabIndex = 15;
            this.btnfour.Text = "4";
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnclear.ForeColor = System.Drawing.Color.Red;
            this.btnclear.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnclear.Location = new System.Drawing.Point(29, 254);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.Size = new System.Drawing.Size(143, 47);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.guna2Button12_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BorderRadius = 15;
            this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btneight.ForeColor = System.Drawing.Color.Red;
            this.btneight.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btneight.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btneight.Location = new System.Drawing.Point(115, 317);
            this.btneight.Name = "btneight";
            this.btneight.ShadowDecoration.BorderRadius = 15;
            this.btneight.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btneight.ShadowDecoration.Enabled = true;
            this.btneight.Size = new System.Drawing.Size(58, 47);
            this.btneight.TabIndex = 13;
            this.btneight.Text = "8";
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BorderRadius = 15;
            this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntwo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btntwo.ForeColor = System.Drawing.Color.Red;
            this.btntwo.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btntwo.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btntwo.Location = new System.Drawing.Point(115, 444);
            this.btntwo.Name = "btntwo";
            this.btntwo.ShadowDecoration.BorderRadius = 15;
            this.btntwo.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btntwo.ShadowDecoration.Enabled = true;
            this.btntwo.Size = new System.Drawing.Size(58, 47);
            this.btntwo.TabIndex = 12;
            this.btntwo.Text = "2";
            this.btntwo.Click += new System.EventHandler(this.guna2Button14_Click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BorderRadius = 15;
            this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnfive.ForeColor = System.Drawing.Color.Red;
            this.btnfive.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnfive.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnfive.Location = new System.Drawing.Point(115, 379);
            this.btnfive.Name = "btnfive";
            this.btnfive.ShadowDecoration.BorderRadius = 15;
            this.btnfive.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnfive.ShadowDecoration.Enabled = true;
            this.btnfive.Size = new System.Drawing.Size(58, 47);
            this.btnfive.TabIndex = 11;
            this.btnfive.Text = "5";
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BorderRadius = 15;
            this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnzero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnzero.ForeColor = System.Drawing.Color.Red;
            this.btnzero.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnzero.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnzero.Location = new System.Drawing.Point(29, 513);
            this.btnzero.Name = "btnzero";
            this.btnzero.ShadowDecoration.BorderRadius = 15;
            this.btnzero.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnzero.ShadowDecoration.Enabled = true;
            this.btnzero.Size = new System.Drawing.Size(58, 47);
            this.btnzero.TabIndex = 20;
            this.btnzero.Text = "0";
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndot.ForeColor = System.Drawing.Color.Red;
            this.btndot.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btndot.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btndot.Location = new System.Drawing.Point(115, 513);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.Size = new System.Drawing.Size(58, 47);
            this.btndot.TabIndex = 19;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnequal.ForeColor = System.Drawing.Color.Red;
            this.btnequal.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btnequal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnequal.Location = new System.Drawing.Point(201, 513);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.Size = new System.Drawing.Size(143, 47);
            this.btnequal.TabIndex = 18;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.guna2Button19_Click);
            // 
            // txtstore
            // 
            this.txtstore.BorderThickness = 0;
            this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstore.DefaultText = "";
            this.txtstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Location = new System.Drawing.Point(29, 173);
            this.txtstore.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtstore.Name = "txtstore";
            this.txtstore.PasswordChar = '\0';
            this.txtstore.PlaceholderText = "";
            this.txtstore.SelectedText = "";
            this.txtstore.Size = new System.Drawing.Size(315, 62);
            this.txtstore.TabIndex = 21;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtresualt
            // 
            this.txtresualt.BorderThickness = 0;
            this.txtresualt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresualt.DefaultText = "";
            this.txtresualt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtresualt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtresualt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresualt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresualt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.txtresualt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresualt.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtresualt.ForeColor = System.Drawing.Color.White;
            this.txtresualt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresualt.Location = new System.Drawing.Point(29, 93);
            this.txtresualt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtresualt.Name = "txtresualt";
            this.txtresualt.PasswordChar = '\0';
            this.txtresualt.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtresualt.PlaceholderText = "0";
            this.txtresualt.SelectedText = "";
            this.txtresualt.Size = new System.Drawing.Size(315, 62);
            this.txtresualt.TabIndex = 22;
            this.txtresualt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.txtresualt);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnrd);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btndedvide);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnexit;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btndedvide;
        private Guna.UI2.WinForms.Guna2Button btnplus;
        private Guna.UI2.WinForms.Guna2Button btnmin;
        private Guna.UI2.WinForms.Guna2Button btnmulti;
        private Guna.UI2.WinForms.Guna2Button btnnine;
        private Guna.UI2.WinForms.Guna2Button btnthree;
        private Guna.UI2.WinForms.Guna2Button btnsix;
        private Guna.UI2.WinForms.Guna2Button btnrd;
        private Guna.UI2.WinForms.Guna2Button btnseven;
        private Guna.UI2.WinForms.Guna2Button btnone;
        private Guna.UI2.WinForms.Guna2Button btnfour;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btneight;
        private Guna.UI2.WinForms.Guna2Button btntwo;
        private Guna.UI2.WinForms.Guna2Button btnfive;
        private Guna.UI2.WinForms.Guna2Button btnzero;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2TextBox txtstore;
        private Guna.UI2.WinForms.Guna2TextBox txtresualt;
    }
}

