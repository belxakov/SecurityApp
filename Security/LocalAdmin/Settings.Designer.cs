
namespace Security.LocalAdmin
{
    partial class Settings
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
            this.boxSettingsInactive = new System.Windows.Forms.TextBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxSettingsInactive
            // 
            this.boxSettingsInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxSettingsInactive.Location = new System.Drawing.Point(12, 33);
            this.boxSettingsInactive.Name = "boxSettingsInactive";
            this.boxSettingsInactive.Size = new System.Drawing.Size(360, 26);
            this.boxSettingsInactive.TabIndex = 0;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSettings.Location = new System.Drawing.Point(12, 90);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(360, 45);
            this.buttonSaveSettings.TabIndex = 1;
            this.buttonSaveSettings.Text = "Сохранить настройки";
            this.buttonSaveSettings.UseVisualStyleBackColor = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество секунд:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.boxSettingsInactive);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxSettingsInactive;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label1;
    }
}