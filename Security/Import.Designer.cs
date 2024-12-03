
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
            this.importData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.boxTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // importData
            // 
            this.importData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.importData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importData.ForeColor = System.Drawing.Color.White;
            this.importData.Location = new System.Drawing.Point(12, 55);
            this.importData.Name = "importData";
            this.importData.Size = new System.Drawing.Size(360, 50);
            this.importData.TabIndex = 1;
            this.importData.Text = "Импорт данных";
            this.importData.UseVisualStyleBackColor = false;
            this.importData.Click += new System.EventHandler(this.importData_Click);
            // 
            // saveData
            // 
            this.saveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.saveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveData.ForeColor = System.Drawing.Color.White;
            this.saveData.Location = new System.Drawing.Point(12, 137);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(360, 50);
            this.saveData.TabIndex = 3;
            this.saveData.Text = "Выход";
            this.saveData.UseVisualStyleBackColor = false;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // boxTable
            // 
            this.boxTable.FormattingEnabled = true;
            this.boxTable.Location = new System.Drawing.Point(12, 28);
            this.boxTable.Name = "boxTable";
            this.boxTable.Size = new System.Drawing.Size(360, 21);
            this.boxTable.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите таблицу:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.AutoSize = true;
            this.txtFilePath.Location = new System.Drawing.Point(12, 174);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(0, 13);
            this.txtFilePath.TabIndex = 4;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxTable);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.importData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importData;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.ComboBox boxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtFilePath;
    }
}