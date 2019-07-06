namespace 课程管理系统
{
    partial class FrmStudentLogin
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonselect = new System.Windows.Forms.Button();
            this.buttonreturn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPrimary = new System.Windows.Forms.Button();
            this.buttonSelectstudent = new System.Windows.Forms.Button();
            this.buttonSelectteacher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Yellow;
            this.labelName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(12, 133);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 20);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "label2";
            // 
            // buttonselect
            // 
            this.buttonselect.Location = new System.Drawing.Point(206, 133);
            this.buttonselect.Name = "buttonselect";
            this.buttonselect.Size = new System.Drawing.Size(85, 25);
            this.buttonselect.TabIndex = 13;
            this.buttonselect.Text = "正选";
            this.buttonselect.UseVisualStyleBackColor = true;
            this.buttonselect.Click += new System.EventHandler(this.Buttonselect_Click);
            // 
            // buttonreturn
            // 
            this.buttonreturn.Location = new System.Drawing.Point(206, 293);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(85, 27);
            this.buttonreturn.TabIndex = 16;
            this.buttonreturn.Text = "返回上一页";
            this.buttonreturn.UseVisualStyleBackColor = true;
            this.buttonreturn.Click += new System.EventHandler(this.Buttonreturn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // buttonPrimary
            // 
            this.buttonPrimary.Location = new System.Drawing.Point(206, 84);
            this.buttonPrimary.Name = "buttonPrimary";
            this.buttonPrimary.Size = new System.Drawing.Size(85, 28);
            this.buttonPrimary.TabIndex = 17;
            this.buttonPrimary.Text = "预选";
            this.buttonPrimary.UseVisualStyleBackColor = true;
            this.buttonPrimary.Click += new System.EventHandler(this.ButtonPrimary_Click);
            // 
            // buttonSelectstudent
            // 
            this.buttonSelectstudent.Location = new System.Drawing.Point(206, 174);
            this.buttonSelectstudent.Name = "buttonSelectstudent";
            this.buttonSelectstudent.Size = new System.Drawing.Size(85, 27);
            this.buttonSelectstudent.TabIndex = 18;
            this.buttonSelectstudent.Text = "查询学生信息";
            this.buttonSelectstudent.UseVisualStyleBackColor = true;
            this.buttonSelectstudent.Click += new System.EventHandler(this.ButtonSelectstudent_Click);
            // 
            // buttonSelectteacher
            // 
            this.buttonSelectteacher.Location = new System.Drawing.Point(206, 216);
            this.buttonSelectteacher.Name = "buttonSelectteacher";
            this.buttonSelectteacher.Size = new System.Drawing.Size(85, 27);
            this.buttonSelectteacher.TabIndex = 19;
            this.buttonSelectteacher.Text = "查询老师信息";
            this.buttonSelectteacher.UseVisualStyleBackColor = true;
            this.buttonSelectteacher.Click += new System.EventHandler(this.ButtonSelectteacher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "查看成绩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // FrmStudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::课程管理系统.Properties.Resources.v2_b4e1d990c989fd78d3e5bac0e0593255;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSelectteacher);
            this.Controls.Add(this.buttonSelectstudent);
            this.Controls.Add(this.buttonPrimary);
            this.Controls.Add(this.buttonreturn);
            this.Controls.Add(this.buttonselect);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmStudentLogin";
            this.Text = "学生";
            this.Load += new System.EventHandler(this.FrmStudentLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonselect;
        private System.Windows.Forms.Button buttonreturn;
        private System.Windows.Forms.Button buttonPrimary;
        private System.Windows.Forms.Button buttonSelectstudent;
        private System.Windows.Forms.Button buttonSelectteacher;
        private System.Windows.Forms.Button button1;
    }
}