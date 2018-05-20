namespace FUTBUL
{
    partial class UyeOl
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtmaskTel = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYetkiTuru = new System.Windows.Forms.ComboBox();
            this.futbolDataSet = new FUTBUL.FutbolDataSet();
            this.futbolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yetkilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yetkilerTableAdapter = new FUTBUL.FutbolDataSetTableAdapters.YetkilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 117);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(119, 144);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtmaskTel
            // 
            this.txtmaskTel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtmaskTel.Location = new System.Drawing.Point(119, 170);
            this.txtmaskTel.Mask = "0000000000";
            this.txtmaskTel.Name = "txtmaskTel";
            this.txtmaskTel.Size = new System.Drawing.Size(100, 20);
            this.txtmaskTel.TabIndex = 2;
            this.txtmaskTel.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon Numarası";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre";
            // 
            // cmbYetkiTuru
            // 
            this.cmbYetkiTuru.DataSource = this.yetkilerBindingSource;
            this.cmbYetkiTuru.DisplayMember = "YetkiTuru";
            this.cmbYetkiTuru.FormattingEnabled = true;
            this.cmbYetkiTuru.Location = new System.Drawing.Point(119, 208);
            this.cmbYetkiTuru.Name = "cmbYetkiTuru";
            this.cmbYetkiTuru.Size = new System.Drawing.Size(100, 21);
            this.cmbYetkiTuru.TabIndex = 11;
            this.cmbYetkiTuru.ValueMember = "YetkiKodu";
            this.cmbYetkiTuru.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // futbolDataSet
            // 
            this.futbolDataSet.DataSetName = "FutbolDataSet";
            this.futbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // futbolDataSetBindingSource
            // 
            this.futbolDataSetBindingSource.DataSource = this.futbolDataSet;
            this.futbolDataSetBindingSource.Position = 0;
            // 
            // yetkilerBindingSource
            // 
            this.yetkilerBindingSource.DataMember = "Yetkiler";
            this.yetkilerBindingSource.DataSource = this.futbolDataSetBindingSource;
            // 
            // yetkilerTableAdapter
            // 
            this.yetkilerTableAdapter.ClearBeforeFill = true;
            // 
            // UyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 346);
            this.Controls.Add(this.cmbYetkiTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaskTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "UyeOl";
            this.Text = "UyeOl";
            this.Load += new System.EventHandler(this.UyeOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox txtmaskTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYetkiTuru;
        private System.Windows.Forms.BindingSource futbolDataSetBindingSource;
        private FutbolDataSet futbolDataSet;
        private System.Windows.Forms.BindingSource yetkilerBindingSource;
        private FutbolDataSetTableAdapters.YetkilerTableAdapter yetkilerTableAdapter;
    }
}