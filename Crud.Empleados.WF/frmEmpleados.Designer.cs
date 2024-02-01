namespace Crud.Empleados.WF
{
    partial class frmEmpleados
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pGrilla = new System.Windows.Forms.Panel();
            this.pDatos = new System.Windows.Forms.Panel();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.32265F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.67735F));
            this.tlpPrincipal.Controls.Add(this.pGrilla, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pDatos, 1, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.Size = new System.Drawing.Size(998, 582);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pGrilla
            // 
            this.pGrilla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrilla.Location = new System.Drawing.Point(3, 3);
            this.pGrilla.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pGrilla.Name = "pGrilla";
            this.pGrilla.Size = new System.Drawing.Size(608, 576);
            this.pGrilla.TabIndex = 0;
            // 
            // pDatos
            // 
            this.pDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatos.Location = new System.Drawing.Point(613, 3);
            this.pDatos.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(382, 576);
            this.pDatos.TabIndex = 1;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 582);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD EMPLEADOS";
            this.tlpPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pGrilla;
        private System.Windows.Forms.Panel pDatos;
    }
}

