namespace TransportnaApp.Forme
{
    partial class ZauzetaVozilaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZauzetaVozilaFrm));
            this.btnNazad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTablica = new System.Windows.Forms.DataGridView();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.lbNaziv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DarkGray;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnNazad.Image")));
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(716, 613);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(150, 53);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTablica);
            this.panel1.Location = new System.Drawing.Point(49, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 165);
            this.panel1.TabIndex = 6;
            // 
            // dgvTablica
            // 
            this.dgvTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablica.Location = new System.Drawing.Point(2, 2);
            this.dgvTablica.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTablica.Name = "dgvTablica";
            this.dgvTablica.RowTemplate.Height = 24;
            this.dgvTablica.Size = new System.Drawing.Size(494, 160);
            this.dgvTablica.TabIndex = 0;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(286, 96);
            this.dtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(259, 20);
            this.dtDatum.TabIndex = 8;
            this.dtDatum.ValueChanged += new System.EventHandler(this.dtDatum_ValueChanged);
            // 
            // lbNaziv
            // 
            this.lbNaziv.AutoSize = true;
            this.lbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNaziv.Location = new System.Drawing.Point(43, 85);
            this.lbNaziv.Name = "lbNaziv";
            this.lbNaziv.Size = new System.Drawing.Size(190, 31);
            this.lbNaziv.TabIndex = 9;
            this.lbNaziv.Text = "Zauzeta vozila";
            // 
            // ZauzetaVozilaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(886, 687);
            this.Controls.Add(this.lbNaziv);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNazad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ZauzetaVozilaFrm";
            this.Text = "ZauzetaVozilaFrm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTablica;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label lbNaziv;
    }
}