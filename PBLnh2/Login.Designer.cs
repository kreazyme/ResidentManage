
namespace PBLnh2
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.Button();
            this.txtCan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(309, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 28);
            this.txtID.TabIndex = 2;
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(309, 142);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(169, 28);
            this.txtpw.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(101, 225);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(165, 40);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "Đăng nhập";
            this.txtLogin.UseVisualStyleBackColor = true;
            // 
            // txtCan
            // 
            this.txtCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCan.Location = new System.Drawing.Point(372, 215);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(115, 40);
            this.txtCan.TabIndex = 5;
            this.txtCan.Text = "Huỷ";
            this.txtCan.UseVisualStyleBackColor = true;
            this.txtCan.Click += new System.EventHandler(this.txtCan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chưa có tài khoản? Tạo tài khoản mới để đăng nhập";
            // 
            // txtCreate
            // 
            this.txtCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreate.Location = new System.Drawing.Point(197, 340);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(208, 40);
            this.txtCreate.TabIndex = 7;
            this.txtCreate.Text = "Tạo tài khoản mới";
            this.txtCreate.UseVisualStyleBackColor = true;
            this.txtCreate.Click += new System.EventHandler(this.txtCreate_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 431);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button txtLogin;
        private System.Windows.Forms.Button txtCan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtCreate;
    }
}