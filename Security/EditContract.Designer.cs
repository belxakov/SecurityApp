
namespace Security
{
    partial class EditContract
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
            this.label7 = new System.Windows.Forms.Label();
            this.boxClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxTypeSecurity = new System.Windows.Forms.ComboBox();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.boxTypeObject = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxAdress = new System.Windows.Forms.TextBox();
            this.boxNameObj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Тип охраны:";
            // 
            // boxClient
            // 
            this.boxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxClient.FormattingEnabled = true;
            this.boxClient.Location = new System.Drawing.Point(13, 145);
            this.boxClient.Name = "boxClient";
            this.boxClient.Size = new System.Drawing.Size(218, 24);
            this.boxClient.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Клиент:";
            // 
            // boxTypeSecurity
            // 
            this.boxTypeSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxTypeSecurity.FormattingEnabled = true;
            this.boxTypeSecurity.Items.AddRange(new object[] {
            "Круглосуточная охрана",
            "По вызову"});
            this.boxTypeSecurity.Location = new System.Drawing.Point(13, 311);
            this.boxTypeSecurity.Name = "boxTypeSecurity";
            this.boxTypeSecurity.Size = new System.Drawing.Size(218, 24);
            this.boxTypeSecurity.TabIndex = 28;
            // 
            // boxStatus
            // 
            this.boxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.boxStatus.Location = new System.Drawing.Point(13, 257);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(218, 24);
            this.boxStatus.TabIndex = 27;
            // 
            // boxTypeObject
            // 
            this.boxTypeObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxTypeObject.FormattingEnabled = true;
            this.boxTypeObject.Location = new System.Drawing.Point(13, 204);
            this.boxTypeObject.Name = "boxTypeObject";
            this.boxTypeObject.Size = new System.Drawing.Size(218, 24);
            this.boxTypeObject.TabIndex = 26;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(13, 397);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(218, 36);
            this.closeButton.TabIndex = 25;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(13, 355);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(218, 36);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Сохранить";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Тип объекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Наименование объекта:";
            // 
            // boxAdress
            // 
            this.boxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxAdress.Location = new System.Drawing.Point(13, 92);
            this.boxAdress.Name = "boxAdress";
            this.boxAdress.Size = new System.Drawing.Size(218, 22);
            this.boxAdress.TabIndex = 19;
            // 
            // boxNameObj
            // 
            this.boxNameObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxNameObj.Location = new System.Drawing.Point(13, 38);
            this.boxNameObj.Name = "boxNameObj";
            this.boxNameObj.Size = new System.Drawing.Size(218, 22);
            this.boxNameObj.TabIndex = 18;
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 451);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxTypeSecurity);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxTypeObject);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxAdress);
            this.Controls.Add(this.boxNameObj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox boxClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox boxTypeSecurity;
        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.ComboBox boxTypeObject;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxAdress;
        private System.Windows.Forms.TextBox boxNameObj;
    }
}