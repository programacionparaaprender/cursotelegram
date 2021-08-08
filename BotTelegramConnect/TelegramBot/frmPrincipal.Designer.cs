namespace TelegramBot
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensajeSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensajeConImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenDeWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensajeConEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensajeConTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.envioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioDeMensajeSimpleToolStripMenuItem,
            this.envioDeMensajeConImagenToolStripMenuItem,
            this.envioDeMensajeConEmojiToolStripMenuItem,
            this.envioDeMensajeConTemporizadorToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // envioDeMensajeSimpleToolStripMenuItem
            // 
            this.envioDeMensajeSimpleToolStripMenuItem.Name = "envioDeMensajeSimpleToolStripMenuItem";
            this.envioDeMensajeSimpleToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.envioDeMensajeSimpleToolStripMenuItem.Text = "Envio de mensaje simple";
            // 
            // envioDeMensajeConImagenToolStripMenuItem
            // 
            this.envioDeMensajeConImagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenDeWebToolStripMenuItem,
            this.imagenLocalToolStripMenuItem});
            this.envioDeMensajeConImagenToolStripMenuItem.Name = "envioDeMensajeConImagenToolStripMenuItem";
            this.envioDeMensajeConImagenToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.envioDeMensajeConImagenToolStripMenuItem.Text = "Envio de mensaje con imagen";
            // 
            // imagenDeWebToolStripMenuItem
            // 
            this.imagenDeWebToolStripMenuItem.Name = "imagenDeWebToolStripMenuItem";
            this.imagenDeWebToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imagenDeWebToolStripMenuItem.Text = "Imagen de web";
            // 
            // imagenLocalToolStripMenuItem
            // 
            this.imagenLocalToolStripMenuItem.Name = "imagenLocalToolStripMenuItem";
            this.imagenLocalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imagenLocalToolStripMenuItem.Text = "Imagen Local";
            // 
            // envioDeMensajeConEmojiToolStripMenuItem
            // 
            this.envioDeMensajeConEmojiToolStripMenuItem.Name = "envioDeMensajeConEmojiToolStripMenuItem";
            this.envioDeMensajeConEmojiToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.envioDeMensajeConEmojiToolStripMenuItem.Text = "Envio de mensaje con emoji";
            // 
            // envioDeMensajeConTemporizadorToolStripMenuItem
            // 
            this.envioDeMensajeConTemporizadorToolStripMenuItem.Name = "envioDeMensajeConTemporizadorToolStripMenuItem";
            this.envioDeMensajeConTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(331, 26);
            this.envioDeMensajeConTemporizadorToolStripMenuItem.Text = "Envio de mensaje con temporizador";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensajeSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensajeConImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenDeWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensajeConEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensajeConTemporizadorToolStripMenuItem;
    }
}

