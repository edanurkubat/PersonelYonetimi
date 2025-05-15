namespace PersonelYonetimi
{
    partial class FormDepartman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartman));
            this.dataGridViewDepartman = new System.Windows.Forms.DataGridView();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSetDepartman = new PersonelYonetimi.PersonelDataSetDepartman();
            this.departmanTableAdapter = new PersonelYonetimi.PersonelDataSetDepartmanTableAdapters.DepartmanTableAdapter();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.tbDepartmanID = new System.Windows.Forms.TextBox();
            this.tbDepartmanAdi = new System.Windows.Forms.TextBox();
            this.lblDepartmanID = new System.Windows.Forms.Label();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.btnDepartmanGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetDepartman)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartman
            // 
            this.dataGridViewDepartman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDepartman.AutoGenerateColumns = false;
            this.dataGridViewDepartman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmanIDDataGridViewTextBoxColumn,
            this.departmanAdiDataGridViewTextBoxColumn});
            this.dataGridViewDepartman.DataSource = this.departmanBindingSource;
            this.dataGridViewDepartman.Location = new System.Drawing.Point(29, 70);
            this.dataGridViewDepartman.Name = "dataGridViewDepartman";
            this.dataGridViewDepartman.RowHeadersWidth = 51;
            this.dataGridViewDepartman.RowTemplate.Height = 24;
            this.dataGridViewDepartman.Size = new System.Drawing.Size(415, 296);
            this.dataGridViewDepartman.TabIndex = 0;
            this.dataGridViewDepartman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellContentClick);
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            this.departmanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmanIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmanAdiDataGridViewTextBoxColumn
            // 
            this.departmanAdiDataGridViewTextBoxColumn.DataPropertyName = "DepartmanAdi";
            this.departmanAdiDataGridViewTextBoxColumn.HeaderText = "DepartmanAdi";
            this.departmanAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmanAdiDataGridViewTextBoxColumn.Name = "departmanAdiDataGridViewTextBoxColumn";
            this.departmanAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmanBindingSource
            // 
            this.departmanBindingSource.DataMember = "Departman";
            this.departmanBindingSource.DataSource = this.personelDataSetDepartman;
            // 
            // personelDataSetDepartman
            // 
            this.personelDataSetDepartman.DataSetName = "PersonelDataSetDepartman";
            this.personelDataSetDepartman.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmanTableAdapter
            // 
            this.departmanTableAdapter.ClearBeforeFill = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Navy;
            this.btnCikis.Location = new System.Drawing.Point(771, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 28);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Navy;
            this.btnAnasayfa.Location = new System.Drawing.Point(12, 0);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(91, 33);
            this.btnAnasayfa.TabIndex = 2;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // tbDepartmanID
            // 
            this.tbDepartmanID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDepartmanID.Location = new System.Drawing.Point(640, 103);
            this.tbDepartmanID.Name = "tbDepartmanID";
            this.tbDepartmanID.Size = new System.Drawing.Size(149, 22);
            this.tbDepartmanID.TabIndex = 3;
            // 
            // tbDepartmanAdi
            // 
            this.tbDepartmanAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDepartmanAdi.Location = new System.Drawing.Point(640, 152);
            this.tbDepartmanAdi.Name = "tbDepartmanAdi";
            this.tbDepartmanAdi.Size = new System.Drawing.Size(149, 22);
            this.tbDepartmanAdi.TabIndex = 0;
            // 
            // lblDepartmanID
            // 
            this.lblDepartmanID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartmanID.AutoSize = true;
            this.lblDepartmanID.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanID.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartmanID.Location = new System.Drawing.Point(498, 105);
            this.lblDepartmanID.Name = "lblDepartmanID";
            this.lblDepartmanID.Size = new System.Drawing.Size(113, 20);
            this.lblDepartmanID.TabIndex = 5;
            this.lblDepartmanID.Text = "Departman ID:";
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdi.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(498, 154);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(123, 20);
            this.lblDepartmanAdi.TabIndex = 6;
            this.lblDepartmanAdi.Text = "Departman Adı:";
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepartmanEkle.BackgroundImage")));
            this.btnDepartmanEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.ForeColor = System.Drawing.Color.Navy;
            this.btnDepartmanEkle.Location = new System.Drawing.Point(502, 214);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(203, 41);
            this.btnDepartmanEkle.TabIndex = 7;
            this.btnDepartmanEkle.Text = "Departman Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // btnDepartmanGuncelle
            // 
            this.btnDepartmanGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepartmanGuncelle.BackgroundImage")));
            this.btnDepartmanGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartmanGuncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanGuncelle.ForeColor = System.Drawing.Color.Navy;
            this.btnDepartmanGuncelle.Location = new System.Drawing.Point(502, 272);
            this.btnDepartmanGuncelle.Name = "btnDepartmanGuncelle";
            this.btnDepartmanGuncelle.Size = new System.Drawing.Size(203, 41);
            this.btnDepartmanGuncelle.TabIndex = 8;
            this.btnDepartmanGuncelle.Text = "Departman Güncelle";
            this.btnDepartmanGuncelle.UseVisualStyleBackColor = true;
            this.btnDepartmanGuncelle.Click += new System.EventHandler(this.btnDepartmanGuncelle_Click);
            // 
            // FormDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 414);
            this.Controls.Add(this.btnDepartmanGuncelle);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.lblDepartmanID);
            this.Controls.Add(this.tbDepartmanAdi);
            this.Controls.Add(this.tbDepartmanID);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.dataGridViewDepartman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman";
            this.Load += new System.EventHandler(this.FormDepartman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetDepartman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartman;
        private PersonelDataSetDepartman personelDataSetDepartman;
        private System.Windows.Forms.BindingSource departmanBindingSource;
        private PersonelDataSetDepartmanTableAdapters.DepartmanTableAdapter departmanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox tbDepartmanID;
        private System.Windows.Forms.TextBox tbDepartmanAdi;
        private System.Windows.Forms.Label lblDepartmanID;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.Button btnDepartmanGuncelle;
    }
}