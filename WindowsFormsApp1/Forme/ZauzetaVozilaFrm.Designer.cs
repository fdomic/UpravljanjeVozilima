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
            this.dgvZauzetaVozila = new System.Windows.Forms.DataGridView();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZauzetaVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.DarkGray;
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Image = ((System.Drawing.Image)(resources.GetObject("btnNazad.Image")));
            this.btnNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNazad.Location = new System.Drawing.Point(954, 754);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(200, 65);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvZauzetaVozila);
            this.panel1.Location = new System.Drawing.Point(70, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 203);
            this.panel1.TabIndex = 6;
            // 
            // dgvZauzetaVozila
            // 
            this.dgvZauzetaVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZauzetaVozila.Location = new System.Drawing.Point(0, 3);
            this.dgvZauzetaVozila.Name = "dgvZauzetaVozila";
            this.dgvZauzetaVozila.RowTemplate.Height = 24;
            this.dgvZauzetaVozila.Size = new System.Drawing.Size(1015, 197);
            this.dgvZauzetaVozila.TabIndex = 0;
            // 
            // dtDo
            // 
            this.dtDo.Location = new System.Drawing.Point(403, 53);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(283, 22);
            this.dtDo.TabIndex = 7;
            // 
            // dtOd
            // 
            this.dtOd.Location = new System.Drawing.Point(70, 53);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(281, 22);
            this.dtOd.TabIndex = 8;
            // 
            // ZauzetaVozilaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.dtOd);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNazad);
            this.Name = "ZauzetaVozilaFrm";
            this.Text = "ZauzetaVozilaFrm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZauzetaVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvZauzetaVozila;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.DateTimePicker dtOd;
    }
}