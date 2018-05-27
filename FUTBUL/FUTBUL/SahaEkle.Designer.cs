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
            this.chkPazartesi = new System.Windows.Forms.CheckBox();
            this.chkSali = new System.Windows.Forms.CheckBox();
            this.chkCarsamba = new System.Windows.Forms.CheckBox();
            this.chkPersembe = new System.Windows.Forms.CheckBox();
            this.chkCuma = new System.Windows.Forms.CheckBox();
            this.chkCumartesi = new System.Windows.Forms.CheckBox();
            this.chkPazar = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BitPazar = new System.Windows.Forms.DateTimePicker();
            this.BitCumartesi = new System.Windows.Forms.DateTimePicker();
            this.BitCuma = new System.Windows.Forms.DateTimePicker();
            this.BitPerşembe = new System.Windows.Forms.DateTimePicker();
            this.BitÇarşamba = new System.Windows.Forms.DateTimePicker();
            this.BitSalı = new System.Windows.Forms.DateTimePicker();
            this.BitPazartesi = new System.Windows.Forms.DateTimePicker();
            this.basPazar = new System.Windows.Forms.DateTimePicker();
            this.basCumartesi = new System.Windows.Forms.DateTimePicker();
            this.basCuma = new System.Windows.Forms.DateTimePicker();
            this.BasPerşembe = new System.Windows.Forms.DateTimePicker();
            this.BasÇarşamba = new System.Windows.Forms.DateTimePicker();
            this.BasSalı = new System.Windows.Forms.DateTimePicker();
            this.BasPazartesi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahaTuruBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSahaAdi
            // 
            this.txtSahaAdi.Location = new System.Drawing.Point(81, 89);
            this.txtSahaAdi.Name = "txtSahaAdi";
            this.txtSahaAdi.Size = new System.Drawing.Size(121, 20);
            this.txtSahaAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saha Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saha Türü";
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(81, 162);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 7;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(81, 199);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(121, 21);
            this.cmbilce.TabIndex = 8;
            // 
            // cmbUye
            // 
            this.cmbUye.DisplayMember = "SahaId";
            this.cmbUye.FormattingEnabled = true;
            this.cmbUye.Location = new System.Drawing.Point(81, 52);
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
            this.txtAdres.Location = new System.Drawing.Point(81, 272);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(121, 96);
            this.txtAdres.TabIndex = 10;
            this.txtAdres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            // 
            // cmbSaha
            // 
            this.cmbSaha.DataSource = this.sahaTuruBindingSource;
            this.cmbSaha.DisplayMember = "SahaTuru";
            this.cmbSaha.FormattingEnabled = true;
            this.cmbSaha.Location = new System.Drawing.Point(81, 125);
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
            this.label6.Location = new System.Drawing.Point(51, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Üye";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(81, 384);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(639, 38);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkPazartesi
            // 
            this.chkPazartesi.AutoSize = true;
            this.chkPazartesi.Location = new System.Drawing.Point(15, 32);
            this.chkPazartesi.Name = "chkPazartesi";
            this.chkPazartesi.Size = new System.Drawing.Size(69, 17);
            this.chkPazartesi.TabIndex = 14;
            this.chkPazartesi.Text = "Pazartesi";
            this.chkPazartesi.UseVisualStyleBackColor = true;
            this.chkPazartesi.CheckedChanged += new System.EventHandler(this.chkPazartesi_CheckedChanged);
            // 
            // chkSali
            // 
            this.chkSali.AutoSize = true;
            this.chkSali.Location = new System.Drawing.Point(15, 76);
            this.chkSali.Name = "chkSali";
            this.chkSali.Size = new System.Drawing.Size(43, 17);
            this.chkSali.TabIndex = 15;
            this.chkSali.Text = "Salı";
            this.chkSali.UseVisualStyleBackColor = true;
            this.chkSali.CheckedChanged += new System.EventHandler(this.chkSali_CheckedChanged);
            // 
            // chkCarsamba
            // 
            this.chkCarsamba.AutoSize = true;
            this.chkCarsamba.Location = new System.Drawing.Point(15, 120);
            this.chkCarsamba.Name = "chkCarsamba";
            this.chkCarsamba.Size = new System.Drawing.Size(73, 17);
            this.chkCarsamba.TabIndex = 16;
            this.chkCarsamba.Text = "Çarşamba";
            this.chkCarsamba.UseVisualStyleBackColor = true;
            this.chkCarsamba.CheckedChanged += new System.EventHandler(this.chkCarsamba_CheckedChanged);
            // 
            // chkPersembe
            // 
            this.chkPersembe.AutoSize = true;
            this.chkPersembe.Location = new System.Drawing.Point(14, 164);
            this.chkPersembe.Name = "chkPersembe";
            this.chkPersembe.Size = new System.Drawing.Size(73, 17);
            this.chkPersembe.TabIndex = 17;
            this.chkPersembe.Text = "Perşembe";
            this.chkPersembe.UseVisualStyleBackColor = true;
            this.chkPersembe.CheckedChanged += new System.EventHandler(this.chkPersembe_CheckedChanged);
            // 
            // chkCuma
            // 
            this.chkCuma.AutoSize = true;
            this.chkCuma.Location = new System.Drawing.Point(15, 208);
            this.chkCuma.Name = "chkCuma";
            this.chkCuma.Size = new System.Drawing.Size(53, 17);
            this.chkCuma.TabIndex = 18;
            this.chkCuma.Text = "Cuma";
            this.chkCuma.UseVisualStyleBackColor = true;
            this.chkCuma.CheckedChanged += new System.EventHandler(this.chkCuma_CheckedChanged);
            // 
            // chkCumartesi
            // 
            this.chkCumartesi.AutoSize = true;
            this.chkCumartesi.Location = new System.Drawing.Point(15, 252);
            this.chkCumartesi.Name = "chkCumartesi";
            this.chkCumartesi.Size = new System.Drawing.Size(72, 17);
            this.chkCumartesi.TabIndex = 19;
            this.chkCumartesi.Text = "Cumartesi";
            this.chkCumartesi.UseVisualStyleBackColor = true;
            this.chkCumartesi.CheckedChanged += new System.EventHandler(this.chkCumartesi_CheckedChanged);
            // 
            // chkPazar
            // 
            this.chkPazar.AutoSize = true;
            this.chkPazar.Location = new System.Drawing.Point(15, 296);
            this.chkPazar.Name = "chkPazar";
            this.chkPazar.Size = new System.Drawing.Size(53, 17);
            this.chkPazar.TabIndex = 20;
            this.chkPazar.Text = "Pazar";
            this.chkPazar.UseVisualStyleBackColor = true;
            this.chkPazar.CheckedChanged += new System.EventHandler(this.chkPazar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BitPazar);
            this.groupBox1.Controls.Add(this.BitCumartesi);
            this.groupBox1.Controls.Add(this.BitCuma);
            this.groupBox1.Controls.Add(this.BitPerşembe);
            this.groupBox1.Controls.Add(this.BitÇarşamba);
            this.groupBox1.Controls.Add(this.BitSalı);
            this.groupBox1.Controls.Add(this.BitPazartesi);
            this.groupBox1.Controls.Add(this.basPazar);
            this.groupBox1.Controls.Add(this.basCumartesi);
            this.groupBox1.Controls.Add(this.basCuma);
            this.groupBox1.Controls.Add(this.BasPerşembe);
            this.groupBox1.Controls.Add(this.BasÇarşamba);
            this.groupBox1.Controls.Add(this.BasSalı);
            this.groupBox1.Controls.Add(this.BasPazartesi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkPazar);
            this.groupBox1.Controls.Add(this.chkPazartesi);
            this.groupBox1.Controls.Add(this.chkCumartesi);
            this.groupBox1.Controls.Add(this.chkSali);
            this.groupBox1.Controls.Add(this.chkCuma);
            this.groupBox1.Controls.Add(this.chkCarsamba);
            this.groupBox1.Controls.Add(this.chkPersembe);
            this.groupBox1.Location = new System.Drawing.Point(222, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 322);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Açık Olduğu Gün-Saatler";
            // 
            // BitPazar
            // 
            this.BitPazar.CustomFormat = "";
            this.BitPazar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitPazar.Location = new System.Drawing.Point(188, 293);
            this.BitPazar.Name = "BitPazar";
            this.BitPazar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitPazar.ShowUpDown = true;
            this.BitPazar.Size = new System.Drawing.Size(73, 20);
            this.BitPazar.TabIndex = 24;
            this.BitPazar.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitPazar.Visible = false;
            // 
            // BitCumartesi
            // 
            this.BitCumartesi.CustomFormat = "";
            this.BitCumartesi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitCumartesi.Location = new System.Drawing.Point(188, 249);
            this.BitCumartesi.Name = "BitCumartesi";
            this.BitCumartesi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitCumartesi.ShowUpDown = true;
            this.BitCumartesi.Size = new System.Drawing.Size(73, 20);
            this.BitCumartesi.TabIndex = 24;
            this.BitCumartesi.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitCumartesi.Visible = false;
            // 
            // BitCuma
            // 
            this.BitCuma.CustomFormat = "";
            this.BitCuma.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitCuma.Location = new System.Drawing.Point(188, 205);
            this.BitCuma.Name = "BitCuma";
            this.BitCuma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitCuma.ShowUpDown = true;
            this.BitCuma.Size = new System.Drawing.Size(73, 20);
            this.BitCuma.TabIndex = 24;
            this.BitCuma.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitCuma.Visible = false;
            // 
            // BitPerşembe
            // 
            this.BitPerşembe.CustomFormat = "";
            this.BitPerşembe.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitPerşembe.Location = new System.Drawing.Point(187, 161);
            this.BitPerşembe.Name = "BitPerşembe";
            this.BitPerşembe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitPerşembe.ShowUpDown = true;
            this.BitPerşembe.Size = new System.Drawing.Size(73, 20);
            this.BitPerşembe.TabIndex = 24;
            this.BitPerşembe.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitPerşembe.Visible = false;
            // 
            // BitÇarşamba
            // 
            this.BitÇarşamba.CustomFormat = "";
            this.BitÇarşamba.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitÇarşamba.Location = new System.Drawing.Point(188, 117);
            this.BitÇarşamba.Name = "BitÇarşamba";
            this.BitÇarşamba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitÇarşamba.ShowUpDown = true;
            this.BitÇarşamba.Size = new System.Drawing.Size(73, 20);
            this.BitÇarşamba.TabIndex = 24;
            this.BitÇarşamba.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitÇarşamba.Visible = false;
            // 
            // BitSalı
            // 
            this.BitSalı.CustomFormat = "";
            this.BitSalı.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitSalı.Location = new System.Drawing.Point(188, 73);
            this.BitSalı.Name = "BitSalı";
            this.BitSalı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitSalı.ShowUpDown = true;
            this.BitSalı.Size = new System.Drawing.Size(73, 20);
            this.BitSalı.TabIndex = 24;
            this.BitSalı.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitSalı.Visible = false;
            // 
            // BitPazartesi
            // 
            this.BitPazartesi.CustomFormat = "";
            this.BitPazartesi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BitPazartesi.Location = new System.Drawing.Point(188, 29);
            this.BitPazartesi.Name = "BitPazartesi";
            this.BitPazartesi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BitPazartesi.ShowUpDown = true;
            this.BitPazartesi.Size = new System.Drawing.Size(73, 20);
            this.BitPazartesi.TabIndex = 24;
            this.BitPazartesi.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BitPazartesi.Visible = false;
            // 
            // basPazar
            // 
            this.basPazar.CustomFormat = "";
            this.basPazar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.basPazar.Location = new System.Drawing.Point(101, 293);
            this.basPazar.Name = "basPazar";
            this.basPazar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.basPazar.ShowUpDown = true;
            this.basPazar.Size = new System.Drawing.Size(73, 20);
            this.basPazar.TabIndex = 24;
            this.basPazar.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.basPazar.Visible = false;
            // 
            // basCumartesi
            // 
            this.basCumartesi.CustomFormat = "";
            this.basCumartesi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.basCumartesi.Location = new System.Drawing.Point(101, 249);
            this.basCumartesi.Name = "basCumartesi";
            this.basCumartesi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.basCumartesi.ShowUpDown = true;
            this.basCumartesi.Size = new System.Drawing.Size(73, 20);
            this.basCumartesi.TabIndex = 24;
            this.basCumartesi.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.basCumartesi.Visible = false;
            // 
            // basCuma
            // 
            this.basCuma.CustomFormat = "";
            this.basCuma.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.basCuma.Location = new System.Drawing.Point(101, 205);
            this.basCuma.Name = "basCuma";
            this.basCuma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.basCuma.ShowUpDown = true;
            this.basCuma.Size = new System.Drawing.Size(73, 20);
            this.basCuma.TabIndex = 24;
            this.basCuma.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.basCuma.Visible = false;
            // 
            // BasPerşembe
            // 
            this.BasPerşembe.CustomFormat = "";
            this.BasPerşembe.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BasPerşembe.Location = new System.Drawing.Point(100, 161);
            this.BasPerşembe.Name = "BasPerşembe";
            this.BasPerşembe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasPerşembe.ShowUpDown = true;
            this.BasPerşembe.Size = new System.Drawing.Size(73, 20);
            this.BasPerşembe.TabIndex = 24;
            this.BasPerşembe.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BasPerşembe.Visible = false;
            // 
            // BasÇarşamba
            // 
            this.BasÇarşamba.CustomFormat = "";
            this.BasÇarşamba.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BasÇarşamba.Location = new System.Drawing.Point(101, 117);
            this.BasÇarşamba.Name = "BasÇarşamba";
            this.BasÇarşamba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasÇarşamba.ShowUpDown = true;
            this.BasÇarşamba.Size = new System.Drawing.Size(73, 20);
            this.BasÇarşamba.TabIndex = 24;
            this.BasÇarşamba.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BasÇarşamba.Visible = false;
            // 
            // BasSalı
            // 
            this.BasSalı.CustomFormat = "";
            this.BasSalı.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BasSalı.Location = new System.Drawing.Point(101, 73);
            this.BasSalı.Name = "BasSalı";
            this.BasSalı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasSalı.ShowUpDown = true;
            this.BasSalı.Size = new System.Drawing.Size(73, 20);
            this.BasSalı.TabIndex = 24;
            this.BasSalı.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BasSalı.Visible = false;
            // 
            // BasPazartesi
            // 
            this.BasPazartesi.CustomFormat = "";
            this.BasPazartesi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BasPazartesi.Location = new System.Drawing.Point(101, 29);
            this.BasPazartesi.Name = "BasPazartesi";
            this.BasPazartesi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BasPazartesi.ShowUpDown = true;
            this.BasPazartesi.Size = new System.Drawing.Size(73, 20);
            this.BasPazartesi.TabIndex = 24;
            this.BasPazartesi.Value = new System.DateTime(2018, 5, 25, 0, 0, 0, 0);
            this.BasPazartesi.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "-";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "-";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "-";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "-";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "-";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "-";
            this.label7.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ücret";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(81, 237);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 20);
            this.txtUcret.TabIndex = 22;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(521, 49);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(199, 319);
            this.checkedListBox1.TabIndex = 23;
            // 
            // SahaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 466);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSahaAdi);
            this.Name = "SahaEkle";
            this.Text = "SahaEkle";
            this.Load += new System.EventHandler(this.SahaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahaTuruBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkPazartesi;
        private System.Windows.Forms.CheckBox chkSali;
        private System.Windows.Forms.CheckBox chkCarsamba;
        private System.Windows.Forms.CheckBox chkPersembe;
        private System.Windows.Forms.CheckBox chkCuma;
        private System.Windows.Forms.CheckBox chkCumartesi;
        private System.Windows.Forms.CheckBox chkPazar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker BasPazartesi;
        private System.Windows.Forms.DateTimePicker BitPazar;
        private System.Windows.Forms.DateTimePicker BitCumartesi;
        private System.Windows.Forms.DateTimePicker BitCuma;
        private System.Windows.Forms.DateTimePicker BitPerşembe;
        private System.Windows.Forms.DateTimePicker BitÇarşamba;
        private System.Windows.Forms.DateTimePicker BitSalı;
        private System.Windows.Forms.DateTimePicker BitPazartesi;
        private System.Windows.Forms.DateTimePicker basPazar;
        private System.Windows.Forms.DateTimePicker basCumartesi;
        private System.Windows.Forms.DateTimePicker basCuma;
        private System.Windows.Forms.DateTimePicker BasPerşembe;
        private System.Windows.Forms.DateTimePicker BasÇarşamba;
        private System.Windows.Forms.DateTimePicker BasSalı;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}