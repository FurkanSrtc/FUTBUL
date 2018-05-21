namespace FUTBUL
{
    partial class SahaEkle
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
            this.txtSahaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.futbolDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.futbolDataSet = new FUTBUL.FutbolDataSet();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSaha = new System.Windows.Forms.ComboBox();
            this.sahaTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sahaTuruTableAdapter = new FUTBUL.FutbolDataSetTableAdapters.SahaTuruTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahaTuruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSahaAdi
            // 
            this.txtSahaAdi.Location = new System.Drawing.Point(107, 74);
            this.txtSahaAdi.Name = "txtSahaAdi";
            this.txtSahaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtSahaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saha Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlçe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saha Türü";
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(107, 146);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 7;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(107, 188);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(121, 21);
            this.cmbilce.TabIndex = 8;
            // 
            // cmbUye
            // 
            this.cmbUye.FormattingEnabled = true;
            this.cmbUye.Location = new System.Drawing.Point(107, 37);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(121, 21);
            this.cmbUye.TabIndex = 9;
            this.cmbUye.ValueMember = "SahaId";
            // 
            // futbolDataSetBindingSource
            // 
            this.futbolDataSetBindingSource.DataSource = this.futbolDataSet;
            this.futbolDataSetBindingSource.Position = 0;
            // 
            // futbolDataSet
            // 
            this.futbolDataSet.DataSetName = "FutbolDataSet";
            this.futbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(107, 233);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(121, 96);
            this.txtAdres.TabIndex = 10;
            this.txtAdres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbSaha
            // 
            this.cmbSaha.DataSource = this.sahaTuruBindingSource;
            this.cmbSaha.DisplayMember = "SahaTuru";
            this.cmbSaha.FormattingEnabled = true;
            this.cmbSaha.Location = new System.Drawing.Point(107, 109);
            this.cmbSaha.Name = "cmbSaha";
            this.cmbSaha.Size = new System.Drawing.Size(121, 21);
            this.cmbSaha.TabIndex = 11;
            this.cmbSaha.ValueMember = "SahaId";
            // 
            // sahaTuruBindingSource
            // 
            this.sahaTuruBindingSource.DataMember = "SahaTuru";
            this.sahaTuruBindingSource.DataSource = this.futbolDataSetBindingSource;
            // 
            // sahaTuruTableAdapter
            // 
            this.sahaTuruTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Üye";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(107, 350);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 38);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // SahaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 419);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSaha);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cmbUye);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSahaAdi);
            this.Name = "SahaEkle";
            this.Text = "SahaEkle";
            this.Load += new System.EventHandler(this.SahaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahaTuruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSahaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.BindingSource futbolDataSetBindingSource;
        private FutbolDataSet futbolDataSet;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSaha;
        private System.Windows.Forms.BindingSource sahaTuruBindingSource;
        private FutbolDataSetTableAdapters.SahaTuruTableAdapter sahaTuruTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
    }
}