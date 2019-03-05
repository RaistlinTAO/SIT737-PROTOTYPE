namespace sit737
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdunRegister = new System.Windows.Forms.Button();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdReadLocation = new System.Windows.Forms.Button();
            this.cmdSaveLocation = new System.Windows.Forms.Button();
            this.cmdPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.cmdSavePicture = new System.Windows.Forms.Button();
            this.cmdEmotion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdCheckReg = new System.Windows.Forms.Button();
            this.opFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 131);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prototype for SIT737 - Service Oriented Architectures And Technologies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Children Tracking System";
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.panTitle.Controls.Add(this.lblClose);
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(802, 26);
            this.panTitle.TabIndex = 0;
            this.panTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(775, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 18);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 31);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCheckReg);
            this.groupBox1.Controls.Add(this.cmdunRegister);
            this.groupBox1.Controls.Add(this.cmdRegister);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // cmdunRegister
            // 
            this.cmdunRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdunRegister.Location = new System.Drawing.Point(331, 19);
            this.cmdunRegister.Name = "cmdunRegister";
            this.cmdunRegister.Size = new System.Drawing.Size(157, 23);
            this.cmdunRegister.TabIndex = 1;
            this.cmdunRegister.Text = "unRegister";
            this.cmdunRegister.UseVisualStyleBackColor = true;
            this.cmdunRegister.Click += new System.EventHandler(this.cmdunRegister_Click);
            // 
            // cmdRegister
            // 
            this.cmdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegister.Location = new System.Drawing.Point(97, 19);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(157, 23);
            this.cmdRegister.TabIndex = 0;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdEmotion);
            this.groupBox2.Controls.Add(this.cmdSavePicture);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 26);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResponse);
            this.groupBox3.Location = new System.Drawing.Point(12, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 181);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response from server";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtSection);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtArea);
            this.groupBox4.Controls.Add(this.cmdPath);
            this.groupBox4.Controls.Add(this.cmdReadLocation);
            this.groupBox4.Controls.Add(this.cmdSaveLocation);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 112);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Register";
            // 
            // cmdReadLocation
            // 
            this.cmdReadLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReadLocation.Location = new System.Drawing.Point(331, 65);
            this.cmdReadLocation.Name = "cmdReadLocation";
            this.cmdReadLocation.Size = new System.Drawing.Size(157, 23);
            this.cmdReadLocation.TabIndex = 1;
            this.cmdReadLocation.Text = "Read Latest Location";
            this.cmdReadLocation.UseVisualStyleBackColor = true;
            this.cmdReadLocation.Click += new System.EventHandler(this.cmdReadLocation_Click);
            // 
            // cmdSaveLocation
            // 
            this.cmdSaveLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveLocation.Location = new System.Drawing.Point(97, 65);
            this.cmdSaveLocation.Name = "cmdSaveLocation";
            this.cmdSaveLocation.Size = new System.Drawing.Size(157, 23);
            this.cmdSaveLocation.TabIndex = 0;
            this.cmdSaveLocation.Text = "Trigger Location Save";
            this.cmdSaveLocation.UseVisualStyleBackColor = true;
            this.cmdSaveLocation.Click += new System.EventHandler(this.cmdSaveLocation_Click);
            // 
            // cmdPath
            // 
            this.cmdPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPath.Location = new System.Drawing.Point(563, 65);
            this.cmdPath.Name = "cmdPath";
            this.cmdPath.Size = new System.Drawing.Size(157, 23);
            this.cmdPath.TabIndex = 2;
            this.cmdPath.Text = "Read Path";
            this.cmdPath.UseVisualStyleBackColor = true;
            this.cmdPath.Click += new System.EventHandler(this.cmdPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RFID No.";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 142);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 23);
            this.txtID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(97, 27);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(157, 23);
            this.txtArea.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Section";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(331, 27);
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(157, 23);
            this.txtSection.TabIndex = 10;
            // 
            // cmdSavePicture
            // 
            this.cmdSavePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSavePicture.Location = new System.Drawing.Point(331, 29);
            this.cmdSavePicture.Name = "cmdSavePicture";
            this.cmdSavePicture.Size = new System.Drawing.Size(157, 23);
            this.cmdSavePicture.TabIndex = 1;
            this.cmdSavePicture.Text = "Save Picture to Server";
            this.cmdSavePicture.UseVisualStyleBackColor = true;
            this.cmdSavePicture.Click += new System.EventHandler(this.cmdSavePicture_Click);
            // 
            // cmdEmotion
            // 
            this.cmdEmotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEmotion.Location = new System.Drawing.Point(563, 29);
            this.cmdEmotion.Name = "cmdEmotion";
            this.cmdEmotion.Size = new System.Drawing.Size(157, 23);
            this.cmdEmotion.TabIndex = 2;
            this.cmdEmotion.Text = "Emotion Test";
            this.cmdEmotion.UseVisualStyleBackColor = true;
            this.cmdEmotion.Click += new System.EventHandler(this.cmdEmotion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "(Interger Only, supposed get from RFID reader)";
            // 
            // cmdCheck
            // 
            this.cmdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheck.Location = new System.Drawing.Point(644, 142);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(143, 23);
            this.cmdCheck.TabIndex = 9;
            this.cmdCheck.Text = "Check Service Status";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponse.Location = new System.Drawing.Point(7, 20);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(762, 108);
            this.txtResponse.TabIndex = 0;
            // 
            // cmdCheckReg
            // 
            this.cmdCheckReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheckReg.Location = new System.Drawing.Point(563, 19);
            this.cmdCheckReg.Name = "cmdCheckReg";
            this.cmdCheckReg.Size = new System.Drawing.Size(157, 23);
            this.cmdCheckReg.TabIndex = 2;
            this.cmdCheckReg.Text = "Registered Number";
            this.cmdCheckReg.UseVisualStyleBackColor = true;
            this.cmdCheckReg.Click += new System.EventHandler(this.cmdCheckReg_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdunRegister;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Button cmdEmotion;
        private System.Windows.Forms.Button cmdSavePicture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button cmdPath;
        private System.Windows.Forms.Button cmdReadLocation;
        private System.Windows.Forms.Button cmdSaveLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdCheckReg;
        private System.Windows.Forms.OpenFileDialog opFile;
    }
}

