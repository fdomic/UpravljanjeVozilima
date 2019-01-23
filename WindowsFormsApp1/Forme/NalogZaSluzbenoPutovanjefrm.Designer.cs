namespace TransportnaApp.Forme
{
    partial class NalogZaSluzbenoPutovanjefrm
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
            this.btNazad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBrisi = new System.Windows.Forms.Button();
            this.btSpremi = new System.Windows.Forms.Button();
            this.tbRazlog = new System.Windows.Forms.TextBox();
            this.lbRazlog = new System.Windows.Forms.Label();
            this.tbTeret = new System.Windows.Forms.TextBox();
            this.lbTeret = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTablica = new System.Windows.Forms.DataGridView();
            this.lbGreska = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBRNaloga = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // btNazad
            // 
            this.btNazad.Location = new System.Drawing.Point(957, 738);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(145, 74);
            this.btNazad.TabIndex = 0;
            this.btNazad.Text = "Nazad";
            this.btNazad.UseVisualStyleBackColor = true;
            this.btNazad.Click += new System.EventHandler(this.btNazad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbBRNaloga);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btBrisi);
            this.panel1.Controls.Add(this.btSpremi);
            this.panel1.Controls.Add(this.tbRazlog);
            this.panel1.Controls.Add(this.lbRazlog);
            this.panel1.Controls.Add(this.tbTeret);
            this.panel1.Controls.Add(this.lbTeret);
            this.panel1.Location = new System.Drawing.Point(28, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 637);
            this.panel1.TabIndex = 1;
            // 
            // btBrisi
            // 
            this.btBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBrisi.Location = new System.Drawing.Point(22, 499);
            this.btBrisi.Name = "btBrisi";
            this.btBrisi.Size = new System.Drawing.Size(107, 34);
            this.btBrisi.TabIndex = 5;
            this.btBrisi.Text = "Brisi";
            this.btBrisi.UseVisualStyleBackColor = true;
            this.btBrisi.Click += new System.EventHandler(this.btBrisi_Click);
            // 
            // btSpremi
            // 
            this.btSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSpremi.Location = new System.Drawing.Point(142, 499);
            this.btSpremi.Name = "btSpremi";
            this.btSpremi.Size = new System.Drawing.Size(107, 34);
            this.btSpremi.TabIndex = 4;
            this.btSpremi.Text = "Spremi";
            this.btSpremi.UseVisualStyleBackColor = true;
            this.btSpremi.Click += new System.EventHandler(this.btSpremi_Click);
            // 
            // tbRazlog
            // 
            this.tbRazlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbRazlog.Location = new System.Drawing.Point(81, 113);
            this.tbRazlog.Name = "tbRazlog";
            this.tbRazlog.Size = new System.Drawing.Size(175, 22);
            this.tbRazlog.TabIndex = 3;
            // 
            // lbRazlog
            // 
            this.lbRazlog.AutoSize = true;
            this.lbRazlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRazlog.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRazlog.Location = new System.Drawing.Point(17, 113);
            this.lbRazlog.Name = "lbRazlog";
            this.lbRazlog.Size = new System.Drawing.Size(53, 25);
            this.lbRazlog.TabIndex = 2;
            this.lbRazlog.Text = "Opis";
            // 
            // tbTeret
            // 
            this.tbTeret.Location = new System.Drawing.Point(81, 75);
            this.tbTeret.Name = "tbTeret";
            this.tbTeret.Size = new System.Drawing.Size(175, 22);
            this.tbTeret.TabIndex = 1;
            // 
            // lbTeret
            // 
            this.lbTeret.AutoSize = true;
            this.lbTeret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTeret.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTeret.Location = new System.Drawing.Point(17, 71);
            this.lbTeret.Name = "lbTeret";
            this.lbTeret.Size = new System.Drawing.Size(58, 25);
            this.lbTeret.TabIndex = 0;
            this.lbTeret.Text = "Teret";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTablica);
            this.panel2.Location = new System.Drawing.Point(367, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 637);
            this.panel2.TabIndex = 2;
            // 
            // dgvTablica
            // 
            this.dgvTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablica.Location = new System.Drawing.Point(0, 0);
            this.dgvTablica.Name = "dgvTablica";
            this.dgvTablica.RowTemplate.Height = 24;
            this.dgvTablica.Size = new System.Drawing.Size(761, 637);
            this.dgvTablica.TabIndex = 0;
            this.dgvTablica.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablica_CellClick);
            this.dgvTablica.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTablica_DataBindingComplete);
            // 
            // lbGreska
            // 
            this.lbGreska.AutoSize = true;
            this.lbGreska.Location = new System.Drawing.Point(481, 37);
            this.lbGreska.Name = "lbGreska";
            this.lbGreska.Size = new System.Drawing.Size(46, 17);
            this.lbGreska.TabIndex = 3;
            this.lbGreska.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Br. naloga";
            // 
            // tbBRNaloga
            // 
            this.tbBRNaloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tbBRNaloga.Location = new System.Drawing.Point(123, 35);
            this.tbBRNaloga.Name = "tbBRNaloga";
            this.tbBRNaloga.Size = new System.Drawing.Size(133, 22);
            this.tbBRNaloga.TabIndex = 7;
            // 
            // NalogZaSluzbenoPutovanjefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.lbGreska);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btNazad);
            this.Name = "NalogZaSluzbenoPutovanjefrm";
            this.Text = "NalogZaSluzbenoPutovanjefrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRazlog;
        private System.Windows.Forms.TextBox tbTeret;
        private System.Windows.Forms.Label lbTeret;
        private System.Windows.Forms.TextBox tbRazlog;
        private System.Windows.Forms.Button btSpremi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTablica;
        private System.Windows.Forms.Button btBrisi;
        private System.Windows.Forms.Label lbGreska;
        private System.Windows.Forms.TextBox tbBRNaloga;
        private System.Windows.Forms.Label label1;
    }
}