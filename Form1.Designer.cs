
namespace NTPVize
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHavaDurumuBilgileriniAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clİller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMakSicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMinSicaklik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHavaDurumuBilgileriniAl
            // 
            this.btnHavaDurumuBilgileriniAl.Location = new System.Drawing.Point(139, 12);
            this.btnHavaDurumuBilgileriniAl.Name = "btnHavaDurumuBilgileriniAl";
            this.btnHavaDurumuBilgileriniAl.Size = new System.Drawing.Size(460, 46);
            this.btnHavaDurumuBilgileriniAl.TabIndex = 0;
            this.btnHavaDurumuBilgileriniAl.Text = "Hava Durumu Bilgilerini Al";
            this.btnHavaDurumuBilgileriniAl.UseVisualStyleBackColor = true;
            this.btnHavaDurumuBilgileriniAl.Click += new System.EventHandler(this.btnHavaDurumuBilgileriniAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clİller,
            this.clDurum,
            this.clMakSicaklik,
            this.clMinSicaklik});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 359);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // clİller
            // 
            this.clİller.HeaderText = "İller";
            this.clİller.MinimumWidth = 6;
            this.clİller.Name = "clİller";
            this.clİller.Width = 125;
            // 
            // clDurum
            // 
            this.clDurum.HeaderText = "Durum";
            this.clDurum.MinimumWidth = 6;
            this.clDurum.Name = "clDurum";
            this.clDurum.Width = 125;
            // 
            // clMakSicaklik
            // 
            this.clMakSicaklik.HeaderText = "Maksimum Sıcaklık";
            this.clMakSicaklik.MinimumWidth = 6;
            this.clMakSicaklik.Name = "clMakSicaklik";
            this.clMakSicaklik.Width = 125;
            // 
            // clMinSicaklik
            // 
            this.clMinSicaklik.HeaderText = "Minimum Sıcaklık";
            this.clMinSicaklik.MinimumWidth = 6;
            this.clMinSicaklik.Name = "clMinSicaklik";
            this.clMinSicaklik.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHavaDurumuBilgileriniAl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHavaDurumuBilgileriniAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clİller;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMakSicaklik;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMinSicaklik;
    }
}

