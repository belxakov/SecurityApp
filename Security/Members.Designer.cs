
namespace Security
{
    partial class Members
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labTittle = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.boxSurname = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.boxPatronymic = new System.Windows.Forms.TextBox();
            this.labPatronymic = new System.Windows.Forms.Label();
            this.labPost = new System.Windows.Forms.Label();
            this.labIndCard = new System.Windows.Forms.Label();
            this.labRole = new System.Windows.Forms.Label();
            this.newMember = new System.Windows.Forms.Button();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.generateLogin = new System.Windows.Forms.Button();
            this.generatePassword = new System.Windows.Forms.Button();
            this.boxRole = new System.Windows.Forms.ComboBox();
            this.boxPost = new System.Windows.Forms.ComboBox();
            this.boxIndCard = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // goMenu
            // 
            this.goMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.goMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goMenu.ForeColor = System.Drawing.Color.White;
            this.goMenu.Location = new System.Drawing.Point(471, 400);
            this.goMenu.Name = "goMenu";
            this.goMenu.Size = new System.Drawing.Size(317, 38);
            this.goMenu.TabIndex = 6;
            this.goMenu.Text = "Главное меню";
            this.goMenu.UseVisualStyleBackColor = false;
            this.goMenu.Click += new System.EventHandler(this.goMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 25, 5, 25);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(775, 382);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(775, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 237);
            this.dataGridView1.TabIndex = 5;
            // 
            // labTittle
            // 
            this.labTittle.AutoSize = true;
            this.labTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTittle.ForeColor = System.Drawing.Color.Black;
            this.labTittle.Location = new System.Drawing.Point(13, 256);
            this.labTittle.Name = "labTittle";
            this.labTittle.Size = new System.Drawing.Size(264, 16);
            this.labTittle.TabIndex = 7;
            this.labTittle.Text = "Добавление нового пользователя";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSurname.ForeColor = System.Drawing.Color.Black;
            this.labSurname.Location = new System.Drawing.Point(13, 287);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(78, 16);
            this.labSurname.TabIndex = 8;
            this.labSurname.Text = "Фамилия:";
            // 
            // boxSurname
            // 
            this.boxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxSurname.Location = new System.Drawing.Point(16, 307);
            this.boxSurname.Name = "boxSurname";
            this.boxSurname.Size = new System.Drawing.Size(194, 22);
            this.boxSurname.TabIndex = 9;
            this.boxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxSurname_KeyPress);
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxName.Location = new System.Drawing.Point(16, 356);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(194, 22);
            this.boxName.TabIndex = 11;
            this.boxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxName_KeyPress);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.ForeColor = System.Drawing.Color.Black;
            this.labName.Location = new System.Drawing.Point(13, 336);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(41, 16);
            this.labName.TabIndex = 10;
            this.labName.Text = "Имя:";
            // 
            // boxPatronymic
            // 
            this.boxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPatronymic.Location = new System.Drawing.Point(16, 409);
            this.boxPatronymic.Name = "boxPatronymic";
            this.boxPatronymic.Size = new System.Drawing.Size(194, 22);
            this.boxPatronymic.TabIndex = 13;
            this.boxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPatronymic_KeyPress);
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPatronymic.ForeColor = System.Drawing.Color.Black;
            this.labPatronymic.Location = new System.Drawing.Point(13, 389);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(83, 16);
            this.labPatronymic.TabIndex = 12;
            this.labPatronymic.Text = "Отчество:";
            // 
            // labPost
            // 
            this.labPost.AutoSize = true;
            this.labPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPost.ForeColor = System.Drawing.Color.Black;
            this.labPost.Location = new System.Drawing.Point(236, 287);
            this.labPost.Name = "labPost";
            this.labPost.Size = new System.Drawing.Size(92, 16);
            this.labPost.TabIndex = 14;
            this.labPost.Text = "Должность:";
            // 
            // labIndCard
            // 
            this.labIndCard.AutoSize = true;
            this.labIndCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labIndCard.ForeColor = System.Drawing.Color.Black;
            this.labIndCard.Location = new System.Drawing.Point(236, 337);
            this.labIndCard.Name = "labIndCard";
            this.labIndCard.Size = new System.Drawing.Size(156, 16);
            this.labIndCard.TabIndex = 16;
            this.labIndCard.Text = "С/Н удостоверения:";
            // 
            // labRole
            // 
            this.labRole.AutoSize = true;
            this.labRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRole.ForeColor = System.Drawing.Color.Black;
            this.labRole.Location = new System.Drawing.Point(236, 390);
            this.labRole.Name = "labRole";
            this.labRole.Size = new System.Drawing.Size(48, 16);
            this.labRole.TabIndex = 18;
            this.labRole.Text = "Роль:";
            // 
            // newMember
            // 
            this.newMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.newMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newMember.ForeColor = System.Drawing.Color.White;
            this.newMember.Location = new System.Drawing.Point(471, 356);
            this.newMember.Name = "newMember";
            this.newMember.Size = new System.Drawing.Size(317, 38);
            this.newMember.TabIndex = 20;
            this.newMember.Text = "Добавить";
            this.newMember.UseVisualStyleBackColor = false;
            this.newMember.Click += new System.EventHandler(this.newMember_Click);
            // 
            // boxPassword
            // 
            this.boxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPassword.Location = new System.Drawing.Point(471, 328);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(194, 22);
            this.boxPassword.TabIndex = 24;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPassword.ForeColor = System.Drawing.Color.Black;
            this.labPassword.Location = new System.Drawing.Point(468, 309);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(67, 16);
            this.labPassword.TabIndex = 23;
            this.labPassword.Text = "Пароль:";
            // 
            // boxLogin
            // 
            this.boxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxLogin.Location = new System.Drawing.Point(471, 278);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(194, 22);
            this.boxLogin.TabIndex = 22;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLogin.ForeColor = System.Drawing.Color.Black;
            this.labLogin.Location = new System.Drawing.Point(468, 259);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(56, 16);
            this.labLogin.TabIndex = 21;
            this.labLogin.Text = "Логин:";
            // 
            // generateLogin
            // 
            this.generateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.generateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateLogin.ForeColor = System.Drawing.Color.White;
            this.generateLogin.Location = new System.Drawing.Point(672, 278);
            this.generateLogin.Name = "generateLogin";
            this.generateLogin.Size = new System.Drawing.Size(116, 23);
            this.generateLogin.TabIndex = 25;
            this.generateLogin.Text = "Сгенерировать";
            this.generateLogin.UseVisualStyleBackColor = false;
            this.generateLogin.Click += new System.EventHandler(this.generateLogin_Click);
            // 
            // generatePassword
            // 
            this.generatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.generatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePassword.ForeColor = System.Drawing.Color.White;
            this.generatePassword.Location = new System.Drawing.Point(672, 327);
            this.generatePassword.Name = "generatePassword";
            this.generatePassword.Size = new System.Drawing.Size(116, 23);
            this.generatePassword.TabIndex = 26;
            this.generatePassword.Text = "Сгенерировать";
            this.generatePassword.UseVisualStyleBackColor = false;
            this.generatePassword.Click += new System.EventHandler(this.generatePassword_Click);
            // 
            // boxRole
            // 
            this.boxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxRole.FormattingEnabled = true;
            this.boxRole.Location = new System.Drawing.Point(239, 409);
            this.boxRole.Name = "boxRole";
            this.boxRole.Size = new System.Drawing.Size(194, 21);
            this.boxRole.TabIndex = 27;
            this.boxRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxRole_KeyPress);
            // 
            // boxPost
            // 
            this.boxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPost.FormattingEnabled = true;
            this.boxPost.Items.AddRange(new object[] {
            "Младший лейтенант",
            "Лейтенант",
            "Старший лейтенант",
            "Капитан",
            "Майор",
            "Подполковник",
            "Полковник"});
            this.boxPost.Location = new System.Drawing.Point(239, 308);
            this.boxPost.Name = "boxPost";
            this.boxPost.Size = new System.Drawing.Size(194, 21);
            this.boxPost.TabIndex = 28;
            this.boxPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPost_KeyPress);
            // 
            // boxIndCard
            // 
            this.boxIndCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxIndCard.Location = new System.Drawing.Point(239, 357);
            this.boxIndCard.Mask = "00 000000";
            this.boxIndCard.Name = "boxIndCard";
            this.boxIndCard.Size = new System.Drawing.Size(194, 22);
            this.boxIndCard.TabIndex = 29;
            this.boxIndCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIndCard_KeyPress);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxIndCard);
            this.Controls.Add(this.boxPost);
            this.Controls.Add(this.boxRole);
            this.Controls.Add(this.generatePassword);
            this.Controls.Add(this.generateLogin);
            this.Controls.Add(this.boxPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.boxLogin);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.newMember);
            this.Controls.Add(this.labRole);
            this.Controls.Add(this.labIndCard);
            this.Controls.Add(this.labPost);
            this.Controls.Add(this.boxPatronymic);
            this.Controls.Add(this.labPatronymic);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.boxSurname);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.labTittle);
            this.Controls.Add(this.goMenu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labTittle;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.TextBox boxSurname;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox boxPatronymic;
        private System.Windows.Forms.Label labPatronymic;
        private System.Windows.Forms.Label labPost;
        private System.Windows.Forms.Label labIndCard;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.Button newMember;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Button generateLogin;
        private System.Windows.Forms.Button generatePassword;
        private System.Windows.Forms.ComboBox boxRole;
        private System.Windows.Forms.ComboBox boxPost;
        private System.Windows.Forms.MaskedTextBox boxIndCard;
    }
}