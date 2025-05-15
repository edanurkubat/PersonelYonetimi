namespace PersonelYonetimi
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIsimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new PersonelYonetimi.PersonelDataSet();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKisiAra = new System.Windows.Forms.Button();
            this.tbAra = new System.Windows.Forms.TextBox();
            this.personelTableAdapter = new PersonelYonetimi.PersonelDataSetTableAdapters.PersonelTableAdapter();
            this.btnDepartman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
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
            this.dataGridViewPersoneller.DataSource = this.personelBindingSource;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.RowHeadersWidth = 51;
            this.dataGridViewPersoneller.RowTemplate.Height = 24;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(928, 403);
            this.dataGridViewPersoneller.TabIndex = 0;
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
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.Navy;
            this.btnDuzenle.Location = new System.Drawing.Point(6, 1);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(154, 29);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Personel Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Navy;
            this.btnCikis.Location = new System.Drawing.Point(857, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 29);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKisiAra
            // 
            this.btnKisiAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKisiAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKisiAra.BackgroundImage")));
            this.btnKisiAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKisiAra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiAra.ForeColor = System.Drawing.Color.Navy;
            this.btnKisiAra.Location = new System.Drawing.Point(847, 42);
            this.btnKisiAra.Name = "btnKisiAra";
            this.btnKisiAra.Size = new System.Drawing.Size(93, 29);
            this.btnKisiAra.TabIndex = 3;
            this.btnKisiAra.Text = "Kişi Ara";
            this.btnKisiAra.UseVisualStyleBackColor = true;
            this.btnKisiAra.Click += new System.EventHandler(this.btnKisiAra_Click);
            // 
            // tbAra
            // 
            this.tbAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAra.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbAra.Location = new System.Drawing.Point(12, 46);
            this.tbAra.Name = "tbAra";
            this.tbAra.Size = new System.Drawing.Size(829, 24);
            this.tbAra.TabIndex = 0;
            this.tbAra.Text = "Lütfen aramak istediğiniz kelimeyi giriniz...";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartman.FlatAppearance.BorderSize = 0;
            this.btnDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartman.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.ForeColor = System.Drawing.Color.Navy;
            this.btnDepartman.Location = new System.Drawing.Point(166, 1);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(112, 29);
            this.btnDepartman.TabIndex = 4;
            this.btnDepartman.Text = "Departman";
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 525);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.tbAra);
            this.Controls.Add(this.btnKisiAra);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKisiAra;
        private System.Windows.Forms.TextBox tbAra;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private PersonelDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIsimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelPozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDepartman;
    }
}