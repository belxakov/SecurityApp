
namespace Security
{
    partial class Import
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
            this.getFile = new System.Windows.Forms.Button();
            this.recoveryData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getFile
            // 
            this.getFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.getFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getFile.ForeColor = System.Drawing.Color.White;
            this.getFile.Location = new System.Drawing.Point(12, 12);
            this.getFile.Name = "getFile";
            this.getFile.Size = new System.Drawing.Size(360, 50);
            this.getFile.TabIndex = 1;
            this.getFile.Text = "Выбрать файл";
            this.getFile.UseVisualStyleBackColor = false;
            this.getFile.Click += new System.EventHandler(this.getFile_Click);
            // 
            // recoveryData
            // 
            this.recoveryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.recoveryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoveryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recoveryData.ForeColor = System.Drawing.Color.White;
            this.recoveryData.Location = new System.Drawing.Point(12, 68);
            this.recoveryData.Name = "recoveryData";
            this.recoveryData.Size = new System.Drawing.Size(360, 50);
            this.recoveryData.TabIndex = 2;
            this.recoveryData.Text = "Восстановить данные";
            this.recoveryData.UseVisualStyleBackColor = false;
            // 
            // saveData
            // 
            this.saveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.saveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveData.ForeColor = System.Drawing.Color.White;
            this.saveData.Location = new System.Drawing.Point(12, 199);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(360, 50);
            this.saveData.TabIndex = 3;
            this.saveData.Text = "Сохранить";
            this.saveData.UseVisualStyleBackColor = false;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.recoveryData);
            this.Controls.Add(this.getFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт данных";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getFile;
        private System.Windows.Forms.Button recoveryData;
        private System.Windows.Forms.Button saveData;
    }
}