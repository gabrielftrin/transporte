namespace GestaoDeRecargas
{
    partial class GestaoDeRecargas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoDeRecargas));
            this.Cartões = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cartões
            // 
            this.Cartões.Location = new System.Drawing.Point(12, 12);
            this.Cartões.Name = "Cartões";
            this.Cartões.Size = new System.Drawing.Size(75, 23);
            this.Cartões.TabIndex = 0;
            this.Cartões.Text = "Cartões";
            this.Cartões.UseVisualStyleBackColor = true;
            this.Cartões.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GestaoDeRecargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 138);
            this.Controls.Add(this.Cartões);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestaoDeRecargas";
            this.Text = "Gestão de Recargas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cartões;
    }
}

