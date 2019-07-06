namespace 课程管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelScode = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Yellow;
            this.btnLogin.Location = new System.Drawing.Point(195, 277);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 53);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "江西师范大学";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 41);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 41);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // labelScode
            // 
            this.labelScode.AutoSize = true;
            this.labelScode.Location = new System.Drawing.Point(79, 128);
            this.labelScode.Name = "labelScode";
            this.labelScode.Size = new System.Drawing.Size(73, 29);
            this.labelScode.TabIndex = 8;
            this.labelScode.Text = "学号";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(79, 217);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 29);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "密码";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "学生",
            "管理员",
            "教师"});
            this.comboBox1.Location = new System.Drawing.Point(215, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "学生 ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::课程管理系统.Properties.Resources.v2_b4e1d990c989fd78d3e5bac0e0593255;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelScode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmMain";
            this.Text = " 学生课程管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelScode;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBox1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

