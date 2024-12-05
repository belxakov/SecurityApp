
namespace Security
{
    partial class MainMenu
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
            this.conclusionContract = new System.Windows.Forms.Button();
            this.contractList = new System.Windows.Forms.Button();
            this.closeApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labSurname = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPatronymic = new System.Windows.Forms.Label();
            this.labIndCard = new System.Windows.Forms.Label();
            this.signalList = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.Button();
            this.importData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conclusionContract
            // 
            this.conclusionContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.conclusionContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conclusionContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionContract.ForeColor = System.Drawing.Color.White;
            this.conclusionContract.Location = new System.Drawing.Point(12, 16);
            this.conclusionContract.Name = "conclusionContract";
            this.conclusionContract.Size = new System.Drawing.Size(195, 47);
            this.conclusionContract.TabIndex = 0;
            this.conclusionContract.Text = "Заключить договор";
            this.conclusionContract.UseVisualStyleBackColor = false;
            this.conclusionContract.Click += new System.EventHandler(this.conclusionContract_Click);
            // 
            // contractList
            // 
            this.contractList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.contractList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractList.ForeColor = System.Drawing.Color.White;
            this.contractList.Location = new System.Drawing.Point(12, 69);
            this.contractList.Name = "contractList";
            this.contractList.Size = new System.Drawing.Size(195, 47);
            this.contractList.TabIndex = 1;
            this.contractList.Text = "Просмотр договоров";
            this.contractList.UseVisualStyleBackColor = false;
            this.contractList.Click += new System.EventHandler(this.contractList_Click);
            // 
            // closeApplication
            // 
            this.closeApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeApplication.ForeColor = System.Drawing.Color.White;
            this.closeApplication.Location = new System.Drawing.Point(12, 339);
            this.closeApplication.Name = "closeApplication";
            this.closeApplication.Size = new System.Drawing.Size(195, 38);
            this.closeApplication.TabIndex = 4;
            this.closeApplication.Text = "Выход";
            this.closeApplication.UseVisualStyleBackColor = false;
            this.closeApplication.Click += new System.EventHandler(this.closeApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(277, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Информация о пользователе";
            // 
            // labSurname
            // 
            this.labSurname.AutoSize = true;
            this.labSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSurname.ForeColor = System.Drawing.Color.Black;
            this.labSurname.Location = new System.Drawing.Point(279, 99);
            this.labSurname.Name = "labSurname";
            this.labSurname.Size = new System.Drawing.Size(96, 24);
            this.labSurname.TabIndex = 9;
            this.labSurname.Text = "Фамилия:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.ForeColor = System.Drawing.Color.Black;
            this.labName.Location = new System.Drawing.Point(279, 141);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(51, 24);
            this.labName.TabIndex = 10;
            this.labName.Text = "Имя:";
            // 
            // labPatronymic
            // 
            this.labPatronymic.AutoSize = true;
            this.labPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPatronymic.ForeColor = System.Drawing.Color.Black;
            this.labPatronymic.Location = new System.Drawing.Point(279, 180);
            this.labPatronymic.Name = "labPatronymic";
            this.labPatronymic.Size = new System.Drawing.Size(103, 24);
            this.labPatronymic.TabIndex = 11;
            this.labPatronymic.Text = "Отчество:";
            // 
            // labIndCard
            // 
            this.labIndCard.AutoSize = true;
            this.labIndCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labIndCard.ForeColor = System.Drawing.Color.Black;
            this.labIndCard.Location = new System.Drawing.Point(279, 251);
            this.labIndCard.Name = "labIndCard";
            this.labIndCard.Size = new System.Drawing.Size(261, 24);
            this.labIndCard.TabIndex = 12;
            this.labIndCard.Text = "Служебное удостоверение:";
            // 
            // signalList
            // 
            this.signalList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.signalList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signalList.ForeColor = System.Drawing.Color.White;
            this.signalList.Location = new System.Drawing.Point(12, 122);
            this.signalList.Name = "signalList";
            this.signalList.Size = new System.Drawing.Size(195, 47);
            this.signalList.TabIndex = 13;
            this.signalList.Text = "Просмотр вызовов";
            this.signalList.UseVisualStyleBackColor = false;
            this.signalList.Click += new System.EventHandler(this.signalList_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labStatus.ForeColor = System.Drawing.Color.Black;
            this.labStatus.Location = new System.Drawing.Point(279, 276);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(77, 24);
            this.labStatus.TabIndex = 14;
            this.labStatus.Text = "Статус:";
            // 
            // memberList
            // 
            this.memberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.memberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberList.ForeColor = System.Drawing.Color.White;
            this.memberList.Location = new System.Drawing.Point(12, 175);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(195, 47);
            this.memberList.TabIndex = 15;
            this.memberList.Text = "Список сотрудников";
            this.memberList.UseVisualStyleBackColor = false;
            this.memberList.Click += new System.EventHandler(this.memberList_Click);
            // 
            // clientList
            // 
            this.clientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.clientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientList.ForeColor = System.Drawing.Color.White;
            this.clientList.Location = new System.Drawing.Point(12, 228);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(195, 47);
            this.clientList.TabIndex = 16;
            this.clientList.Text = "Список клиентов";
            this.clientList.UseVisualStyleBackColor = false;
            this.clientList.Click += new System.EventHandler(this.clientList_Click);
            // 
            // importData
            // 
            this.importData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.importData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importData.ForeColor = System.Drawing.Color.White;
            this.importData.Location = new System.Drawing.Point(12, 281);
            this.importData.Name = "importData";
            this.importData.Size = new System.Drawing.Size(195, 47);
            this.importData.TabIndex = 18;
            this.importData.Text = "Импортировать данные";
            this.importData.UseVisualStyleBackColor = false;
            this.importData.Click += new System.EventHandler(this.importData_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(799, 391);
            this.Controls.Add(this.importData);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.signalList);
            this.Controls.Add(this.labIndCard);
            this.Controls.Add(this.labPatronymic);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeApplication);
            this.Controls.Add(this.contractList);
            this.Controls.Add(this.conclusionContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conclusionContract;
        private System.Windows.Forms.Button contractList;
        private System.Windows.Forms.Button closeApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSurname;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPatronymic;
        private System.Windows.Forms.Label labIndCard;
        private System.Windows.Forms.Button signalList;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Button memberList;
        private System.Windows.Forms.Button clientList;
        private System.Windows.Forms.Button importData;
    }
}