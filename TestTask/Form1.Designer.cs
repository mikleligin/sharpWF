namespace TestTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangeFile = new System.Windows.Forms.Button();
            this.NameFile = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GetLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeFile
            // 
            this.ChangeFile.Location = new System.Drawing.Point(12, 12);
            this.ChangeFile.Name = "ChangeFile";
            this.ChangeFile.Size = new System.Drawing.Size(94, 29);
            this.ChangeFile.TabIndex = 0;
            this.ChangeFile.Text = "открыть";
            this.ChangeFile.UseVisualStyleBackColor = true;
            this.ChangeFile.Click += new System.EventHandler(this.ChangeFile_Click);
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Location = new System.Drawing.Point(738, 421);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(52, 20);
            this.NameFile.TabIndex = 1;
            this.NameFile.Text = "debug";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(748, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "выбор лога";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GetLog
            // 
            this.GetLog.Location = new System.Drawing.Point(648, 12);
            this.GetLog.Name = "GetLog";
            this.GetLog.Size = new System.Drawing.Size(94, 29);
            this.GetLog.TabIndex = 3;
            this.GetLog.Text = "выбрать";
            this.GetLog.UseVisualStyleBackColor = true;
            this.GetLog.Click += new System.EventHandler(this.GetLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 544);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Min,
            this.Max,
            this.Mat,
            this.Timee});
            this.dataGridView1.Location = new System.Drawing.Point(216, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(683, 544);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // Min
            // 
            this.Min.HeaderText = "Минимум";
            this.Min.MinimumWidth = 6;
            this.Min.Name = "Min";
            this.Min.Width = 125;
            // 
            // Max
            // 
            this.Max.HeaderText = "Максимум";
            this.Max.MinimumWidth = 6;
            this.Max.Name = "Max";
            this.Max.Width = 125;
            // 
            // Mat
            // 
            this.Mat.HeaderText = "Мат. Ожид.";
            this.Mat.MinimumWidth = 6;
            this.Mat.Name = "Mat";
            this.Mat.Width = 125;
            // 
            // Timee
            // 
            this.Timee.HeaderText = "Длительность";
            this.Timee.MinimumWidth = 6;
            this.Timee.Name = "Timee";
            this.Timee.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "ru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetLog);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.ChangeFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChangeFile;
        private Label NameFile;
        private ComboBox comboBox1;
        private Button GetLog;
        private Label label1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn Mat;
        private DataGridViewTextBoxColumn Timee;
        private Button button1;
    }
}