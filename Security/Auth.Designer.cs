
namespace Security
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerText = new System.Windows.Forms.Label();
            this.boxMaskPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxCaptha = new System.Windows.Forms.PictureBox();
            this.boxCaptha = new System.Windows.Forms.TextBox();
            this.updateCaptha = new System.Windows.Forms.Button();
            this.completeCaptha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaptha)).BeginInit();
            this.SuspendLayout();
            // 
            // boxLogin
            // 
            this.boxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxLogin.Location = new System.Drawing.Point(239, 192);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(304, 26);
            this.boxLogin.TabIndex = 0;
            this.boxLogin.Text = "admin1";
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPassword.Location = new System.Drawing.Point(239, 268);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(304, 26);
            this.boxPassword.TabIndex = 1;
            this.boxPassword.Text = "admin1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(356, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(350, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(239, 349);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(304, 42);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Авторизоваться";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 56);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(183, 5);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(733, 39);
            this.headerText.TabIndex = 8;
            this.headerText.Text = "ОТДЕЛ ВНЕВЕДОМСТВЕННОЙ ОХРАНЫ";
            // 
            // boxMaskPassword
            // 
            this.boxMaskPassword.AutoSize = true;
            this.boxMaskPassword.Location = new System.Drawing.Point(239, 302);
            this.boxMaskPassword.Name = "boxMaskPassword";
            this.boxMaskPassword.Size = new System.Drawing.Size(114, 17);
            this.boxMaskPassword.TabIndex = 9;
            this.boxMaskPassword.Text = "Показать пароль";
            this.boxMaskPassword.UseVisualStyleBackColor = true;
            this.boxMaskPassword.CheckedChanged += new System.EventHandler(this.boxMaskPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(817, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Подтвердите, что вы не робот";
            // 
            // picBoxCaptha
            // 
            this.picBoxCaptha.Location = new System.Drawing.Point(820, 148);
            this.picBoxCaptha.Name = "picBoxCaptha";
            this.picBoxCaptha.Size = new System.Drawing.Size(270, 100);
            this.picBoxCaptha.TabIndex = 11;
            this.picBoxCaptha.TabStop = false;
            // 
            // boxCaptha
            // 
            this.boxCaptha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxCaptha.Location = new System.Drawing.Point(821, 265);
            this.boxCaptha.Name = "boxCaptha";
            this.boxCaptha.Size = new System.Drawing.Size(270, 29);
            this.boxCaptha.TabIndex = 12;
            // 
            // updateCaptha
            // 
            this.updateCaptha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.updateCaptha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCaptha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateCaptha.ForeColor = System.Drawing.Color.White;
            this.updateCaptha.Location = new System.Drawing.Point(820, 349);
            this.updateCaptha.Name = "updateCaptha";
            this.updateCaptha.Size = new System.Drawing.Size(270, 42);
            this.updateCaptha.TabIndex = 13;
            this.updateCaptha.Text = "Обновить";
            this.updateCaptha.UseVisualStyleBackColor = false;
            this.updateCaptha.Click += new System.EventHandler(this.updateCaptha_Click);
            // 
            // completeCaptha
            // 
            this.completeCaptha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.completeCaptha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeCaptha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeCaptha.ForeColor = System.Drawing.Color.White;
            this.completeCaptha.Location = new System.Drawing.Point(820, 302);
            this.completeCaptha.Name = "completeCaptha";
            this.completeCaptha.Size = new System.Drawing.Size(270, 42);
            this.completeCaptha.TabIndex = 14;
            this.completeCaptha.Text = "Подтвердить";
            this.completeCaptha.UseVisualStyleBackColor = false;
            this.completeCaptha.Click += new System.EventHandler(this.completeCaptha_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1134, 441);
            this.Controls.Add(this.completeCaptha);
            this.Controls.Add(this.updateCaptha);
            this.Controls.Add(this.boxCaptha);
            this.Controls.Add(this.picBoxCaptha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxMaskPassword);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.boxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел вневедомственной охраны: Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaptha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.CheckBox boxMaskPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxCaptha;
        private System.Windows.Forms.TextBox boxCaptha;
        private System.Windows.Forms.Button updateCaptha;
        private System.Windows.Forms.Button completeCaptha;
    }
}

