namespace WindowsFormsApp1
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
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.Rubrik = new System.Windows.Forms.Label();
            this.lvPodLista = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAntalAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taBortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbKtRubrik = new System.Windows.Forms.Label();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.cbFrekvens = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.Avsnitt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAvsnittsInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.cbAvsnitt = new System.Windows.Forms.ComboBox();
            this.llLankTill = new System.Windows.Forms.LinkLabel();
            this.btnEditFeed = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnGetAllFeeds = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(498, 263);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(75, 23);
            this.btnNyKategori.TabIndex = 0;
            this.btnNyKategori.Text = "Ny";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // Rubrik
            // 
            this.Rubrik.AutoSize = true;
            this.Rubrik.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rubrik.Location = new System.Drawing.Point(2, -2);
            this.Rubrik.Name = "Rubrik";
            this.Rubrik.Size = new System.Drawing.Size(188, 56);
            this.Rubrik.TabIndex = 1;
            this.Rubrik.Text = "Podcast ";
            // 
            // lvPodLista
            // 
            this.lvPodLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnFrek,
            this.columnCategory,
            this.columnUrl,
            this.columnAntalAvsnitt});
            this.lvPodLista.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPodLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPodLista.FullRowSelect = true;
            this.lvPodLista.Location = new System.Drawing.Point(12, 57);
            this.lvPodLista.Name = "lvPodLista";
            this.lvPodLista.Size = new System.Drawing.Size(480, 173);
            this.lvPodLista.TabIndex = 2;
            this.lvPodLista.UseCompatibleStateImageBehavior = false;
            this.lvPodLista.View = System.Windows.Forms.View.Details;
            this.lvPodLista.SelectedIndexChanged += new System.EventHandler(this.lvPodLista_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Namn";
            this.columnName.Width = 112;
            // 
            // columnFrek
            // 
            this.columnFrek.Text = "Frekvens(min)";
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Kategori";
            this.columnCategory.Width = 80;
            // 
            // columnUrl
            // 
            this.columnUrl.Text = "URL";
            this.columnUrl.Width = 170;
            // 
            // columnAntalAvsnitt
            // 
            this.columnAntalAvsnitt.Text = "Avsnitt";
            this.columnAntalAvsnitt.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taBortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // taBortToolStripMenuItem
            // 
            this.taBortToolStripMenuItem.Name = "taBortToolStripMenuItem";
            this.taBortToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.taBortToolStripMenuItem.Text = "Ta Bort";
            this.taBortToolStripMenuItem.Click += new System.EventHandler(this.taBortToolStripMenuItem_Click);
            // 
            // lbKtRubrik
            // 
            this.lbKtRubrik.AutoSize = true;
            this.lbKtRubrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKtRubrik.Location = new System.Drawing.Point(495, 31);
            this.lbKtRubrik.Name = "lbKtRubrik";
            this.lbKtRubrik.Size = new System.Drawing.Size(86, 18);
            this.lbKtRubrik.TabIndex = 4;
            this.lbKtRubrik.Text = "Kategorier";
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.Location = new System.Drawing.Point(498, 57);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(265, 173);
            this.lbKategori.TabIndex = 5;
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(498, 237);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(265, 20);
            this.tbKategori.TabIndex = 6;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(498, 288);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(75, 23);
            this.btnSparaKategori.TabIndex = 7;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(579, 263);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortKategori.TabIndex = 8;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uppdateringsfrekvens(min):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori:";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 246);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(134, 20);
            this.tbUrl.TabIndex = 12;
            this.tbUrl.Text = "https://...";
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(139, 288);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnNyPodcast.TabIndex = 13;
            this.btnNyPodcast.Text = "Ny";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(220, 288);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnSparaPodcast.TabIndex = 14;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(139, 313);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(75, 23);
            this.btnTaBortPodcast.TabIndex = 15;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.cbFrekvens.Location = new System.Drawing.Point(12, 290);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(121, 21);
            this.cbFrekvens.TabIndex = 17;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(330, 246);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(127, 21);
            this.cbKategori.TabIndex = 18;
            // 
            // Avsnitt
            // 
            this.Avsnitt.AutoSize = true;
            this.Avsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avsnitt.Location = new System.Drawing.Point(9, 343);
            this.Avsnitt.Name = "Avsnitt";
            this.Avsnitt.Size = new System.Drawing.Size(46, 13);
            this.Avsnitt.TabIndex = 21;
            this.Avsnitt.Text = "Avsnitt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "AvsnittsInfo";
            // 
            // tbAvsnittsInfo
            // 
            this.tbAvsnittsInfo.Location = new System.Drawing.Point(498, 343);
            this.tbAvsnittsInfo.Multiline = true;
            this.tbAvsnittsInfo.Name = "tbAvsnittsInfo";
            this.tbAvsnittsInfo.Size = new System.Drawing.Size(265, 95);
            this.tbAvsnittsInfo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Namn:";
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(177, 246);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(127, 20);
            this.tbNamn.TabIndex = 25;
            // 
            // cbAvsnitt
            // 
            this.cbAvsnitt.FormattingEnabled = true;
            this.cbAvsnitt.Location = new System.Drawing.Point(12, 362);
            this.cbAvsnitt.Name = "cbAvsnitt";
            this.cbAvsnitt.Size = new System.Drawing.Size(405, 21);
            this.cbAvsnitt.TabIndex = 26;
            this.cbAvsnitt.SelectedIndexChanged += new System.EventHandler(this.cbAvsnitt_SelectedIndexChanged);
            // 
            // llLankTill
            // 
            this.llLankTill.AutoSize = true;
            this.llLankTill.Location = new System.Drawing.Point(12, 394);
            this.llLankTill.Name = "llLankTill";
            this.llLankTill.Size = new System.Drawing.Size(59, 13);
            this.llLankTill.TabIndex = 27;
            this.llLankTill.TabStop = true;
            this.llLankTill.Text = "Gå till länk:";
            this.llLankTill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLankTill_LinkClicked);
            // 
            // btnEditFeed
            // 
            this.btnEditFeed.Location = new System.Drawing.Point(220, 313);
            this.btnEditFeed.Name = "btnEditFeed";
            this.btnEditFeed.Size = new System.Drawing.Size(75, 23);
            this.btnEditFeed.TabIndex = 28;
            this.btnEditFeed.Text = "Ändra Feed";
            this.btnEditFeed.UseVisualStyleBackColor = true;
            this.btnEditFeed.Click += new System.EventHandler(this.btnEditFeed_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(579, 288);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(75, 23);
            this.btnEditCategory.TabIndex = 29;
            this.btnEditCategory.Text = "Ändra Kat.";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(330, 288);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(127, 23);
            this.btnSearchCategory.TabIndex = 30;
            this.btnSearchCategory.Text = "Sök feed efter kategori";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnGetAllFeeds
            // 
            this.btnGetAllFeeds.Location = new System.Drawing.Point(330, 313);
            this.btnGetAllFeeds.Name = "btnGetAllFeeds";
            this.btnGetAllFeeds.Size = new System.Drawing.Size(127, 23);
            this.btnGetAllFeeds.TabIndex = 31;
            this.btnGetAllFeeds.Text = "Hämta alla feeds";
            this.btnGetAllFeeds.UseVisualStyleBackColor = true;
            this.btnGetAllFeeds.Click += new System.EventHandler(this.btnGetAllFeeds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetAllFeeds);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnEditFeed);
            this.Controls.Add(this.llLankTill);
            this.Controls.Add(this.cbAvsnitt);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAvsnittsInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Avsnitt);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbFrekvens);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.lbKtRubrik);
            this.Controls.Add(this.lvPodLista);
            this.Controls.Add(this.Rubrik);
            this.Controls.Add(this.btnNyKategori);
            this.Name = "Form1";
            this.Text = "https://...";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnNyKategori;
		private System.Windows.Forms.Label Rubrik;
		private System.Windows.Forms.ListView lvPodLista;
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnFrek;
		private System.Windows.Forms.ColumnHeader columnCategory;
		private System.Windows.Forms.Label lbKtRubrik;
		private System.Windows.Forms.ListBox lbKategori;
		private System.Windows.Forms.TextBox tbKategori;
		private System.Windows.Forms.Button btnSparaKategori;
		private System.Windows.Forms.Button btnTaBortKategori;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbUrl;
		private System.Windows.Forms.Button btnNyPodcast;
		private System.Windows.Forms.Button btnSparaPodcast;
		private System.Windows.Forms.Button btnTaBortPodcast;
		private System.Windows.Forms.ComboBox cbFrekvens;
		private System.Windows.Forms.ComboBox cbKategori;
		private System.Windows.Forms.Label Avsnitt;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAvsnittsInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.ComboBox cbAvsnitt;
        private System.Windows.Forms.LinkLabel llLankTill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taBortToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnUrl;
        private System.Windows.Forms.ColumnHeader columnAntalAvsnitt;
        private System.Windows.Forms.Button btnEditFeed;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnGetAllFeeds;
    }
}

