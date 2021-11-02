
namespace Grupp_28_RSS
{
    partial class FrmAvsnitt
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
            this.lbxKategorier = new System.Windows.Forms.ListBox();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.lvFeed = new System.Windows.Forms.ListView();
            this.colFeedAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedIntervall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFeedSenastUppdaterad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitelDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.colAvsnittNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvsnittTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNyPodcastNamn = new System.Windows.Forms.Label();
            this.txtPodcastName = new System.Windows.Forms.TextBox();
            this.txtNyKategori = new System.Windows.Forms.TextBox();
            this.lbNyPodcastKategori = new System.Windows.Forms.Label();
            this.lbNyPodcastIntervall = new System.Windows.Forms.Label();
            this.lbNyPodcastUrl = new System.Windows.Forms.Label();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnAndraNamnKategori = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnUppdateraFeed = new System.Windows.Forms.Button();
            this.btnLaggTillURL = new System.Windows.Forms.Button();
            this.txtRSSURL = new System.Windows.Forms.TextBox();
            this.cmbIntervall = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.tabReader = new System.Windows.Forms.TabControl();
            this.tabPageNewsReader = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxNewsReaderKategori = new System.Windows.Forms.ListBox();
            this.tabPageNewsManager = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUppdateradKategori = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUppdateradIntervall = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUppdateradPodcastNamn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxPodcastToChange = new System.Windows.Forms.ListBox();
            this.lbxPodcastToDelete = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageKategoriManager = new System.Windows.Forms.TabPage();
            this.timerX = new System.Windows.Forms.Timer(this.components);
            this.tabReader.SuspendLayout();
            this.tabPageNewsReader.SuspendLayout();
            this.tabPageNewsManager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageKategoriManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxKategorier
            // 
            this.lbxKategorier.FormattingEnabled = true;
            this.lbxKategorier.Items.AddRange(new object[] {
            "TestKategori1",
            "TestKategori2",
            "TestKategori3"});
            this.lbxKategorier.Location = new System.Drawing.Point(26, 101);
            this.lbxKategorier.Name = "lbxKategorier";
            this.lbxKategorier.Size = new System.Drawing.Size(252, 173);
            this.lbxKategorier.TabIndex = 0;
            this.lbxKategorier.SelectedIndexChanged += new System.EventHandler(this.lbxKategorier_SelectedIndexChanged);
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Location = new System.Drawing.Point(539, 19);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(39, 13);
            this.lblAvsnitt.TabIndex = 3;
            this.lblAvsnitt.Text = "Avsnitt";
            // 
            // lvFeed
            // 
            this.lvFeed.AllowColumnReorder = true;
            this.lvFeed.BackColor = System.Drawing.SystemColors.Window;
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFeedAvsnitt,
            this.colFeedNamn,
            this.colFeedIntervall,
            this.colFeedKategori,
            this.colFeedSenastUppdaterad});
            this.lvFeed.FullRowSelect = true;
            this.lvFeed.GridLines = true;
            this.lvFeed.HideSelection = false;
            this.lvFeed.Location = new System.Drawing.Point(127, 35);
            this.lvFeed.MultiSelect = false;
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(412, 285);
            this.lvFeed.TabIndex = 7;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            this.lvFeed.SelectedIndexChanged += new System.EventHandler(this.lvFeed_SelectedIndexChanged);
            // 
            // colFeedAvsnitt
            // 
            this.colFeedAvsnitt.Text = "Avsnitt";
            this.colFeedAvsnitt.Width = 35;
            // 
            // colFeedNamn
            // 
            this.colFeedNamn.Text = "Namn";
            this.colFeedNamn.Width = 140;
            // 
            // colFeedIntervall
            // 
            this.colFeedIntervall.Text = "Uppdateringsintervall";
            this.colFeedIntervall.Width = 30;
            // 
            // colFeedKategori
            // 
            this.colFeedKategori.Text = "Kategori";
            this.colFeedKategori.Width = 80;
            // 
            // colFeedSenastUppdaterad
            // 
            this.colFeedSenastUppdaterad.Text = "Senast uppdaterad";
            this.colFeedSenastUppdaterad.Width = 110;
            // 
            // lblTitelDescription
            // 
            this.lblTitelDescription.AutoSize = true;
            this.lblTitelDescription.Location = new System.Drawing.Point(6, 333);
            this.lblTitelDescription.Name = "lblTitelDescription";
            this.lblTitelDescription.Size = new System.Drawing.Size(38, 13);
            this.lblTitelDescription.TabIndex = 17;
            this.lblTitelDescription.Text = "Nyhet:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(6, 349);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(964, 255);
            this.txtDescription.TabIndex = 18;
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Location = new System.Drawing.Point(23, 85);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(55, 13);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Kategorier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Podcasts:";
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.AllowColumnReorder = true;
            this.lvAvsnitt.AllowDrop = true;
            this.lvAvsnitt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAvsnittNr,
            this.colAvsnittTitel});
            this.lvAvsnitt.FullRowSelect = true;
            this.lvAvsnitt.GridLines = true;
            this.lvAvsnitt.HideSelection = false;
            this.lvAvsnitt.LabelEdit = true;
            this.lvAvsnitt.Location = new System.Drawing.Point(545, 35);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(425, 285);
            this.lvAvsnitt.TabIndex = 25;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.View = System.Windows.Forms.View.Details;
            this.lvAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lvAvsnitt_SelectedIndexChanged);
            // 
            // colAvsnittNr
            // 
            this.colAvsnittNr.Text = "#";
            this.colAvsnittNr.Width = 25;
            // 
            // colAvsnittTitel
            // 
            this.colAvsnittTitel.Text = "Titel";
            this.colAvsnittTitel.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kategoriadmin";
            // 
            // lblNyPodcastNamn
            // 
            this.lblNyPodcastNamn.AutoSize = true;
            this.lblNyPodcastNamn.Location = new System.Drawing.Point(3, 67);
            this.lblNyPodcastNamn.Name = "lblNyPodcastNamn";
            this.lblNyPodcastNamn.Size = new System.Drawing.Size(38, 13);
            this.lblNyPodcastNamn.TabIndex = 40;
            this.lblNyPodcastNamn.Text = "Namn:";
            // 
            // txtPodcastName
            // 
            this.txtPodcastName.Location = new System.Drawing.Point(6, 83);
            this.txtPodcastName.Name = "txtPodcastName";
            this.txtPodcastName.Size = new System.Drawing.Size(310, 20);
            this.txtPodcastName.TabIndex = 39;
            // 
            // txtNyKategori
            // 
            this.txtNyKategori.Location = new System.Drawing.Point(26, 43);
            this.txtNyKategori.Name = "txtNyKategori";
            this.txtNyKategori.Size = new System.Drawing.Size(150, 20);
            this.txtNyKategori.TabIndex = 38;
            // 
            // lbNyPodcastKategori
            // 
            this.lbNyPodcastKategori.AutoSize = true;
            this.lbNyPodcastKategori.Location = new System.Drawing.Point(169, 106);
            this.lbNyPodcastKategori.Name = "lbNyPodcastKategori";
            this.lbNyPodcastKategori.Size = new System.Drawing.Size(49, 13);
            this.lbNyPodcastKategori.TabIndex = 37;
            this.lbNyPodcastKategori.Text = "Kategori:";
            // 
            // lbNyPodcastIntervall
            // 
            this.lbNyPodcastIntervall.AutoSize = true;
            this.lbNyPodcastIntervall.Location = new System.Drawing.Point(3, 106);
            this.lbNyPodcastIntervall.Name = "lbNyPodcastIntervall";
            this.lbNyPodcastIntervall.Size = new System.Drawing.Size(47, 13);
            this.lbNyPodcastIntervall.TabIndex = 36;
            this.lbNyPodcastIntervall.Text = "Intervall:";
            // 
            // lbNyPodcastUrl
            // 
            this.lbNyPodcastUrl.AutoSize = true;
            this.lbNyPodcastUrl.Location = new System.Drawing.Point(3, 28);
            this.lbNyPodcastUrl.Name = "lbNyPodcastUrl";
            this.lbNyPodcastUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNyPodcastUrl.Size = new System.Drawing.Size(32, 13);
            this.lbNyPodcastUrl.TabIndex = 35;
            this.lbNyPodcastUrl.Text = "URL:";
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(215, 39);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(27, 23);
            this.btnTaBortKategori.TabIndex = 34;
            this.btnTaBortKategori.Text = "✖";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillKategori.Location = new System.Drawing.Point(182, 39);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(27, 23);
            this.btnLaggTillKategori.TabIndex = 33;
            this.btnLaggTillKategori.Text = "➕";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // btnAndraNamnKategori
            // 
            this.btnAndraNamnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndraNamnKategori.Location = new System.Drawing.Point(251, 40);
            this.btnAndraNamnKategori.Name = "btnAndraNamnKategori";
            this.btnAndraNamnKategori.Size = new System.Drawing.Size(27, 23);
            this.btnAndraNamnKategori.TabIndex = 32;
            this.btnAndraNamnKategori.Text = "/";
            this.btnAndraNamnKategori.UseVisualStyleBackColor = true;
            this.btnAndraNamnKategori.Click += new System.EventHandler(this.btnAndraNamnKategori_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTaBort.Enabled = false;
            this.btnTaBort.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBort.Location = new System.Drawing.Point(341, 458);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(100, 100);
            this.btnTaBort.TabIndex = 31;
            this.btnTaBort.Text = "👎";
            this.btnTaBort.UseVisualStyleBackColor = false;
            this.btnTaBort.Click += new System.EventHandler(this.btnTaBort_Click);
            // 
            // btnUppdateraFeed
            // 
            this.btnUppdateraFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUppdateraFeed.Enabled = false;
            this.btnUppdateraFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUppdateraFeed.Location = new System.Drawing.Point(341, 254);
            this.btnUppdateraFeed.Name = "btnUppdateraFeed";
            this.btnUppdateraFeed.Size = new System.Drawing.Size(100, 100);
            this.btnUppdateraFeed.TabIndex = 30;
            this.btnUppdateraFeed.Text = "❤";
            this.btnUppdateraFeed.UseVisualStyleBackColor = false;
            this.btnUppdateraFeed.Click += new System.EventHandler(this.btnUppdateraFeed_Click);
            // 
            // btnLaggTillURL
            // 
            this.btnLaggTillURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLaggTillURL.Enabled = false;
            this.btnLaggTillURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaggTillURL.Location = new System.Drawing.Point(322, 44);
            this.btnLaggTillURL.Name = "btnLaggTillURL";
            this.btnLaggTillURL.Size = new System.Drawing.Size(100, 100);
            this.btnLaggTillURL.TabIndex = 29;
            this.btnLaggTillURL.Text = "👍";
            this.btnLaggTillURL.UseVisualStyleBackColor = false;
            this.btnLaggTillURL.Click += new System.EventHandler(this.btnLaggTillURL_Click);
            // 
            // txtRSSURL
            // 
            this.txtRSSURL.Location = new System.Drawing.Point(6, 44);
            this.txtRSSURL.Name = "txtRSSURL";
            this.txtRSSURL.Size = new System.Drawing.Size(310, 20);
            this.txtRSSURL.TabIndex = 28;
            this.txtRSSURL.Text = "https://www.svt.se/nyheter/rss.xml";
            this.txtRSSURL.TextChanged += new System.EventHandler(this.txtRSSURL_TextChanged);
            // 
            // cmbIntervall
            // 
            this.cmbIntervall.FormattingEnabled = true;
            this.cmbIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbIntervall.Location = new System.Drawing.Point(6, 122);
            this.cmbIntervall.Name = "cmbIntervall";
            this.cmbIntervall.Size = new System.Drawing.Size(157, 21);
            this.cmbIntervall.TabIndex = 27;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(169, 122);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(147, 21);
            this.cmbKategori.Sorted = true;
            this.cmbKategori.TabIndex = 26;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // tabReader
            // 
            this.tabReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabReader.Controls.Add(this.tabPageNewsReader);
            this.tabReader.Controls.Add(this.tabPageNewsManager);
            this.tabReader.Controls.Add(this.tabPageKategoriManager);
            this.tabReader.Location = new System.Drawing.Point(12, 12);
            this.tabReader.Name = "tabReader";
            this.tabReader.SelectedIndex = 0;
            this.tabReader.Size = new System.Drawing.Size(984, 637);
            this.tabReader.TabIndex = 0;
            // 
            // tabPageNewsReader
            // 
            this.tabPageNewsReader.Controls.Add(this.txtStatus);
            this.tabPageNewsReader.Controls.Add(this.label4);
            this.tabPageNewsReader.Controls.Add(this.lbxNewsReaderKategori);
            this.tabPageNewsReader.Controls.Add(this.lblTitelDescription);
            this.tabPageNewsReader.Controls.Add(this.txtDescription);
            this.tabPageNewsReader.Controls.Add(this.lvAvsnitt);
            this.tabPageNewsReader.Controls.Add(this.lblAvsnitt);
            this.tabPageNewsReader.Controls.Add(this.label2);
            this.tabPageNewsReader.Controls.Add(this.lvFeed);
            this.tabPageNewsReader.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewsReader.Name = "tabPageNewsReader";
            this.tabPageNewsReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewsReader.Size = new System.Drawing.Size(976, 611);
            this.tabPageNewsReader.TabIndex = 0;
            this.tabPageNewsReader.Text = "News Reader";
            this.tabPageNewsReader.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(6, 162);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(115, 158);
            this.txtStatus.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kategorier:";
            // 
            // lbxNewsReaderKategori
            // 
            this.lbxNewsReaderKategori.FormattingEnabled = true;
            this.lbxNewsReaderKategori.Items.AddRange(new object[] {
            "TestKategori1",
            "TestKategori2",
            "TestKategori3"});
            this.lbxNewsReaderKategori.Location = new System.Drawing.Point(6, 35);
            this.lbxNewsReaderKategori.Name = "lbxNewsReaderKategori";
            this.lbxNewsReaderKategori.Size = new System.Drawing.Size(115, 121);
            this.lbxNewsReaderKategori.TabIndex = 27;
            this.lbxNewsReaderKategori.SelectedIndexChanged += new System.EventHandler(this.lbxNewsReaderKategori_SelectedIndexChanged);
            // 
            // tabPageNewsManager
            // 
            this.tabPageNewsManager.Controls.Add(this.groupBox1);
            this.tabPageNewsManager.Controls.Add(this.label10);
            this.tabPageNewsManager.Controls.Add(this.cmbUppdateradKategori);
            this.tabPageNewsManager.Controls.Add(this.label9);
            this.tabPageNewsManager.Controls.Add(this.cmbUppdateradIntervall);
            this.tabPageNewsManager.Controls.Add(this.label8);
            this.tabPageNewsManager.Controls.Add(this.txtUppdateradPodcastNamn);
            this.tabPageNewsManager.Controls.Add(this.label7);
            this.tabPageNewsManager.Controls.Add(this.lbxPodcastToChange);
            this.tabPageNewsManager.Controls.Add(this.lbxPodcastToDelete);
            this.tabPageNewsManager.Controls.Add(this.label5);
            this.tabPageNewsManager.Controls.Add(this.btnTaBort);
            this.tabPageNewsManager.Controls.Add(this.btnUppdateraFeed);
            this.tabPageNewsManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewsManager.Name = "tabPageNewsManager";
            this.tabPageNewsManager.Size = new System.Drawing.Size(976, 611);
            this.tabPageNewsManager.TabIndex = 2;
            this.tabPageNewsManager.Text = "News Manager";
            this.tabPageNewsManager.UseVisualStyleBackColor = true;
            this.tabPageNewsManager.Click += new System.EventHandler(this.tabPageNewsManager_Click);
            this.tabPageNewsManager.Enter += new System.EventHandler(this.tabPageNewsManager_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRSSURL);
            this.groupBox1.Controls.Add(this.lbNyPodcastKategori);
            this.groupBox1.Controls.Add(this.lbNyPodcastIntervall);
            this.groupBox1.Controls.Add(this.lblNyPodcastNamn);
            this.groupBox1.Controls.Add(this.btnLaggTillURL);
            this.groupBox1.Controls.Add(this.lbNyPodcastUrl);
            this.groupBox1.Controls.Add(this.cmbIntervall);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.txtPodcastName);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 160);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg till Podcast";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 229);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Uppdatera Feed:";
            // 
            // cmbUppdateradKategori
            // 
            this.cmbUppdateradKategori.FormattingEnabled = true;
            this.cmbUppdateradKategori.Location = new System.Drawing.Point(151, 333);
            this.cmbUppdateradKategori.Name = "cmbUppdateradKategori";
            this.cmbUppdateradKategori.Size = new System.Drawing.Size(184, 21);
            this.cmbUppdateradKategori.Sorted = true;
            this.cmbUppdateradKategori.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Ny Kategori:";
            // 
            // cmbUppdateradIntervall
            // 
            this.cmbUppdateradIntervall.FormattingEnabled = true;
            this.cmbUppdateradIntervall.Items.AddRange(new object[] {
            "var 1 minut",
            "var 5 minuter",
            "var 10 minter"});
            this.cmbUppdateradIntervall.Location = new System.Drawing.Point(151, 293);
            this.cmbUppdateradIntervall.Name = "cmbUppdateradIntervall";
            this.cmbUppdateradIntervall.Size = new System.Drawing.Size(184, 21);
            this.cmbUppdateradIntervall.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ny Intervall:";
            // 
            // txtUppdateradPodcastNamn
            // 
            this.txtUppdateradPodcastNamn.Location = new System.Drawing.Point(151, 254);
            this.txtUppdateradPodcastNamn.Name = "txtUppdateradPodcastNamn";
            this.txtUppdateradPodcastNamn.Size = new System.Drawing.Size(184, 20);
            this.txtUppdateradPodcastNamn.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ny namn:";
            // 
            // lbxPodcastToChange
            // 
            this.lbxPodcastToChange.FormattingEnabled = true;
            this.lbxPodcastToChange.Location = new System.Drawing.Point(25, 245);
            this.lbxPodcastToChange.Name = "lbxPodcastToChange";
            this.lbxPodcastToChange.Size = new System.Drawing.Size(120, 108);
            this.lbxPodcastToChange.TabIndex = 45;
            this.lbxPodcastToChange.SelectedIndexChanged += new System.EventHandler(this.lbxPodcastToChange_SelectedIndexChanged);
            // 
            // lbxPodcastToDelete
            // 
            this.lbxPodcastToDelete.FormattingEnabled = true;
            this.lbxPodcastToDelete.Location = new System.Drawing.Point(25, 463);
            this.lbxPodcastToDelete.Name = "lbxPodcastToDelete";
            this.lbxPodcastToDelete.Size = new System.Drawing.Size(310, 95);
            this.lbxPodcastToDelete.TabIndex = 43;
            this.lbxPodcastToDelete.SelectedIndexChanged += new System.EventHandler(this.lbxPodcastToDelete_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 447);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ta bort Feed";
            // 
            // tabPageKategoriManager
            // 
            this.tabPageKategoriManager.Controls.Add(this.label1);
            this.tabPageKategoriManager.Controls.Add(this.txtNyKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnTaBortKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnLaggTillKategori);
            this.tabPageKategoriManager.Controls.Add(this.lbxKategorier);
            this.tabPageKategoriManager.Controls.Add(this.lblNyKategori);
            this.tabPageKategoriManager.Controls.Add(this.btnAndraNamnKategori);
            this.tabPageKategoriManager.Location = new System.Drawing.Point(4, 22);
            this.tabPageKategoriManager.Name = "tabPageKategoriManager";
            this.tabPageKategoriManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKategoriManager.Size = new System.Drawing.Size(976, 611);
            this.tabPageKategoriManager.TabIndex = 1;
            this.tabPageKategoriManager.Text = "Kategori manager";
            this.tabPageKategoriManager.UseVisualStyleBackColor = true;
            // 
            // timerX
            // 
            this.timerX.Tick += new System.EventHandler(this.timerX_Tick);
            // 
            // FrmAvsnitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tabReader);
            this.Name = "FrmAvsnitt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Really Simple Syndication by Grupp 28 ";
            this.Load += new System.EventHandler(this.FrmAvsnitt_Load);
            this.tabReader.ResumeLayout(false);
            this.tabPageNewsReader.ResumeLayout(false);
            this.tabPageNewsReader.PerformLayout();
            this.tabPageNewsManager.ResumeLayout(false);
            this.tabPageNewsManager.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageKategoriManager.ResumeLayout(false);
            this.tabPageKategoriManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxKategorier;
        private System.Windows.Forms.Label lblAvsnitt;
        private System.Windows.Forms.ListView lvFeed;
        private System.Windows.Forms.ColumnHeader colFeedAvsnitt;
        private System.Windows.Forms.ColumnHeader colFeedNamn;
        private System.Windows.Forms.ColumnHeader colFeedIntervall;
        private System.Windows.Forms.ColumnHeader colFeedKategori;
        private System.Windows.Forms.Label lblTitelDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.ColumnHeader colAvsnittNr;
        private System.Windows.Forms.ColumnHeader colAvsnittTitel;
        private System.Windows.Forms.ColumnHeader colFeedSenastUppdaterad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNyPodcastNamn;
        private System.Windows.Forms.TextBox txtPodcastName;
        private System.Windows.Forms.TextBox txtNyKategori;
        private System.Windows.Forms.Label lbNyPodcastKategori;
        private System.Windows.Forms.Label lbNyPodcastIntervall;
        private System.Windows.Forms.Label lbNyPodcastUrl;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnAndraNamnKategori;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnUppdateraFeed;
        private System.Windows.Forms.Button btnLaggTillURL;
        private System.Windows.Forms.TextBox txtRSSURL;
        private System.Windows.Forms.ComboBox cmbIntervall;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TabControl tabReader;
        private System.Windows.Forms.TabPage tabPageNewsReader;
        private System.Windows.Forms.TabPage tabPageKategoriManager;
        private System.Windows.Forms.TabPage tabPageNewsManager;
        private System.Windows.Forms.ListBox lbxNewsReaderKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxPodcastToDelete;
        private System.Windows.Forms.ListBox lbxPodcastToChange;
        private System.Windows.Forms.ComboBox cmbUppdateradKategori;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUppdateradIntervall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUppdateradPodcastNamn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerX;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

