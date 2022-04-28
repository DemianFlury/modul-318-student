namespace SwissTransportGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFunktionsauswahl = new System.Windows.Forms.TabControl();
            this.tabPageVerbindungssuche = new System.Windows.Forms.TabPage();
            this.VerbindungsanzeigeDataGridViewTab1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.KarteWebViewTab1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.VerbindungSuchenButtonTab1 = new System.Windows.Forms.Button();
            this.labelAbfahrtszeitTab1 = new System.Windows.Forms.Label();
            this.AbfahrtszeitdateTimePickerTab1 = new System.Windows.Forms.DateTimePicker();
            this.DestinationComboBoxTab1 = new System.Windows.Forms.ComboBox();
            this.AbfahrtsortComboBoxTab1 = new System.Windows.Forms.ComboBox();
            this.labelDestinationTab1 = new System.Windows.Forms.Label();
            this.labelAbfahrtsortTab1 = new System.Windows.Forms.Label();
            this.tabPageAbfahrtstabelle = new System.Windows.Forms.TabPage();
            this.AbfahrtenanzeigeDataGridViewTab2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbfahrtenButtonTab2 = new System.Windows.Forms.Button();
            this.KarteWebViewTab2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.AbfahrtsortComboBoxTab2 = new System.Windows.Forms.ComboBox();
            this.labelAbfahrtsortTab2 = new System.Windows.Forms.Label();
            this.tabPageStationssuche = new System.Windows.Forms.TabPage();
            this.StationsSucheStartenButtonTab3 = new System.Windows.Forms.Button();
            this.AbfahrtenanzeigeDataGridViewTab3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KarteWebViewTab3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.NameDerStationTextBoxTab3 = new System.Windows.Forms.TextBox();
            this.labelStationsnameTab3 = new System.Windows.Forms.Label();
            this.tabFunktionsauswahl.SuspendLayout();
            this.tabPageVerbindungssuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsanzeigeDataGridViewTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab1)).BeginInit();
            this.tabPageAbfahrtstabelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtenanzeigeDataGridViewTab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab2)).BeginInit();
            this.tabPageStationssuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtenanzeigeDataGridViewTab3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFunktionsauswahl
            // 
            this.tabFunktionsauswahl.Controls.Add(this.tabPageVerbindungssuche);
            this.tabFunktionsauswahl.Controls.Add(this.tabPageAbfahrtstabelle);
            this.tabFunktionsauswahl.Controls.Add(this.tabPageStationssuche);
            this.tabFunktionsauswahl.HotTrack = true;
            this.tabFunktionsauswahl.ItemSize = new System.Drawing.Size(152, 20);
            this.tabFunktionsauswahl.Location = new System.Drawing.Point(12, 12);
            this.tabFunktionsauswahl.Name = "tabFunktionsauswahl";
            this.tabFunktionsauswahl.SelectedIndex = 0;
            this.tabFunktionsauswahl.Size = new System.Drawing.Size(890, 526);
            this.tabFunktionsauswahl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabFunktionsauswahl.TabIndex = 5;
            // 
            // tabPageVerbindungssuche
            // 
            this.tabPageVerbindungssuche.Controls.Add(this.VerbindungsanzeigeDataGridViewTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.KarteWebViewTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.VerbindungSuchenButtonTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.labelAbfahrtszeitTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.AbfahrtszeitdateTimePickerTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.DestinationComboBoxTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.AbfahrtsortComboBoxTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.labelDestinationTab1);
            this.tabPageVerbindungssuche.Controls.Add(this.labelAbfahrtsortTab1);
            this.tabPageVerbindungssuche.Location = new System.Drawing.Point(4, 24);
            this.tabPageVerbindungssuche.Name = "tabPageVerbindungssuche";
            this.tabPageVerbindungssuche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerbindungssuche.Size = new System.Drawing.Size(882, 498);
            this.tabPageVerbindungssuche.TabIndex = 0;
            this.tabPageVerbindungssuche.Text = "Verbindungssuche";
            this.tabPageVerbindungssuche.UseVisualStyleBackColor = true;
            // 
            // VerbindungsanzeigeDataGridViewTab1
            // 
            this.VerbindungsanzeigeDataGridViewTab1.AllowUserToAddRows = false;
            this.VerbindungsanzeigeDataGridViewTab1.AllowUserToDeleteRows = false;
            this.VerbindungsanzeigeDataGridViewTab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbindungsanzeigeDataGridViewTab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.VerbindungsanzeigeDataGridViewTab1.Location = new System.Drawing.Point(476, 6);
            this.VerbindungsanzeigeDataGridViewTab1.Name = "VerbindungsanzeigeDataGridViewTab1";
            this.VerbindungsanzeigeDataGridViewTab1.ReadOnly = true;
            this.VerbindungsanzeigeDataGridViewTab1.RowHeadersVisible = false;
            this.VerbindungsanzeigeDataGridViewTab1.RowTemplate.Height = 25;
            this.VerbindungsanzeigeDataGridViewTab1.Size = new System.Drawing.Size(400, 483);
            this.VerbindungsanzeigeDataGridViewTab1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Abfahrtsort";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Destination";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 105F;
            this.Column3.HeaderText = "Abfahrtszeit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Reisedauer";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 65F;
            this.Column5.HeaderText = "Gleis";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Per E-Mail senden";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // KarteWebViewTab1
            // 
            this.KarteWebViewTab1.AllowExternalDrop = true;
            this.KarteWebViewTab1.CreationProperties = null;
            this.KarteWebViewTab1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.KarteWebViewTab1.Location = new System.Drawing.Point(3, 115);
            this.KarteWebViewTab1.Name = "KarteWebViewTab1";
            this.KarteWebViewTab1.Size = new System.Drawing.Size(442, 377);
            this.KarteWebViewTab1.TabIndex = 7;
            this.KarteWebViewTab1.ZoomFactor = 1D;
            // 
            // VerbindungSuchenButtonTab1
            // 
            this.VerbindungSuchenButtonTab1.Location = new System.Drawing.Point(295, 9);
            this.VerbindungSuchenButtonTab1.Name = "VerbindungSuchenButtonTab1";
            this.VerbindungSuchenButtonTab1.Size = new System.Drawing.Size(150, 52);
            this.VerbindungSuchenButtonTab1.TabIndex = 6;
            this.VerbindungSuchenButtonTab1.Text = "Verbindung suchen";
            this.VerbindungSuchenButtonTab1.UseVisualStyleBackColor = true;
            this.VerbindungSuchenButtonTab1.Click += new System.EventHandler(this.VerbindungSuchenButtonTab1_Click);
            // 
            // labelAbfahrtszeitTab1
            // 
            this.labelAbfahrtszeitTab1.AutoSize = true;
            this.labelAbfahrtszeitTab1.Location = new System.Drawing.Point(6, 86);
            this.labelAbfahrtszeitTab1.Name = "labelAbfahrtszeitTab1";
            this.labelAbfahrtszeitTab1.Size = new System.Drawing.Size(73, 15);
            this.labelAbfahrtszeitTab1.TabIndex = 5;
            this.labelAbfahrtszeitTab1.Text = "Abfahrtszeit:";
            // 
            // AbfahrtszeitdateTimePickerTab1
            // 
            this.AbfahrtszeitdateTimePickerTab1.Location = new System.Drawing.Point(79, 77);
            this.AbfahrtszeitdateTimePickerTab1.Name = "AbfahrtszeitdateTimePickerTab1";
            this.AbfahrtszeitdateTimePickerTab1.Size = new System.Drawing.Size(210, 23);
            this.AbfahrtszeitdateTimePickerTab1.TabIndex = 4;
            // 
            // DestinationComboBoxTab1
            // 
            this.DestinationComboBoxTab1.FormattingEnabled = true;
            this.DestinationComboBoxTab1.Location = new System.Drawing.Point(79, 38);
            this.DestinationComboBoxTab1.Name = "DestinationComboBoxTab1";
            this.DestinationComboBoxTab1.Size = new System.Drawing.Size(210, 23);
            this.DestinationComboBoxTab1.TabIndex = 3;
            // 
            // AbfahrtsortComboBoxTab1
            // 
            this.AbfahrtsortComboBoxTab1.FormattingEnabled = true;
            this.AbfahrtsortComboBoxTab1.Location = new System.Drawing.Point(79, 9);
            this.AbfahrtsortComboBoxTab1.Name = "AbfahrtsortComboBoxTab1";
            this.AbfahrtsortComboBoxTab1.Size = new System.Drawing.Size(210, 23);
            this.AbfahrtsortComboBoxTab1.TabIndex = 2;
            this.AbfahrtsortComboBoxTab1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AbfahrtsortComboBoxTab1_KeyUp);
            // 
            // labelDestinationTab1
            // 
            this.labelDestinationTab1.AutoSize = true;
            this.labelDestinationTab1.Location = new System.Drawing.Point(6, 44);
            this.labelDestinationTab1.Name = "labelDestinationTab1";
            this.labelDestinationTab1.Size = new System.Drawing.Size(70, 15);
            this.labelDestinationTab1.TabIndex = 1;
            this.labelDestinationTab1.Text = "Destination:";
            // 
            // labelAbfahrtsortTab1
            // 
            this.labelAbfahrtsortTab1.AutoSize = true;
            this.labelAbfahrtsortTab1.Location = new System.Drawing.Point(6, 15);
            this.labelAbfahrtsortTab1.Name = "labelAbfahrtsortTab1";
            this.labelAbfahrtsortTab1.Size = new System.Drawing.Size(70, 15);
            this.labelAbfahrtsortTab1.TabIndex = 0;
            this.labelAbfahrtsortTab1.Text = "Abfahrtsort:";
            // 
            // tabPageAbfahrtstabelle
            // 
            this.tabPageAbfahrtstabelle.Controls.Add(this.AbfahrtenanzeigeDataGridViewTab2);
            this.tabPageAbfahrtstabelle.Controls.Add(this.AbfahrtenButtonTab2);
            this.tabPageAbfahrtstabelle.Controls.Add(this.KarteWebViewTab2);
            this.tabPageAbfahrtstabelle.Controls.Add(this.AbfahrtsortComboBoxTab2);
            this.tabPageAbfahrtstabelle.Controls.Add(this.labelAbfahrtsortTab2);
            this.tabPageAbfahrtstabelle.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbfahrtstabelle.Name = "tabPageAbfahrtstabelle";
            this.tabPageAbfahrtstabelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbfahrtstabelle.Size = new System.Drawing.Size(882, 498);
            this.tabPageAbfahrtstabelle.TabIndex = 1;
            this.tabPageAbfahrtstabelle.Text = "Abfahrtstabelle";
            this.tabPageAbfahrtstabelle.UseVisualStyleBackColor = true;
            // 
            // AbfahrtenanzeigeDataGridViewTab2
            // 
            this.AbfahrtenanzeigeDataGridViewTab2.AllowUserToAddRows = false;
            this.AbfahrtenanzeigeDataGridViewTab2.AllowUserToDeleteRows = false;
            this.AbfahrtenanzeigeDataGridViewTab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtenanzeigeDataGridViewTab2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.AbfahrtenanzeigeDataGridViewTab2.Location = new System.Drawing.Point(476, 6);
            this.AbfahrtenanzeigeDataGridViewTab2.Name = "AbfahrtenanzeigeDataGridViewTab2";
            this.AbfahrtenanzeigeDataGridViewTab2.ReadOnly = true;
            this.AbfahrtenanzeigeDataGridViewTab2.RowHeadersVisible = false;
            this.AbfahrtenanzeigeDataGridViewTab2.RowTemplate.Height = 25;
            this.AbfahrtenanzeigeDataGridViewTab2.Size = new System.Drawing.Size(400, 486);
            this.AbfahrtenanzeigeDataGridViewTab2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Abfahrtsort";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Abfahrtszeit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // AbfahrtenButtonTab2
            // 
            this.AbfahrtenButtonTab2.Location = new System.Drawing.Point(295, 6);
            this.AbfahrtenButtonTab2.Name = "AbfahrtenButtonTab2";
            this.AbfahrtenButtonTab2.Size = new System.Drawing.Size(150, 26);
            this.AbfahrtenButtonTab2.TabIndex = 9;
            this.AbfahrtenButtonTab2.Text = "Abfahrten anzeigen";
            this.AbfahrtenButtonTab2.UseVisualStyleBackColor = true;
            this.AbfahrtenButtonTab2.Click += new System.EventHandler(this.AbfahrtenButtonTab2_Click);
            // 
            // KarteWebViewTab2
            // 
            this.KarteWebViewTab2.AllowExternalDrop = true;
            this.KarteWebViewTab2.CreationProperties = null;
            this.KarteWebViewTab2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.KarteWebViewTab2.Location = new System.Drawing.Point(3, 38);
            this.KarteWebViewTab2.Name = "KarteWebViewTab2";
            this.KarteWebViewTab2.Size = new System.Drawing.Size(442, 454);
            this.KarteWebViewTab2.TabIndex = 8;
            this.KarteWebViewTab2.ZoomFactor = 1D;
            // 
            // AbfahrtsortComboBoxTab2
            // 
            this.AbfahrtsortComboBoxTab2.FormattingEnabled = true;
            this.AbfahrtsortComboBoxTab2.Location = new System.Drawing.Point(79, 9);
            this.AbfahrtsortComboBoxTab2.Name = "AbfahrtsortComboBoxTab2";
            this.AbfahrtsortComboBoxTab2.Size = new System.Drawing.Size(210, 23);
            this.AbfahrtsortComboBoxTab2.TabIndex = 4;
            // 
            // labelAbfahrtsortTab2
            // 
            this.labelAbfahrtsortTab2.AutoSize = true;
            this.labelAbfahrtsortTab2.Location = new System.Drawing.Point(6, 15);
            this.labelAbfahrtsortTab2.Name = "labelAbfahrtsortTab2";
            this.labelAbfahrtsortTab2.Size = new System.Drawing.Size(70, 15);
            this.labelAbfahrtsortTab2.TabIndex = 3;
            this.labelAbfahrtsortTab2.Text = "Abfahrtsort:";
            // 
            // tabPageStationssuche
            // 
            this.tabPageStationssuche.Controls.Add(this.StationsSucheStartenButtonTab3);
            this.tabPageStationssuche.Controls.Add(this.AbfahrtenanzeigeDataGridViewTab3);
            this.tabPageStationssuche.Controls.Add(this.KarteWebViewTab3);
            this.tabPageStationssuche.Controls.Add(this.NameDerStationTextBoxTab3);
            this.tabPageStationssuche.Controls.Add(this.labelStationsnameTab3);
            this.tabPageStationssuche.Location = new System.Drawing.Point(4, 24);
            this.tabPageStationssuche.Name = "tabPageStationssuche";
            this.tabPageStationssuche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStationssuche.Size = new System.Drawing.Size(882, 498);
            this.tabPageStationssuche.TabIndex = 2;
            this.tabPageStationssuche.Text = "Stationssuche";
            this.tabPageStationssuche.UseVisualStyleBackColor = true;
            // 
            // StationsSucheStartenButtonTab3
            // 
            this.StationsSucheStartenButtonTab3.Location = new System.Drawing.Point(295, 38);
            this.StationsSucheStartenButtonTab3.Name = "StationsSucheStartenButtonTab3";
            this.StationsSucheStartenButtonTab3.Size = new System.Drawing.Size(150, 26);
            this.StationsSucheStartenButtonTab3.TabIndex = 10;
            this.StationsSucheStartenButtonTab3.Text = "Suche starten";
            this.StationsSucheStartenButtonTab3.UseVisualStyleBackColor = true;
            this.StationsSucheStartenButtonTab3.Click += new System.EventHandler(this.StationsSucheStartenButtonTab3_Click);
            // 
            // AbfahrtenanzeigeDataGridViewTab3
            // 
            this.AbfahrtenanzeigeDataGridViewTab3.AllowUserToAddRows = false;
            this.AbfahrtenanzeigeDataGridViewTab3.AllowUserToDeleteRows = false;
            this.AbfahrtenanzeigeDataGridViewTab3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AbfahrtenanzeigeDataGridViewTab3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.AbfahrtenanzeigeDataGridViewTab3.Location = new System.Drawing.Point(476, 6);
            this.AbfahrtenanzeigeDataGridViewTab3.Name = "AbfahrtenanzeigeDataGridViewTab3";
            this.AbfahrtenanzeigeDataGridViewTab3.ReadOnly = true;
            this.AbfahrtenanzeigeDataGridViewTab3.RowHeadersVisible = false;
            this.AbfahrtenanzeigeDataGridViewTab3.RowTemplate.Height = 25;
            this.AbfahrtenanzeigeDataGridViewTab3.Size = new System.Drawing.Size(400, 486);
            this.AbfahrtenanzeigeDataGridViewTab3.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Abfahrtsort";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Abfahrtszeit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // KarteWebViewTab3
            // 
            this.KarteWebViewTab3.AllowExternalDrop = true;
            this.KarteWebViewTab3.CreationProperties = null;
            this.KarteWebViewTab3.DefaultBackgroundColor = System.Drawing.Color.White;
            this.KarteWebViewTab3.Location = new System.Drawing.Point(3, 82);
            this.KarteWebViewTab3.Name = "KarteWebViewTab3";
            this.KarteWebViewTab3.Size = new System.Drawing.Size(442, 410);
            this.KarteWebViewTab3.TabIndex = 8;
            this.KarteWebViewTab3.ZoomFactor = 1D;
            // 
            // NameDerStationTextBoxTab3
            // 
            this.NameDerStationTextBoxTab3.Location = new System.Drawing.Point(162, 9);
            this.NameDerStationTextBoxTab3.Name = "NameDerStationTextBoxTab3";
            this.NameDerStationTextBoxTab3.ReadOnly = true;
            this.NameDerStationTextBoxTab3.Size = new System.Drawing.Size(283, 23);
            this.NameDerStationTextBoxTab3.TabIndex = 1;
            // 
            // labelStationsnameTab3
            // 
            this.labelStationsnameTab3.AutoSize = true;
            this.labelStationsnameTab3.Location = new System.Drawing.Point(6, 15);
            this.labelStationsnameTab3.Name = "labelStationsnameTab3";
            this.labelStationsnameTab3.Size = new System.Drawing.Size(153, 15);
            this.labelStationsnameTab3.TabIndex = 0;
            this.labelStationsnameTab3.Text = "Name der nächsten Station:";
            // 
            // Form1
            // 
            this.AcceptButton = this.VerbindungSuchenButtonTab1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 547);
            this.Controls.Add(this.tabFunktionsauswahl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabFunktionsauswahl.ResumeLayout(false);
            this.tabPageVerbindungssuche.ResumeLayout(false);
            this.tabPageVerbindungssuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerbindungsanzeigeDataGridViewTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab1)).EndInit();
            this.tabPageAbfahrtstabelle.ResumeLayout(false);
            this.tabPageAbfahrtstabelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtenanzeigeDataGridViewTab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab2)).EndInit();
            this.tabPageStationssuche.ResumeLayout(false);
            this.tabPageStationssuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbfahrtenanzeigeDataGridViewTab3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KarteWebViewTab3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabFunktionsauswahl;
        private TabPage tabPageVerbindungssuche;
        private DataGridView VerbindungsanzeigeDataGridViewTab1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private Microsoft.Web.WebView2.WinForms.WebView2 KarteWebViewTab1;
        private Button VerbindungSuchenButtonTab1;
        private Label labelAbfahrtszeitTab1;
        private DateTimePicker AbfahrtszeitdateTimePickerTab1;
        private ComboBox DestinationComboBoxTab1;
        private ComboBox AbfahrtsortComboBoxTab1;
        private Label labelDestinationTab1;
        private Label labelAbfahrtsortTab1;
        private TabPage tabPageAbfahrtstabelle;
        private Button AbfahrtenButtonTab2;
        private Microsoft.Web.WebView2.WinForms.WebView2 KarteWebViewTab2;
        private ComboBox AbfahrtsortComboBoxTab2;
        private Label labelAbfahrtsortTab2;
        private TabPage tabPageStationssuche;
        private Microsoft.Web.WebView2.WinForms.WebView2 KarteWebViewTab3;
        private TextBox NameDerStationTextBoxTab3;
        private Label labelStationsnameTab3;
        private DataGridView AbfahrtenanzeigeDataGridViewTab2;
        private DataGridView AbfahrtenanzeigeDataGridViewTab3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button StationsSucheStartenButtonTab3;
    }
}