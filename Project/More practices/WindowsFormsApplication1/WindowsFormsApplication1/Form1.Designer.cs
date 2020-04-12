namespace WindowsFormsApplication1
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGENDAINSERTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGENDATELEFONICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOMBRESOAPELLIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGENDAINSERTARToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // aGENDAINSERTARToolStripMenuItem
            // 
            this.aGENDAINSERTARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSERTARToolStripMenuItem,
            this.aCTUALIZARToolStripMenuItem});
            this.aGENDAINSERTARToolStripMenuItem.Name = "aGENDAINSERTARToolStripMenuItem";
            this.aGENDAINSERTARToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aGENDAINSERTARToolStripMenuItem.Text = "AGENDA TELEFONICA";
            this.aGENDAINSERTARToolStripMenuItem.Click += new System.EventHandler(this.aGENDAINSERTARToolStripMenuItem_Click);
            // 
            // iNSERTARToolStripMenuItem
            // 
            this.iNSERTARToolStripMenuItem.Name = "iNSERTARToolStripMenuItem";
            this.iNSERTARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iNSERTARToolStripMenuItem.Text = "INSERTAR";
            this.iNSERTARToolStripMenuItem.Click += new System.EventHandler(this.iNSERTARToolStripMenuItem_Click);
            // 
            // aCTUALIZARToolStripMenuItem
            // 
            this.aCTUALIZARToolStripMenuItem.Name = "aCTUALIZARToolStripMenuItem";
            this.aCTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aCTUALIZARToolStripMenuItem.Text = "ACTUALIZAR";
            this.aCTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aCTUALIZARToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGENDATELEFONICAToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // aGENDATELEFONICAToolStripMenuItem
            // 
            this.aGENDATELEFONICAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOMBRESOAPELLIDOToolStripMenuItem});
            this.aGENDATELEFONICAToolStripMenuItem.Name = "aGENDATELEFONICAToolStripMenuItem";
            this.aGENDATELEFONICAToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aGENDATELEFONICAToolStripMenuItem.Text = "AGENDA TELEFONICA";
            // 
            // nOMBRESOAPELLIDOToolStripMenuItem
            // 
            this.nOMBRESOAPELLIDOToolStripMenuItem.Name = "nOMBRESOAPELLIDOToolStripMenuItem";
            this.nOMBRESOAPELLIDOToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nOMBRESOAPELLIDOToolStripMenuItem.Text = "NOMBRES O APELLIDO";
            this.nOMBRESOAPELLIDOToolStripMenuItem.Click += new System.EventHandler(this.nOMBRESOAPELLIDOToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 383);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENDAINSERTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENDATELEFONICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOMBRESOAPELLIDOToolStripMenuItem;
    }
}

