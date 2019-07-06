namespace 课程管理系统
{
    partial class Form4
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
            this.buttonInsect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInsect
            // 
            this.buttonInsect.Location = new System.Drawing.Point(108, 42);
            this.buttonInsect.Name = "buttonInsect";
            this.buttonInsect.Size = new System.Drawing.Size(124, 30);
            this.buttonInsect.TabIndex = 0;
            this.buttonInsect.Text = "增加学生信息";
            this.buttonInsect.UseVisualStyleBackColor = true;
            this.buttonInsect.Click += new System.EventHandler(this.ButtonInsect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(108, 97);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 36);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "删除学生信息";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(108, 157);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(124, 34);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "修改学生信息";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(108, 214);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(124, 33);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "查询学生信息";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(313, 118);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(99, 61);
            this.buttonSchedule.TabIndex = 4;
            this.buttonSchedule.Text = "安排课程";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.ButtonSchedule_Click);
            // 
            // buttonreturn
            // 
            this.buttonreturn.Location = new System.Drawing.Point(-3, 0);
            this.buttonreturn.Name = "buttonreturn";
            this.buttonreturn.Size = new System.Drawing.Size(75, 23);
            this.buttonreturn.TabIndex = 5;
            this.buttonreturn.Text = "返回上一页";
            this.buttonreturn.UseVisualStyleBackColor = true;
            this.buttonreturn.Click += new System.EventHandler(this.Buttonreturn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::课程管理系统.Properties.Resources.v2_b4e1d990c989fd78d3e5bac0e0593255;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 416);
            this.Controls.Add(this.buttonreturn);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsect);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsect;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonreturn;
    }
}