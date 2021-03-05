namespace αbetik
{
    partial class Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgwRules = new System.Windows.Forms.DataGridView();
            this.tbxRules = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.gbxFeatures = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxSearchId = new System.Windows.Forms.TextBox();
            this.lblRules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRules)).BeginInit();
            this.gbxFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Cyan;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(344, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 10);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(376, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 10);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgwRules
            // 
            this.dgwRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRules.Location = new System.Drawing.Point(12, 30);
            this.dgwRules.Name = "dgwRules";
            this.dgwRules.ReadOnly = true;
            this.dgwRules.Size = new System.Drawing.Size(394, 131);
            this.dgwRules.TabIndex = 4;
            this.dgwRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRules_CellClick);
            // 
            // tbxRules
            // 
            this.tbxRules.Location = new System.Drawing.Point(12, 167);
            this.tbxRules.Multiline = true;
            this.tbxRules.Name = "tbxRules";
            this.tbxRules.Size = new System.Drawing.Size(394, 113);
            this.tbxRules.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(216, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 22);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(152, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 22);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(152, 40);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(58, 22);
            this.btnPublish.TabIndex = 9;
            this.btnPublish.Text = "Yayınla";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(76, 19);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(75, 20);
            this.tbxTC.TabIndex = 10;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(25, 18);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(20, 20);
            this.tbxId.TabIndex = 12;
            // 
            // gbxFeatures
            // 
            this.gbxFeatures.Controls.Add(this.lblSearch);
            this.gbxFeatures.Controls.Add(this.tbxId);
            this.gbxFeatures.Controls.Add(this.tbxTC);
            this.gbxFeatures.Controls.Add(this.label1);
            this.gbxFeatures.Controls.Add(this.lblId);
            this.gbxFeatures.Controls.Add(this.tbxSearchId);
            this.gbxFeatures.Controls.Add(this.btnAdd);
            this.gbxFeatures.Controls.Add(this.btnDelete);
            this.gbxFeatures.Controls.Add(this.btnUpdate);
            this.gbxFeatures.Controls.Add(this.btnPublish);
            this.gbxFeatures.Location = new System.Drawing.Point(124, 281);
            this.gbxFeatures.Name = "gbxFeatures";
            this.gbxFeatures.Size = new System.Drawing.Size(277, 65);
            this.gbxFeatures.TabIndex = 13;
            this.gbxFeatures.TabStop = false;
            this.gbxFeatures.Text = "İşlemler";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(97, 45);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(23, 13);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(2, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id :";
            // 
            // tbxSearchId
            // 
            this.tbxSearchId.Location = new System.Drawing.Point(126, 42);
            this.tbxSearchId.Name = "tbxSearchId";
            this.tbxSearchId.Size = new System.Drawing.Size(20, 20);
            this.tbxSearchId.TabIndex = 13;
            this.tbxSearchId.TextChanged += new System.EventHandler(this.tbxSearchId_TextChanged);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(44, 298);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(35, 13);
            this.lblRules.TabIndex = 14;
            this.lblRules.Text = "label2";
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(413, 350);
            this.ControlBox = false;
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.tbxRules);
            this.Controls.Add(this.dgwRules);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxFeatures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ayarlar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ayarlar_FormClosed);
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRules)).EndInit();
            this.gbxFeatures.ResumeLayout(false);
            this.gbxFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgwRules;
        private System.Windows.Forms.TextBox tbxRules;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPublish;
        public System.Windows.Forms.TextBox tbxTC;
        public System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.GroupBox gbxFeatures;
        public System.Windows.Forms.TextBox tbxSearchId;
        public System.Windows.Forms.Label lblSearch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRules;
    }
}