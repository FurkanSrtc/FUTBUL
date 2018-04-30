namespace FUTBUL
{
    partial class TakimaKatil
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.uyelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.futbolDataSet = new FUTBUL.FutbolDataSet();
            this.oyuncularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oyuncularTableAdapter = new FUTBUL.FutbolDataSetTableAdapters.OyuncularTableAdapter();
            this.uyelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uyelerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uyelerTableAdapter = new FUTBUL.FutbolDataSetTableAdapters.UyelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adın:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Takımını Seç:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Başvur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Forma Numarası:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 100);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // uyelerBindingSource
            // 
            this.uyelerBindingSource.DataMember = "Uyeler";
            this.uyelerBindingSource.DataSource = this.futbolDataSet;
            // 
            // futbolDataSet
            // 
            this.futbolDataSet.DataSetName = "FutbolDataSet";
            this.futbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oyuncularBindingSource
            // 
            this.oyuncularBindingSource.DataMember = "Oyuncular";
            this.oyuncularBindingSource.DataSource = this.futbolDataSet;
            // 
            // oyuncularTableAdapter
            // 
            this.oyuncularTableAdapter.ClearBeforeFill = true;
            // 
            // uyelerBindingSource1
            // 
            this.uyelerBindingSource1.DataMember = "Uyeler";
            this.uyelerBindingSource1.DataSource = this.futbolDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.uyelerBindingSource2;
            this.comboBox1.DisplayMember = "KullaniciAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "KullaniciAdi";
            // 
            // uyelerBindingSource2
            // 
            this.uyelerBindingSource2.DataMember = "Uyeler";
            this.uyelerBindingSource2.DataSource = this.futbolDataSet;
            // 
            // uyelerTableAdapter
            // 
            this.uyelerTableAdapter.ClearBeforeFill = true;
            // 
            // TakimaKatil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 352);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "TakimaKatil";
            this.Text = "TakimaKatil";
            this.Load += new System.EventHandler(this.TakimaKatil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private FutbolDataSet futbolDataSet;
        private System.Windows.Forms.BindingSource oyuncularBindingSource;
        private FutbolDataSetTableAdapters.OyuncularTableAdapter oyuncularTableAdapter;
        private System.Windows.Forms.BindingSource uyelerBindingSource;
        private System.Windows.Forms.BindingSource uyelerBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource uyelerBindingSource2;
        private FutbolDataSetTableAdapters.UyelerTableAdapter uyelerTableAdapter;
    }
}