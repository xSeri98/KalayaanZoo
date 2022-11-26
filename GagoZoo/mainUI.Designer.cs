namespace KalayaanZoo
{
    partial class mainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dashBtn = new System.Windows.Forms.Button();
            this.viewAnimalsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDLbl = new System.Windows.Forms.Label();
            this.mngIDLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewKeepersBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "KZOO Management System 1.0";
            // 
            // minBtn
            // 
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(908, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(48, 29);
            this.minBtn.TabIndex = 2;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(961, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(48, 29);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.dashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashBtn.FlatAppearance.BorderSize = 0;
            this.dashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBtn.ForeColor = System.Drawing.Color.Azure;
            this.dashBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashBtn.Image")));
            this.dashBtn.Location = new System.Drawing.Point(0, 170);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(197, 35);
            this.dashBtn.TabIndex = 1;
            this.dashBtn.Text = "Dashboard";
            this.dashBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashBtn.UseVisualStyleBackColor = false;
            // 
            // viewAnimalsBtn
            // 
            this.viewAnimalsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.viewAnimalsBtn.FlatAppearance.BorderSize = 0;
            this.viewAnimalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAnimalsBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.viewAnimalsBtn.ForeColor = System.Drawing.Color.Azure;
            this.viewAnimalsBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewAnimalsBtn.Image")));
            this.viewAnimalsBtn.Location = new System.Drawing.Point(3, 211);
            this.viewAnimalsBtn.Name = "viewAnimalsBtn";
            this.viewAnimalsBtn.Size = new System.Drawing.Size(197, 35);
            this.viewAnimalsBtn.TabIndex = 2;
            this.viewAnimalsBtn.Text = "View Animals";
            this.viewAnimalsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewAnimalsBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.viewKeepersBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.IDLbl);
            this.panel2.Controls.Add(this.mngIDLbl);
            this.panel2.Controls.Add(this.userNameLbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dashBtn);
            this.panel2.Controls.Add(this.viewAnimalsBtn);
            this.panel2.Location = new System.Drawing.Point(-1, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 704);
            this.panel2.TabIndex = 3;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDLbl.Location = new System.Drawing.Point(106, 121);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(17, 19);
            this.IDLbl.TabIndex = 6;
            this.IDLbl.Text = "0";
            // 
            // mngIDLbl
            // 
            this.mngIDLbl.AutoSize = true;
            this.mngIDLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngIDLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mngIDLbl.Location = new System.Drawing.Point(84, 121);
            this.mngIDLbl.Name = "mngIDLbl";
            this.mngIDLbl.Size = new System.Drawing.Size(29, 19);
            this.mngIDLbl.TabIndex = 5;
            this.mngIDLbl.Text = "ID: ";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userNameLbl.Location = new System.Drawing.Point(84, 98);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(73, 19);
            this.userNameLbl.TabIndex = 4;
            this.userNameLbl.Text = "userName";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(27, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 51);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 67);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "KZ-MS 1.0";
            // 
            // viewKeepersBtn
            // 
            this.viewKeepersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.viewKeepersBtn.FlatAppearance.BorderSize = 0;
            this.viewKeepersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewKeepersBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.viewKeepersBtn.ForeColor = System.Drawing.Color.Azure;
            this.viewKeepersBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewKeepersBtn.Image")));
            this.viewKeepersBtn.Location = new System.Drawing.Point(-9, 252);
            this.viewKeepersBtn.Name = "viewKeepersBtn";
            this.viewKeepersBtn.Size = new System.Drawing.Size(209, 35);
            this.viewKeepersBtn.TabIndex = 7;
            this.viewKeepersBtn.Text = "Keepers";
            this.viewKeepersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewKeepersBtn.UseVisualStyleBackColor = false;
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "mainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mainUI";
            this.Load += new System.EventHandler(this.mainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.Button viewAnimalsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mngIDLbl;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewKeepersBtn;
    }
}