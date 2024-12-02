
namespace Security
{
    partial class NewIncident
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
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.boxObject = new System.Windows.Forms.ComboBox();
            this.boxDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.regIncident = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxStatus
            // 
            this.boxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Items.AddRange(new object[] {
            "На исполнении",
            "Выполнен"});
            this.boxStatus.Location = new System.Drawing.Point(12, 107);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(260, 28);
            this.boxStatus.TabIndex = 21;
            // 
            // boxObject
            // 
            this.boxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxObject.FormattingEnabled = true;
            this.boxObject.Location = new System.Drawing.Point(12, 41);
            this.boxObject.Name = "boxObject";
            this.boxObject.Size = new System.Drawing.Size(260, 28);
            this.boxObject.TabIndex = 20;
            // 
            // boxDesc
            // 
            this.boxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxDesc.Location = new System.Drawing.Point(12, 174);
            this.boxDesc.Name = "boxDesc";
            this.boxDesc.Size = new System.Drawing.Size(260, 228);
            this.boxDesc.TabIndex = 19;
            this.boxDesc.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Объект:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Описание:";
            // 
            // goBack
            // 
            this.goBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack.ForeColor = System.Drawing.Color.White;
            this.goBack.Location = new System.Drawing.Point(12, 448);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(260, 34);
            this.goBack.TabIndex = 24;
            this.goBack.Text = "Назад";
            this.goBack.UseVisualStyleBackColor = false;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // regIncident
            // 
            this.regIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.regIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regIncident.ForeColor = System.Drawing.Color.White;
            this.regIncident.Location = new System.Drawing.Point(12, 408);
            this.regIncident.Name = "regIncident";
            this.regIncident.Size = new System.Drawing.Size(260, 34);
            this.regIncident.TabIndex = 23;
            this.regIncident.Text = "Зарегистрировать";
            this.regIncident.UseVisualStyleBackColor = false;
            this.regIncident.Click += new System.EventHandler(this.regIncident_Click);
            // 
            // NewIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(289, 491);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.regIncident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxStatus);
            this.Controls.Add(this.boxObject);
            this.Controls.Add(this.boxDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewIncident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация инцидента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.ComboBox boxObject;
        private System.Windows.Forms.RichTextBox boxDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button regIncident;
    }
}