namespace autologin
{
    partial class Form1
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_code = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.txt_cookie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(177, 259);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(101, 65);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // btn_code
            // 
            this.btn_code.Location = new System.Drawing.Point(177, 46);
            this.btn_code.Name = "btn_code";
            this.btn_code.Size = new System.Drawing.Size(235, 52);
            this.btn_code.TabIndex = 1;
            this.btn_code.UseVisualStyleBackColor = true;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(177, 191);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 21);
            this.txt_code.TabIndex = 2;
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(370, 206);
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_res.Size = new System.Drawing.Size(301, 179);
            this.txt_res.TabIndex = 3;
            // 
            // txt_cookie
            // 
            this.txt_cookie.Location = new System.Drawing.Point(460, 118);
            this.txt_cookie.Name = "txt_cookie";
            this.txt_cookie.Size = new System.Drawing.Size(100, 21);
            this.txt_cookie.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_cookie);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.btn_code);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_code;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.TextBox txt_cookie;
    }
}

