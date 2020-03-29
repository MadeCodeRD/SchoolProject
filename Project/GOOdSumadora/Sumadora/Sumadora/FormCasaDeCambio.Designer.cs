namespace Sumadora
{
    partial class FormCasaDeCambio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.textCantidadCambiar = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkUSaRD = new System.Windows.Forms.LinkLabel();
            this.LinkEURaTD = new System.Windows.Forms.LinkLabel();
            this.LinkRDaUS = new System.Windows.Forms.LinkLabel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textResultado);
            this.groupBox1.Controls.Add(this.textCantidadCambiar);
            this.groupBox1.Controls.Add(this.labelResultado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad a Cambiar:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(44, 198);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(84, 18);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.Visible = false;
            this.labelResultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // textCantidadCambiar
            // 
            this.textCantidadCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadCambiar.Location = new System.Drawing.Point(32, 136);
            this.textCantidadCambiar.Name = "textCantidadCambiar";
            this.textCantidadCambiar.Size = new System.Drawing.Size(159, 24);
            this.textCantidadCambiar.TabIndex = 2;
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(32, 235);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(159, 24);
            this.textResultado.TabIndex = 3;
            this.textResultado.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinkRDaUS);
            this.groupBox2.Controls.Add(this.LinkEURaTD);
            this.groupBox2.Controls.Add(this.LinkUSaRD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(236, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 164);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escoja una Opcion:";
            // 
            // LinkUSaRD
            // 
            this.LinkUSaRD.AutoSize = true;
            this.LinkUSaRD.Location = new System.Drawing.Point(36, 34);
            this.LinkUSaRD.Name = "LinkUSaRD";
            this.LinkUSaRD.Size = new System.Drawing.Size(118, 18);
            this.LinkUSaRD.TabIndex = 0;
            this.LinkUSaRD.TabStop = true;
            this.LinkUSaRD.Text = "US$     A  RD$";
            this.LinkUSaRD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUSaRD_LinkClicked);
            // 
            // LinkEURaTD
            // 
            this.LinkEURaTD.AutoSize = true;
            this.LinkEURaTD.Location = new System.Drawing.Point(33, 71);
            this.LinkEURaTD.Name = "LinkEURaTD";
            this.LinkEURaTD.Size = new System.Drawing.Size(140, 18);
            this.LinkEURaTD.TabIndex = 1;
            this.LinkEURaTD.TabStop = true;
            this.LinkEURaTD.Text = "EUR$     A    RD$";
            this.LinkEURaTD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEURaTD_LinkClicked);
            // 
            // LinkRDaUS
            // 
            this.LinkRDaUS.AutoSize = true;
            this.LinkRDaUS.Location = new System.Drawing.Point(33, 107);
            this.LinkRDaUS.Name = "LinkRDaUS";
            this.LinkRDaUS.Size = new System.Drawing.Size(123, 18);
            this.LinkRDaUS.TabIndex = 2;
            this.LinkRDaUS.TabStop = true;
            this.LinkRDaUS.Text = "RD$    A    US$";
            this.LinkRDaUS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRDaUS_LinkClicked);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(199, 301);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 61);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(353, 301);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 61);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Casa De Cambio \'\'La Rubia Dorada\'\'";
            // 
            // FormCasaDeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCasaDeCambio";
            this.Text = ".:.FormCasaDeCambio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.TextBox textCantidadCambiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.LinkLabel LinkRDaUS;
        private System.Windows.Forms.LinkLabel LinkEURaTD;
        private System.Windows.Forms.LinkLabel LinkUSaRD;
    }
}