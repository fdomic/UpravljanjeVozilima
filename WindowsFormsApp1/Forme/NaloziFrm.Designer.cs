namespace TransportnaApp.Forme
{
    partial class NaloziFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaloziFrm));
            this.btNazad = new System.Windows.Forms.Button();
            this.dgTablicaNalozi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablicaNalozi)).BeginInit();
            this.SuspendLayout();
            // 
            // btNazad
            // 
            this.btNazad.BackColor = System.Drawing.Color.DarkGray;
            this.btNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNazad.Image = ((System.Drawing.Image)(resources.GetObject("btNazad.Image")));
            this.btNazad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNazad.Location = new System.Drawing.Point(950, 766);
            this.btNazad.Name = "btNazad";
            this.btNazad.Size = new System.Drawing.Size(200, 65);
            this.btNazad.TabIndex = 0;
            this.btNazad.Text = "Nazad";
            this.btNazad.UseVisualStyleBackColor = false;
            this.btNazad.Click += new System.EventHandler(this.btNazad_Click);
            // 
            // dgTablicaNalozi
            // 
            this.dgTablicaNalozi.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgTablicaNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablicaNalozi.Location = new System.Drawing.Point(44, 65);
            this.dgTablicaNalozi.Name = "dgTablicaNalozi";
            this.dgTablicaNalozi.ReadOnly = true;
            this.dgTablicaNalozi.RowTemplate.Height = 24;
            this.dgTablicaNalozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablicaNalozi.Size = new System.Drawing.Size(1077, 629);
            this.dgTablicaNalozi.TabIndex = 1;
            this.dgTablicaNalozi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTablicaNalozi_CellClick);
            this.dgTablicaNalozi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTablica_DataBindingComplete);
            // 
            // NaloziFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.dgTablicaNalozi);
            this.Controls.Add(this.btNazad);
            this.Name = "NaloziFrm";
            this.Text = "Nalozi";
            this.Load += new System.EventHandler(this.NaloziFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTablicaNalozi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNazad;
        private System.Windows.Forms.DataGridView dgTablicaNalozi;
    }
}