namespace TransportnaApp.Forme
{
    partial class ZaposleniciFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniciFrm));
            this.btnNazad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.dtDatumRod = new System.Windows.Forms.DateTimePicker();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOib = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbGreskaoOib = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTablica = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DarkGray;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnNazad.Image")));
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(935, 766);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(200, 65);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.btnSpremi);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(35, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 650);
            this.panel1.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnObrisi.Image = ((System.Drawing.Image)(resources.GetObject("btnObrisi.Image")));
            this.btnObrisi.Location = new System.Drawing.Point(30, 550);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(130, 65);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Visible = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSpremi.Image = ((System.Drawing.Image)(resources.GetObject("btnSpremi.Image")));
            this.btnSpremi.Location = new System.Drawing.Point(200, 550);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(130, 65);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.52778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.47222F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtDatumRod, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbOib, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbTip, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // tbIme
            // 
            this.tbIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbIme.Location = new System.Drawing.Point(142, 10);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(155, 22);
            this.tbIme.TabIndex = 2;
            // 
            // dtDatumRod
            // 
            this.dtDatumRod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDatumRod.Location = new System.Drawing.Point(142, 198);
            this.dtDatumRod.Name = "dtDatumRod";
            this.dtDatumRod.Size = new System.Drawing.Size(155, 22);
            this.dtDatumRod.TabIndex = 7;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrezime.Location = new System.Drawing.Point(142, 58);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(155, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oib";
            // 
            // tbOib
            // 
            this.tbOib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbOib.Location = new System.Drawing.Point(142, 107);
            this.tbOib.Name = "tbOib";
            this.tbOib.Size = new System.Drawing.Size(155, 22);
            this.tbOib.TabIndex = 6;
            this.tbOib.Leave += new System.EventHandler(this.tbOib_Leave);
            // 
            // cbTip
            // 
            this.cbTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(142, 153);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(155, 24);
            this.cbTip.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(49, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tip";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum:";
            // 
            // lbGreskaoOib
            // 
            this.lbGreskaoOib.AutoSize = true;
            this.lbGreskaoOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreskaoOib.ForeColor = System.Drawing.Color.Red;
            this.lbGreskaoOib.Location = new System.Drawing.Point(60, 778);
            this.lbGreskaoOib.Name = "lbGreskaoOib";
            this.lbGreskaoOib.Size = new System.Drawing.Size(252, 38);
            this.lbGreskaoOib.TabIndex = 7;
            this.lbGreskaoOib.Text = "Neispravan Oib!";
            this.lbGreskaoOib.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvTablica);
            this.panel2.Location = new System.Drawing.Point(423, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 650);
            this.panel2.TabIndex = 2;
            // 
            // dgvTablica
            // 
            this.dgvTablica.AllowUserToAddRows = false;
            this.dgvTablica.AllowUserToDeleteRows = false;
            this.dgvTablica.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablica.Location = new System.Drawing.Point(-2, -2);
            this.dgvTablica.MultiSelect = false;
            this.dgvTablica.Name = "dgvTablica";
            this.dgvTablica.ReadOnly = true;
            this.dgvTablica.RowTemplate.Height = 24;
            this.dgvTablica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablica.Size = new System.Drawing.Size(710, 650);
            this.dgvTablica.TabIndex = 0;
            this.dgvTablica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablica_RedakSelektiran);
            this.dgvTablica.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTablica_DataBindingComplete);
            // 
            // ZaposleniciFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.lbGreskaoOib);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNazad);
            this.Name = "ZaposleniciFrm";
            this.Text = "ZaposleniciFrm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTablica;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOib;
        private System.Windows.Forms.DateTimePicker dtDatumRod;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbGreskaoOib;
    }
}