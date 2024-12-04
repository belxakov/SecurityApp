
namespace Security
{
    partial class LoadBackup
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
            this.backupData = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupData
            // 
            this.backupData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.backupData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupData.ForeColor = System.Drawing.Color.White;
            this.backupData.Location = new System.Drawing.Point(12, 26);
            this.backupData.Name = "backupData";
            this.backupData.Size = new System.Drawing.Size(360, 50);
            this.backupData.TabIndex = 3;
            this.backupData.Text = "Восстановление базы данных";
            this.backupData.UseVisualStyleBackColor = false;
            this.backupData.Click += new System.EventHandler(this.backupData_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(12, 82);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(360, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoadBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 167);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.backupData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadBackup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backupData;
        private System.Windows.Forms.Button closeButton;
    }
}