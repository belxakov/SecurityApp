
namespace Security
{
    partial class Contracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contracts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goMenu = new System.Windows.Forms.Button();
            this.labNameObj = new System.Windows.Forms.Label();
            this.labTypeObj = new System.Windows.Forms.Label();
            this.boxTypeObj = new System.Windows.Forms.ComboBox();
            this.labSort = new System.Windows.Forms.Label();
            this.boxSort = new System.Windows.Forms.ComboBox();
            this.imageFilter = new System.Windows.Forms.PictureBox();
            this.imageNoFilter = new System.Windows.Forms.PictureBox();
            this.boxTypeSec = new System.Windows.Forms.ComboBox();
            this.labTypeSec = new System.Windows.Forms.Label();
            this.boxClient = new System.Windows.Forms.ComboBox();
            this.labClient = new System.Windows.Forms.Label();
            this.boxNameObj = new System.Windows.Forms.TextBox();
            this.printContract = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNoFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(956, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // goMenu
            // 
            this.goMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.goMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goMenu.ForeColor = System.Drawing.Color.White;
            this.goMenu.Location = new System.Drawing.Point(661, 411);
            this.goMenu.Name = "goMenu";
            this.goMenu.Size = new System.Drawing.Size(311, 38);
            this.goMenu.TabIndex = 1;
            this.goMenu.Text = "Главное меню";
            this.goMenu.UseVisualStyleBackColor = false;
            this.goMenu.Click += new System.EventHandler(this.goMenu_Click);
            // 
            // labNameObj
            // 
            this.labNameObj.AutoSize = true;
            this.labNameObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNameObj.Location = new System.Drawing.Point(55, 14);
            this.labNameObj.Name = "labNameObj";
            this.labNameObj.Size = new System.Drawing.Size(170, 15);
            this.labNameObj.TabIndex = 3;
            this.labNameObj.Text = "Наименование объекта:";
            // 
            // labTypeObj
            // 
            this.labTypeObj.AutoSize = true;
            this.labTypeObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTypeObj.Location = new System.Drawing.Point(355, 14);
            this.labTypeObj.Name = "labTypeObj";
            this.labTypeObj.Size = new System.Drawing.Size(94, 15);
            this.labTypeObj.TabIndex = 4;
            this.labTypeObj.Text = "Тип объекта:";
            // 
            // boxTypeObj
            // 
            this.boxTypeObj.FormattingEnabled = true;
            this.boxTypeObj.Location = new System.Drawing.Point(455, 12);
            this.boxTypeObj.Name = "boxTypeObj";
            this.boxTypeObj.Size = new System.Drawing.Size(173, 21);
            this.boxTypeObj.TabIndex = 5;
            this.boxTypeObj.SelectedIndexChanged += new System.EventHandler(this.boxTypeObj_SelectedIndexChanged);
            // 
            // labSort
            // 
            this.labSort.AutoSize = true;
            this.labSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSort.Location = new System.Drawing.Point(634, 14);
            this.labSort.Name = "labSort";
            this.labSort.Size = new System.Drawing.Size(120, 15);
            this.labSort.TabIndex = 6;
            this.labSort.Text = "Сортировать по:";
            // 
            // boxSort
            // 
            this.boxSort.FormattingEnabled = true;
            this.boxSort.Location = new System.Drawing.Point(760, 12);
            this.boxSort.Name = "boxSort";
            this.boxSort.Size = new System.Drawing.Size(116, 21);
            this.boxSort.TabIndex = 7;
            this.boxSort.SelectedIndexChanged += new System.EventHandler(this.boxSort_SelectedIndexChanged);
            // 
            // imageFilter
            // 
            this.imageFilter.Image = ((System.Drawing.Image)(resources.GetObject("imageFilter.Image")));
            this.imageFilter.Location = new System.Drawing.Point(916, 1);
            this.imageFilter.Name = "imageFilter";
            this.imageFilter.Size = new System.Drawing.Size(32, 32);
            this.imageFilter.TabIndex = 8;
            this.imageFilter.TabStop = false;
            this.imageFilter.Click += new System.EventHandler(this.imageFilter_Click);
            // 
            // imageNoFilter
            // 
            this.imageNoFilter.Image = ((System.Drawing.Image)(resources.GetObject("imageNoFilter.Image")));
            this.imageNoFilter.Location = new System.Drawing.Point(916, 1);
            this.imageNoFilter.Name = "imageNoFilter";
            this.imageNoFilter.Size = new System.Drawing.Size(32, 32);
            this.imageNoFilter.TabIndex = 9;
            this.imageNoFilter.TabStop = false;
            this.imageNoFilter.Click += new System.EventHandler(this.imageNoFilter_Click);
            // 
            // boxTypeSec
            // 
            this.boxTypeSec.FormattingEnabled = true;
            this.boxTypeSec.Items.AddRange(new object[] {
            "Выбрать все",
            "Круглосуточная охрана",
            "По вызову"});
            this.boxTypeSec.Location = new System.Drawing.Point(573, 43);
            this.boxTypeSec.Name = "boxTypeSec";
            this.boxTypeSec.Size = new System.Drawing.Size(165, 21);
            this.boxTypeSec.TabIndex = 13;
            this.boxTypeSec.SelectedIndexChanged += new System.EventHandler(this.boxTypeSec_SelectedIndexChanged);
            // 
            // labTypeSec
            // 
            this.labTypeSec.AutoSize = true;
            this.labTypeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTypeSec.Location = new System.Drawing.Point(479, 45);
            this.labTypeSec.Name = "labTypeSec";
            this.labTypeSec.Size = new System.Drawing.Size(88, 15);
            this.labTypeSec.TabIndex = 12;
            this.labTypeSec.Text = "Тип охраны:";
            // 
            // boxClient
            // 
            this.boxClient.FormattingEnabled = true;
            this.boxClient.Location = new System.Drawing.Point(300, 43);
            this.boxClient.Name = "boxClient";
            this.boxClient.Size = new System.Drawing.Size(173, 21);
            this.boxClient.TabIndex = 11;
            this.boxClient.SelectedIndexChanged += new System.EventHandler(this.boxClient_SelectedIndexChanged);
            // 
            // labClient
            // 
            this.labClient.AutoSize = true;
            this.labClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labClient.Location = new System.Drawing.Point(234, 45);
            this.labClient.Name = "labClient";
            this.labClient.Size = new System.Drawing.Size(60, 15);
            this.labClient.TabIndex = 10;
            this.labClient.Text = "Клиент:";
            // 
            // boxNameObj
            // 
            this.boxNameObj.Location = new System.Drawing.Point(231, 12);
            this.boxNameObj.Name = "boxNameObj";
            this.boxNameObj.Size = new System.Drawing.Size(117, 20);
            this.boxNameObj.TabIndex = 14;
            this.boxNameObj.TextChanged += new System.EventHandler(this.boxNameObj_TextChanged);
            // 
            // printContract
            // 
            this.printContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.printContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printContract.ForeColor = System.Drawing.Color.White;
            this.printContract.Location = new System.Drawing.Point(464, 411);
            this.printContract.Name = "printContract";
            this.printContract.Size = new System.Drawing.Size(191, 38);
            this.printContract.TabIndex = 15;
            this.printContract.Text = "Распечатать договор";
            this.printContract.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(267, 411);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(191, 38);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.printContract);
            this.Controls.Add(this.boxNameObj);
            this.Controls.Add(this.boxTypeSec);
            this.Controls.Add(this.labTypeSec);
            this.Controls.Add(this.boxClient);
            this.Controls.Add(this.labClient);
            this.Controls.Add(this.imageNoFilter);
            this.Controls.Add(this.imageFilter);
            this.Controls.Add(this.boxSort);
            this.Controls.Add(this.labSort);
            this.Controls.Add(this.boxTypeObj);
            this.Controls.Add(this.labTypeObj);
            this.Controls.Add(this.labNameObj);
            this.Controls.Add(this.goMenu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр договоров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNoFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button goMenu;
        private System.Windows.Forms.Label labNameObj;
        private System.Windows.Forms.Label labTypeObj;
        private System.Windows.Forms.ComboBox boxTypeObj;
        private System.Windows.Forms.Label labSort;
        private System.Windows.Forms.ComboBox boxSort;
        private System.Windows.Forms.PictureBox imageFilter;
        private System.Windows.Forms.PictureBox imageNoFilter;
        private System.Windows.Forms.ComboBox boxTypeSec;
        private System.Windows.Forms.Label labTypeSec;
        private System.Windows.Forms.ComboBox boxClient;
        private System.Windows.Forms.Label labClient;
        private System.Windows.Forms.TextBox boxNameObj;
        private System.Windows.Forms.Button printContract;
        private System.Windows.Forms.Button buttonEdit;
    }
}