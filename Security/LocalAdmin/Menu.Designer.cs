
namespace Security.LocalAdmin
{
    partial class Menu
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
            this.backupDataButton = new System.Windows.Forms.Button();
            this.dataImportButton = new System.Windows.Forms.Button();
            this.showContractButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupDataButton
            // 
            this.backupDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.backupDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupDataButton.ForeColor = System.Drawing.Color.White;
            this.backupDataButton.Location = new System.Drawing.Point(13, 13);
            this.backupDataButton.Name = "backupDataButton";
            this.backupDataButton.Size = new System.Drawing.Size(164, 45);
            this.backupDataButton.TabIndex = 0;
            this.backupDataButton.Text = "Восстановить структуру базы данных";
            this.backupDataButton.UseVisualStyleBackColor = false;
            // 
            // dataImportButton
            // 
            this.dataImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.dataImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataImportButton.ForeColor = System.Drawing.Color.White;
            this.dataImportButton.Location = new System.Drawing.Point(13, 75);
            this.dataImportButton.Name = "dataImportButton";
            this.dataImportButton.Size = new System.Drawing.Size(164, 45);
            this.dataImportButton.TabIndex = 1;
            this.dataImportButton.Text = "Импорт данных";
            this.dataImportButton.UseVisualStyleBackColor = false;
            // 
            // showContractButton
            // 
            this.showContractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.showContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showContractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showContractButton.ForeColor = System.Drawing.Color.White;
            this.showContractButton.Location = new System.Drawing.Point(13, 138);
            this.showContractButton.Name = "showContractButton";
            this.showContractButton.Size = new System.Drawing.Size(164, 45);
            this.showContractButton.TabIndex = 2;
            this.showContractButton.Text = "Просмотр договоров";
            this.showContractButton.UseVisualStyleBackColor = false;
            this.showContractButton.Click += new System.EventHandler(this.showContractButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(13, 205);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(164, 45);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // closeAppButton
            // 
            this.closeAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Location = new System.Drawing.Point(13, 271);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(164, 45);
            this.closeAppButton.TabIndex = 4;
            this.closeAppButton.Text = "Выход";
            this.closeAppButton.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeAppButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.showContractButton);
            this.Controls.Add(this.dataImportButton);
            this.Controls.Add(this.backupDataButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backupDataButton;
        private System.Windows.Forms.Button dataImportButton;
        private System.Windows.Forms.Button showContractButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button closeAppButton;
    }
}