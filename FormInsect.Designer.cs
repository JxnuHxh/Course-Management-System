namespace 课程管理系统
{
    partial class FormInsect
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxScode = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelScode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(209, 226);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = "确认增加";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // textBoxScode
            // 
            this.textBoxScode.Location = new System.Drawing.Point(209, 46);
            this.textBoxScode.Name = "textBoxScode";
            this.textBoxScode.Size = new System.Drawing.Size(100, 21);
            this.textBoxScode.TabIndex = 1;
            this.textBoxScode.TextChanged += new System.EventHandler(this.TextBoxScode_TextChanged);
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(209, 100);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(100, 21);
            this.textBoxGender.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(209, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(209, 140);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(100, 21);
            this.textBoxClass.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(209, 179);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelScode
            // 
            this.labelScode.AutoSize = true;
            this.labelScode.Location = new System.Drawing.Point(153, 49);
            this.labelScode.Name = "labelScode";
            this.labelScode.Size = new System.Drawing.Size(29, 12);
            this.labelScode.TabIndex = 6;
            this.labelScode.Text = "学号";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(153, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 12);
            this.labelName.TabIndex = 7;
            this.labelName.Text = " 姓名";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(153, 103);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(29, 12);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "性别";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(147, 143);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(35, 12);
            this.labelClass.TabIndex = 9;
            this.labelClass.Text = " 班级";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(153, 182);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 12);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "登录密码";
            // 
            // buttonreturn
            // 
            this.buttonreturn.Location = new System.Drawing.Point(-3, -1);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(75, 23);
            this.buttonreturn.TabIndex = 11;
            this.buttonreturn.Text = "返回上一页";
            this.buttonreturn.UseVisualStyleBackColor = true;
            this.buttonreturn.Click += new System.EventHandler(this.Buttonreturn_Click);
            // 
            // FormInsect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::课程管理系统.Properties.Resources.v2_b4e1d990c989fd78d3e5bac0e0593255;
            this.ClientSize = new System.Drawing.Size(564, 270);
            this.Controls.Add(this.buttonreturn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScode);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxScode);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "FormInsect";
            this.Text = "增加学生信息";
            this.Load += new System.EventHandler(this.FormInsect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxScode;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelScode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonreturn;
    }
}