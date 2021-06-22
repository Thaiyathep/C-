
namespace OH_OH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsernameTextBoxForm1 = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxForm1 = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextBoxForm1
            // 
            this.UsernameTextBoxForm1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBoxForm1.Location = new System.Drawing.Point(487, 181);
            this.UsernameTextBoxForm1.Multiline = true;
            this.UsernameTextBoxForm1.Name = "UsernameTextBoxForm1";
            this.UsernameTextBoxForm1.Size = new System.Drawing.Size(224, 39);
            this.UsernameTextBoxForm1.TabIndex = 0;
            // 
            // PasswordTextBoxForm1
            // 
            this.PasswordTextBoxForm1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBoxForm1.Location = new System.Drawing.Point(487, 254);
            this.PasswordTextBoxForm1.Multiline = true;
            this.PasswordTextBoxForm1.Name = "PasswordTextBoxForm1";
            this.PasswordTextBoxForm1.PasswordChar = '*';
            this.PasswordTextBoxForm1.Size = new System.Drawing.Size(224, 39);
            this.PasswordTextBoxForm1.TabIndex = 1;
            // 
            // enterbutton
            // 
            this.enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbutton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbutton.Location = new System.Drawing.Point(501, 331);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(188, 51);
            this.enterbutton.TabIndex = 2;
            this.enterbutton.Text = "เข้าสู่ระบบ";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applybutton.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applybutton.Location = new System.Drawing.Point(501, 427);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(188, 46);
            this.applybutton.TabIndex = 3;
            this.applybutton.Text = "สมัครสมาชิก";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 551);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.PasswordTextBoxForm1);
            this.Controls.Add(this.UsernameTextBoxForm1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBoxForm1;
        private System.Windows.Forms.TextBox PasswordTextBoxForm1;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button applybutton;
    }
}

