namespace InmobiliariaLagos.Formularios.Locatarios
{
    partial class frmConsultaLocatario
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
            this.lvListaLoc = new System.Windows.Forms.ListView();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.lblConsultaLocatario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lvListaLoc
            // 
            this.lvListaLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvListaLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.lvListaLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvListaLoc.ForeColor = System.Drawing.Color.White;
            this.lvListaLoc.HideSelection = false;
            this.lvListaLoc.Location = new System.Drawing.Point(24, 133);
            this.lvListaLoc.Name = "lvListaLoc";
            this.lvListaLoc.Size = new System.Drawing.Size(764, 241);
            this.lvListaLoc.TabIndex = 1;
            this.lvListaLoc.UseCompatibleStateImageBehavior = false;
            this.lvListaLoc.View = System.Windows.Forms.View.Details;
            this.lvListaLoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvListaLoc_MouseDoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(763, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSeleccionar.IconColor = System.Drawing.Color.Black;
            this.btnSeleccionar.IconSize = 16;
            this.btnSeleccionar.Location = new System.Drawing.Point(706, 404);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Rotation = 0D;
            this.btnSeleccionar.Size = new System.Drawing.Size(82, 23);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // lblConsultaLocatario
            // 
            this.lblConsultaLocatario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultaLocatario.AutoSize = true;
            this.lblConsultaLocatario.BackColor = System.Drawing.Color.Transparent;
            this.lblConsultaLocatario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaLocatario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblConsultaLocatario.Location = new System.Drawing.Point(251, 12);
            this.lblConsultaLocatario.Name = "lblConsultaLocatario";
            this.lblConsultaLocatario.Size = new System.Drawing.Size(317, 33);
            this.lblConsultaLocatario.TabIndex = 121;
            this.lblConsultaLocatario.Text = "Consulta de Locatarios";
            // 
            // frmConsultaLocatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConsultaLocatario);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lvListaLoc);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmConsultaLocatario";
            this.Text = "frmConsultaLocatario";
            this.Load += new System.EventHandler(this.frmConsultaLocatario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConsultaLocatario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvListaLoc;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconButton btnSeleccionar;
        private System.Windows.Forms.Label lblConsultaLocatario;
    }
}