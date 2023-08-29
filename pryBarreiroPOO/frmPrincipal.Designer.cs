namespace pryBarreiroPOO
{
    partial class frmPrincipal
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
            this.cmdCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.gbxCreador = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbxCreador.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(82, 132);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(101, 29);
            this.cmdCrear.TabIndex = 4;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(78, 59);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(38, 20);
            this.txtFuerza.TabIndex = 2;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(78, 95);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(38, 20);
            this.txtDestreza.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(16, 60);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(39, 13);
            this.lblFuerza.TabIndex = 5;
            this.lblFuerza.Text = "Fuerza";
            // 
            // lblDestreza
            // 
            this.lblDestreza.AutoSize = true;
            this.lblDestreza.Location = new System.Drawing.Point(16, 97);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(49, 13);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "Destreza";
            // 
            // gbxCreador
            // 
            this.gbxCreador.Controls.Add(this.txtFuerza);
            this.gbxCreador.Controls.Add(this.lblDestreza);
            this.gbxCreador.Controls.Add(this.cmdCrear);
            this.gbxCreador.Controls.Add(this.lblFuerza);
            this.gbxCreador.Controls.Add(this.txtNombre);
            this.gbxCreador.Controls.Add(this.lblNombre);
            this.gbxCreador.Controls.Add(this.txtDestreza);
            this.gbxCreador.Location = new System.Drawing.Point(33, 12);
            this.gbxCreador.Name = "gbxCreador";
            this.gbxCreador.Size = new System.Drawing.Size(203, 187);
            this.gbxCreador.TabIndex = 0;
            this.gbxCreador.TabStop = false;
            this.gbxCreador.Text = "Creador";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(31, 221);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(76, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Datos creados";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 364);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbxCreador);
            this.Name = "frmPrincipal";
            this.Text = "Creacion de Personajes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbxCreador.ResumeLayout(false);
            this.gbxCreador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.GroupBox gbxCreador;
        private System.Windows.Forms.Label lblInfo;
    }
}