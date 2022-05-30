namespace OkanAydoganProje
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ılacEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilacDataSet1 = new OkanAydoganProje.ilacDataSet1();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.hastaKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ayEczanesiDataSet = new OkanAydoganProje.AyEczanesiDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.hastaKayitTableAdapter = new OkanAydoganProje.AyEczanesiDataSetTableAdapters.HastaKayitTableAdapter();
            this.ayEczanesiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaKayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ayEczanesiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ilacEkleTableAdapter = new OkanAydoganProje.ilacDataSet1TableAdapters.IlacEkleTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ılacEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(654, 38);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(134, 20);
            this.TextBox2.TabIndex = 115;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(502, 38);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(134, 20);
            this.TextBox1.TabIndex = 114;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(338, 39);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.DateTimePicker1.TabIndex = 113;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(694, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 13);
            this.Label5.TabIndex = 112;
            this.Label5.Text = "Fatura No:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(552, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 13);
            this.Label4.TabIndex = 111;
            this.Label4.Text = "Adet:";
            // 
            // ComboBox2
            // 
            this.ComboBox2.DataSource = this.ılacEkleBindingSource;
            this.ComboBox2.DisplayMember = "Ad";
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(177, 39);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(135, 21);
            this.ComboBox2.TabIndex = 110;
            // 
            // ılacEkleBindingSource
            // 
            this.ılacEkleBindingSource.DataMember = "IlacEkle";
            this.ılacEkleBindingSource.DataSource = this.ilacDataSet1;
            // 
            // ilacDataSet1
            // 
            this.ilacDataSet1.DataSetName = "ilacDataSet1";
            this.ilacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboBox1
            // 
            this.ComboBox1.DataSource = this.hastaKayitBindingSource;
            this.ComboBox1.DisplayMember = "TCKimlik";
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(12, 39);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(135, 21);
            this.ComboBox1.TabIndex = 109;
            // 
            // hastaKayitBindingSource
            // 
            this.hastaKayitBindingSource.DataMember = "HastaKayit";
            this.hastaKayitBindingSource.DataSource = this.ayEczanesiDataSet;
            // 
            // ayEczanesiDataSet
            // 
            this.ayEczanesiDataSet.DataSetName = "AyEczanesiDataSet";
            this.ayEczanesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Hasta Tc Kimlik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "İlaç:";
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageKey = "1274298004_Floppy-64.png";
            this.btnSil.Location = new System.Drawing.Point(502, 94);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 30);
            this.btnSil.TabIndex = 120;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageKey = "1274298004_Floppy-64.png";
            this.btnGuncelle.Location = new System.Drawing.Point(365, 94);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(99, 30);
            this.btnGuncelle.TabIndex = 119;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "1274298004_Floppy-64.png";
            this.btnKaydet.Location = new System.Drawing.Point(225, 94);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 30);
            this.btnKaydet.TabIndex = 118;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "1274298505_cancel.png";
            this.btnCikis.Location = new System.Drawing.Point(697, 415);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 23);
            this.btnCikis.TabIndex = 117;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(590, 415);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(89, 23);
            this.Button1.TabIndex = 116;
            this.Button1.Text = "Ana Menü";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(163, 417);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(130, 20);
            this.TextBox6.TabIndex = 135;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 136;
            this.button2.Text = "Ara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "TC Kimlik",
            "Fatura No"});
            this.comboBox3.Location = new System.Drawing.Point(33, 417);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 137;
            // 
            // hastaKayitTableAdapter
            // 
            this.hastaKayitTableAdapter.ClearBeforeFill = true;
            // 
            // ayEczanesiDataSetBindingSource
            // 
            this.ayEczanesiDataSetBindingSource.DataSource = this.ayEczanesiDataSet;
            this.ayEczanesiDataSetBindingSource.Position = 0;
            // 
            // hastaKayitBindingSource1
            // 
            this.hastaKayitBindingSource1.DataMember = "HastaKayit";
            this.hastaKayitBindingSource1.DataSource = this.ayEczanesiDataSetBindingSource;
            // 
            // ayEczanesiDataSetBindingSource1
            // 
            this.ayEczanesiDataSetBindingSource1.DataSource = this.ayEczanesiDataSet;
            this.ayEczanesiDataSetBindingSource1.Position = 0;
            // 
            // ilacEkleTableAdapter
            // 
            this.ilacEkleTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 277);
            this.listView1.TabIndex = 138;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta TC";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İlaç";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adet";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fatura No";
            this.columnHeader6.Width = 184;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(770, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(10, 13);
            this.textBox3.TabIndex = 139;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Reçete Satış";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ılacEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayEczanesiDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox ComboBox2;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private AyEczanesiDataSet ayEczanesiDataSet;
        private System.Windows.Forms.BindingSource hastaKayitBindingSource;
        private AyEczanesiDataSetTableAdapters.HastaKayitTableAdapter hastaKayitTableAdapter;
        private System.Windows.Forms.BindingSource ayEczanesiDataSetBindingSource;
        private System.Windows.Forms.BindingSource hastaKayitBindingSource1;
        private System.Windows.Forms.BindingSource ayEczanesiDataSetBindingSource1;
        private ilacDataSet1 ilacDataSet1;
        private System.Windows.Forms.BindingSource ılacEkleBindingSource;
        private ilacDataSet1TableAdapters.IlacEkleTableAdapter ilacEkleTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.TextBox textBox3;
    }
}