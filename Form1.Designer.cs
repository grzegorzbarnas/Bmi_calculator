namespace Bmi_kalkulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textWaga = new System.Windows.Forms.TextBox();
            this.textWzrost = new System.Windows.Forms.TextBox();
            this.bmiDataSet1 = new Bmi_kalkulator.bmiDataSet1();
            this.tabelabmiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabela_bmiTableAdapter1 = new Bmi_kalkulator.bmiDataSet1TableAdapters.tabela_bmiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.wiekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawidłoweBMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wiekTableAdapter = new Bmi_kalkulator.bmiDataSet1TableAdapters.wiekTableAdapter();
            this.Obliczanie = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.znaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bmi2DataSet = new Bmi_kalkulator.bmi2DataSet();
            this.tabelabmiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bmiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaTableAdapter = new Bmi_kalkulator.bmi2DataSetTableAdapters.TabelaTableAdapter();
            this.textWynik = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textWiek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bmiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelabmiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmi2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelabmiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(334, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(73, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wprowadź wage (KG):";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(73, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Podaj wzrost (CM):";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(73, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Twoje BMI to:";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textWaga
            // 
            this.textWaga.Location = new System.Drawing.Point(265, 146);
            this.textWaga.Multiline = true;
            this.textWaga.Name = "textWaga";
            this.textWaga.Size = new System.Drawing.Size(181, 22);
            this.textWaga.TabIndex = 8;
            this.textWaga.UseWaitCursor = true;
            this.textWaga.TextChanged += new System.EventHandler(this.textWaga_TextChanged);
            // 
            // textWzrost
            // 
            this.textWzrost.Location = new System.Drawing.Point(265, 194);
            this.textWzrost.Multiline = true;
            this.textWzrost.Name = "textWzrost";
            this.textWzrost.Size = new System.Drawing.Size(181, 22);
            this.textWzrost.TabIndex = 10;
            this.textWzrost.UseWaitCursor = true;
            this.textWzrost.TextChanged += new System.EventHandler(this.textWzrost_TextChanged);
            // 
            // bmiDataSet1
            // 
            this.bmiDataSet1.DataSetName = "bmiDataSet1";
            this.bmiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelabmiBindingSource1
            // 
            this.tabelabmiBindingSource1.DataMember = "tabela_bmi";
            this.tabelabmiBindingSource1.DataSource = this.bmiDataSet1;
            // 
            // tabela_bmiTableAdapter1
            // 
            this.tabela_bmiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wiekDataGridViewTextBoxColumn,
            this.prawidłoweBMIDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.wiekBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(510, 241);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(265, 150);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.UseWaitCursor = true;
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            this.wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            this.wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            this.wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            // 
            // prawidłoweBMIDataGridViewTextBoxColumn
            // 
            this.prawidłoweBMIDataGridViewTextBoxColumn.DataPropertyName = "Prawidłowe_BMI";
            this.prawidłoweBMIDataGridViewTextBoxColumn.HeaderText = "Prawidłowe_BMI";
            this.prawidłoweBMIDataGridViewTextBoxColumn.Name = "prawidłoweBMIDataGridViewTextBoxColumn";
            // 
            // wiekBindingSource
            // 
            this.wiekBindingSource.DataMember = "wiek";
            this.wiekBindingSource.DataSource = this.bmiDataSet1;
            // 
            // wiekTableAdapter
            // 
            this.wiekTableAdapter.ClearBeforeFill = true;
            // 
            // Obliczanie
            // 
            this.Obliczanie.BackColor = System.Drawing.Color.LawnGreen;
            this.Obliczanie.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Obliczanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Obliczanie.Location = new System.Drawing.Point(152, 298);
            this.Obliczanie.Name = "Obliczanie";
            this.Obliczanie.Size = new System.Drawing.Size(112, 49);
            this.Obliczanie.TabIndex = 0;
            this.Obliczanie.Text = "Oblicz";
            this.Obliczanie.UseVisualStyleBackColor = false;
            this.Obliczanie.UseWaitCursor = true;
            this.Obliczanie.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(702, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Wyjdź";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-3, 411);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znaczenieDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(510, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 143);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // znaczenieDataGridViewTextBoxColumn
            // 
            this.znaczenieDataGridViewTextBoxColumn.DataPropertyName = "Znaczenie";
            this.znaczenieDataGridViewTextBoxColumn.HeaderText = "Znaczenie";
            this.znaczenieDataGridViewTextBoxColumn.Name = "znaczenieDataGridViewTextBoxColumn";
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            // 
            // tabelaBindingSource
            // 
            this.tabelaBindingSource.DataMember = "Tabela";
            this.tabelaBindingSource.DataSource = this.bmi2DataSet;
            // 
            // bmi2DataSet
            // 
            this.bmi2DataSet.DataSetName = "bmi2DataSet";
            this.bmi2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelabmiBindingSource
            // 
            this.tabelabmiBindingSource.DataMember = "tabela_bmi";
            this.tabelabmiBindingSource.DataSource = this.bmiDataSet1;
            // 
            // bmiDataSet1BindingSource
            // 
            this.bmiDataSet1BindingSource.DataSource = this.bmiDataSet1;
            this.bmiDataSet1BindingSource.Position = 0;
            // 
            // tabelaTableAdapter
            // 
            this.tabelaTableAdapter.ClearBeforeFill = true;
            // 
            // textWynik
            // 
            this.textWynik.Location = new System.Drawing.Point(265, 241);
            this.textWynik.Multiline = true;
            this.textWynik.Name = "textWynik";
            this.textWynik.Size = new System.Drawing.Size(181, 22);
            this.textWynik.TabIndex = 16;
            this.textWynik.UseWaitCursor = true;
            this.textWynik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.UseWaitCursor = true;
            // 
            // textWiek
            // 
            this.textWiek.Location = new System.Drawing.Point(265, 100);
            this.textWiek.Multiline = true;
            this.textWiek.Name = "textWiek";
            this.textWiek.Size = new System.Drawing.Size(181, 22);
            this.textWiek.TabIndex = 18;
            this.textWiek.UseWaitCursor = true;
            this.textWiek.TextChanged += new System.EventHandler(this.textWiek_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(73, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ile masz lat?:";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(454, 45);
            this.label6.TabIndex = 22;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textWiek);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textWynik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textWzrost);
            this.Controls.Add(this.textWaga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Obliczanie);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelabmiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmi2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelabmiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWaga;
        private System.Windows.Forms.TextBox textWzrost;
        private bmiDataSet1 bmiDataSet1;
        private System.Windows.Forms.BindingSource tabelabmiBindingSource1;
        private bmiDataSet1TableAdapters.tabela_bmiTableAdapter tabela_bmiTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource wiekBindingSource;
        private bmiDataSet1TableAdapters.wiekTableAdapter wiekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawidłoweBMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Obliczanie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tabelabmiBindingSource;
        private System.Windows.Forms.BindingSource bmiDataSet1BindingSource;
        private bmi2DataSet bmi2DataSet;
        private System.Windows.Forms.BindingSource tabelaBindingSource;
        private bmi2DataSetTableAdapters.TabelaTableAdapter tabelaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn znaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textWynik;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textWiek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

