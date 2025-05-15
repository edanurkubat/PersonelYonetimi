namespace PersonelYonetimi
{
    partial class FormDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuzenle));
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new PersonelYonetimi.PersonelDataSet();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIsım = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbIsım = new System.Windows.Forms.TextBox();
            this.tbSoyisim = new System.Windows.Forms.TextBox();
            this.tbPozisyon = new System.Windows.Forms.TextBox();
            this.tbMaas = new System.Windows.Forms.TextBox();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTableAdapter = new PersonelYonetimi.PersonelDataSetTableAdapters.PersonelTableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cbDepartman = new System.Windows.Forms.ComboBox();
            this.departmanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet3 = new PersonelYonetimi.PersonelDataSet3();
            this.datetpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.personelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSetDepartmanAdi = new PersonelYonetimi.PersonelDataSetDepartmanAdi();
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTableAdapter = new PersonelYonetimi.PersonelDataSetDepartmanAdiTableAdapters.DepartmanTableAdapter();
            this.personelDataSet2 = new PersonelYonetimi.PersonelDataSet2();
            this.departmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.departmanTableAdapter1 = new PersonelYonetimi.PersonelDataSet2TableAdapters.DepartmanTableAdapter();
            this.departmanTableAdapter2 = new PersonelYonetimi.PersonelDataSet3TableAdapters.DepartmanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetDepartmanAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPersoneller.AutoGenerateColumns = false;
            this.dataGridViewPersoneller.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelIsimDataGridViewTextBoxColumn,
            this.personelSoyisimDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn,
            this.personelPozisyonDataGridViewTextBoxColumn,
            this.personelDogumTarihiDataGridViewTextBoxColumn});
            this.dataGridViewPersoneller.DataSource = this.personelBindingSource3;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(359, 45);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.RowHeadersWidth = 51;
            this.dataGridViewPersoneller.RowTemplate.Height = 24;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(938, 365);
            this.dataGridViewPersoneller.TabIndex = 0;
            this.dataGridViewPersoneller.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellContentClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelIsimDataGridViewTextBoxColumn
            // 
            this.personelIsimDataGridViewTextBoxColumn.DataPropertyName = "PersonelIsim";
            this.personelIsimDataGridViewTextBoxColumn.HeaderText = "PersonelIsim";
            this.personelIsimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIsimDataGridViewTextBoxColumn.Name = "personelIsimDataGridViewTextBoxColumn";
            this.personelIsimDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelSoyisimDataGridViewTextBoxColumn
            // 
            this.personelSoyisimDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyisim";
            this.personelSoyisimDataGridViewTextBoxColumn.HeaderText = "PersonelSoyisim";
            this.personelSoyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelSoyisimDataGridViewTextBoxColumn.Name = "personelSoyisimDataGridViewTextBoxColumn";
            this.personelSoyisimDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            this.personelMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            this.departmanIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelPozisyonDataGridViewTextBoxColumn
            // 
            this.personelPozisyonDataGridViewTextBoxColumn.DataPropertyName = "PersonelPozisyon";
            this.personelPozisyonDataGridViewTextBoxColumn.HeaderText = "PersonelPozisyon";
            this.personelPozisyonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelPozisyonDataGridViewTextBoxColumn.Name = "personelPozisyonDataGridViewTextBoxColumn";
            this.personelPozisyonDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelDogumTarihiDataGridViewTextBoxColumn
            // 
            this.personelDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "PersonelDogumTarihi";
            this.personelDogumTarihiDataGridViewTextBoxColumn.HeaderText = "PersonelDogumTarihi";
            this.personelDogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelDogumTarihiDataGridViewTextBoxColumn.Name = "personelDogumTarihiDataGridViewTextBoxColumn";
            this.personelDogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelBindingSource3
            // 
            this.personelBindingSource3.DataMember = "Personel";
            this.personelBindingSource3.DataSource = this.personelDataSetBindingSource;
            // 
            // personelDataSetBindingSource
            // 
            this.personelDataSetBindingSource.DataSource = this.personelDataSet;
            this.personelDataSetBindingSource.Position = 0;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.personelDataSetBindingSource;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Navy;
            this.btnAnasayfa.Location = new System.Drawing.Point(3, 0);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(108, 30);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.Navy;
            this.lblID.Location = new System.Drawing.Point(103, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(34, 24);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // lblIsım
            // 
            this.lblIsım.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIsım.AutoSize = true;
            this.lblIsım.BackColor = System.Drawing.Color.Transparent;
            this.lblIsım.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsım.ForeColor = System.Drawing.Color.Navy;
            this.lblIsım.Location = new System.Drawing.Point(86, 106);
            this.lblIsım.Name = "lblIsım";
            this.lblIsım.Size = new System.Drawing.Size(51, 24);
            this.lblIsım.TabIndex = 3;
            this.lblIsım.Text = "İsim:";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.ForeColor = System.Drawing.Color.Navy;
            this.lblSoyisim.Location = new System.Drawing.Point(56, 162);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(81, 24);
            this.lblSoyisim.TabIndex = 4;
            this.lblSoyisim.Text = "Soyisim:";
            // 
            // lblDepartman
            // 
            this.lblDepartman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartman.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartman.Location = new System.Drawing.Point(26, 218);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(111, 24);
            this.lblDepartman.TabIndex = 5;
            this.lblDepartman.Text = "Departman:";
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.BackColor = System.Drawing.Color.Transparent;
            this.lblPozisyon.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.ForeColor = System.Drawing.Color.Navy;
            this.lblPozisyon.Location = new System.Drawing.Point(46, 274);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(91, 24);
            this.lblPozisyon.TabIndex = 6;
            this.lblPozisyon.Text = "Pozisyon:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.Navy;
            this.lblDogumTarihi.Location = new System.Drawing.Point(5, 330);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(132, 24);
            this.lblDogumTarihi.TabIndex = 7;
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblMaas
            // 
            this.lblMaas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaas.AutoSize = true;
            this.lblMaas.BackColor = System.Drawing.Color.Transparent;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.ForeColor = System.Drawing.Color.Navy;
            this.lblMaas.Location = new System.Drawing.Point(77, 386);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(60, 24);
            this.lblMaas.TabIndex = 8;
            this.lblMaas.Text = "Maaş:";
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbID.Location = new System.Drawing.Point(143, 52);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(171, 22);
            this.tbID.TabIndex = 9;
            // 
            // tbIsım
            // 
            this.tbIsım.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIsım.Location = new System.Drawing.Point(143, 108);
            this.tbIsım.Name = "tbIsım";
            this.tbIsım.Size = new System.Drawing.Size(171, 22);
            this.tbIsım.TabIndex = 0;
            // 
            // tbSoyisim
            // 
            this.tbSoyisim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSoyisim.Location = new System.Drawing.Point(143, 164);
            this.tbSoyisim.Name = "tbSoyisim";
            this.tbSoyisim.Size = new System.Drawing.Size(171, 22);
            this.tbSoyisim.TabIndex = 11;
            // 
            // tbPozisyon
            // 
            this.tbPozisyon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPozisyon.Location = new System.Drawing.Point(143, 278);
            this.tbPozisyon.Name = "tbPozisyon";
            this.tbPozisyon.Size = new System.Drawing.Size(171, 22);
            this.tbPozisyon.TabIndex = 13;
            // 
            // tbMaas
            // 
            this.tbMaas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaas.Location = new System.Drawing.Point(143, 392);
            this.tbMaas.Name = "tbMaas";
            this.tbMaas.Size = new System.Drawing.Size(171, 22);
            this.tbMaas.TabIndex = 15;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personelDataSetBindingSource;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Navy;
            this.btnCikis.Location = new System.Drawing.Point(1190, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(84, 29);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnListele
            // 
            this.btnListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListele.BackgroundImage")));
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListele.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.Navy;
            this.btnListele.Location = new System.Drawing.Point(834, 449);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(147, 46);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Navy;
            this.btnKaydet.Location = new System.Drawing.Point(123, 449);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(147, 46);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Navy;
            this.btnSil.Location = new System.Drawing.Point(597, 449);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(147, 46);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Navy;
            this.btnGuncelle.Location = new System.Drawing.Point(360, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(147, 46);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Navy;
            this.btnTemizle.Location = new System.Drawing.Point(1071, 449);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(147, 46);
            this.btnTemizle.TabIndex = 21;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cbDepartman
            // 
            this.cbDepartman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDepartman.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmanBindingSource2, "DepartmanID", true));
            this.cbDepartman.DataSource = this.departmanBindingSource2;
            this.cbDepartman.DisplayMember = "DepartmanAdi";
            this.cbDepartman.FormattingEnabled = true;
            this.cbDepartman.Location = new System.Drawing.Point(143, 220);
            this.cbDepartman.Name = "cbDepartman";
            this.cbDepartman.Size = new System.Drawing.Size(171, 24);
            this.cbDepartman.TabIndex = 23;
            this.cbDepartman.ValueMember = "DepartmanID";
            // 
            // departmanBindingSource2
            // 
            this.departmanBindingSource2.DataMember = "Departman";
            this.departmanBindingSource2.DataSource = this.personelDataSet3;
            // 
            // personelDataSet3
            // 
            this.personelDataSet3.DataSetName = "PersonelDataSet3";
            this.personelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datetpDogumTarihi
            // 
            this.datetpDogumTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datetpDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetpDogumTarihi.Location = new System.Drawing.Point(143, 334);
            this.datetpDogumTarihi.MaxDate = new System.DateTime(2310, 12, 31, 0, 0, 0, 0);
            this.datetpDogumTarihi.Name = "datetpDogumTarihi";
            this.datetpDogumTarihi.Size = new System.Drawing.Size(171, 24);
            this.datetpDogumTarihi.TabIndex = 24;
            this.datetpDogumTarihi.Value = new System.DateTime(2025, 5, 14, 20, 57, 30, 0);
            // 
            // personelBindingSource2
            // 
            this.personelBindingSource2.DataMember = "Personel";
            this.personelBindingSource2.DataSource = this.personelDataSetBindingSource;
            // 
            // personelDataSetDepartmanAdi
            // 
            this.personelDataSetDepartmanAdi.DataSetName = "PersonelDataSetDepartmanAdi";
            this.personelDataSetDepartmanAdi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
            this.departmanBindingSource.DataSource = this.personelDataSetDepartmanAdi;
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // personelDataSet2
            // 
            this.personelDataSet2.DataSetName = "PersonelDataSet2";
            this.personelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanBindingSource1
            // 
            this.departmanBindingSource1.DataMember = "Departman";
            this.departmanBindingSource1.DataSource = this.personelDataSet2;
            // 
            // departmanTableAdapter1
            // 
            this.departmanTableAdapter1.ClearBeforeFill = true;
            // 
            // departmanTableAdapter2
            // 
            this.departmanTableAdapter2.ClearBeforeFill = true;
            // 
            // FormDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 521);
            this.Controls.Add(this.datetpDogumTarihi);
            this.Controls.Add(this.cbDepartman);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.tbMaas);
            this.Controls.Add(this.tbPozisyon);
            this.Controls.Add(this.tbSoyisim);
            this.Controls.Add(this.tbIsım);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblPozisyon);
            this.Controls.Add(this.lblDepartman);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsım);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personelleri Düzenle";
            this.Load += new System.EventHandler(this.FormDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetDepartmanAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIsım;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbIsım;
        private System.Windows.Forms.TextBox tbSoyisim;
        private System.Windows.Forms.TextBox tbPozisyon;
        private System.Windows.Forms.TextBox tbMaas;
        private System.Windows.Forms.BindingSource personelDataSetBindingSource;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private PersonelDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox cbDepartman;
        private System.Windows.Forms.DateTimePicker datetpDogumTarihi;
        private System.Windows.Forms.BindingSource personelBindingSource2;
        private PersonelDataSetDepartmanAdi personelDataSetDepartmanAdi;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private PersonelDataSetDepartmanAdiTableAdapters.DepartmanTableAdapter departmanTableAdapter;
        private PersonelDataSet2 personelDataSet2;
        private System.Windows.Forms.BindingSource departmanBindingSource1;
        private PersonelDataSet2TableAdapters.DepartmanTableAdapter departmanTableAdapter1;
        private PersonelDataSet3 personelDataSet3;
        private System.Windows.Forms.BindingSource departmanBindingSource2;
        private PersonelDataSet3TableAdapters.DepartmanTableAdapter departmanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelPozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personelBindingSource3;
    }
}