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
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pDatos = new System.Windows.Forms.Panel();
            this.tbProyecto = new System.Windows.Forms.TextBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.pGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pDatos.SuspendLayout();
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
            this.pGrilla.Controls.Add(this.button4);
            this.pGrilla.Controls.Add(this.btnSalir);
            this.pGrilla.Controls.Add(this.btnEliminar);
            this.pGrilla.Controls.Add(this.btnEditar);
            this.pGrilla.Controls.Add(this.dgvEmpleados);
            this.pGrilla.Controls.Add(this.lblTitulo);
            this.pGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrilla.Location = new System.Drawing.Point(3, 3);
            this.pGrilla.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pGrilla.Name = "pGrilla";
            this.pGrilla.Size = new System.Drawing.Size(608, 576);
            this.pGrilla.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(457, 504);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(325, 504);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 504);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(66, 504);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 34);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleados.Location = new System.Drawing.Point(24, 47);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(554, 391);
            this.dgvEmpleados.TabIndex = 4;
    
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(33, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(156, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lista de empleados";
            // 
            // pDatos
            // 
            this.pDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pDatos.Controls.Add(this.tbProyecto);
            this.pDatos.Controls.Add(this.tbCargo);
            this.pDatos.Controls.Add(this.tbEdad);
            this.pDatos.Controls.Add(this.tbApellido);
            this.pDatos.Controls.Add(this.tbNombre);
            this.pDatos.Controls.Add(this.btnGuardar);
            this.pDatos.Controls.Add(this.lblProyecto);
            this.pDatos.Controls.Add(this.lblCargo);
            this.pDatos.Controls.Add(this.lblEdad);
            this.pDatos.Controls.Add(this.lblApellido);
            this.pDatos.Controls.Add(this.lblNombre);
            this.pDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatos.Location = new System.Drawing.Point(613, 3);
            this.pDatos.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.pDatos.Name = "pDatos";
            this.pDatos.Size = new System.Drawing.Size(382, 576);
            this.pDatos.TabIndex = 1;
            // 
            // tbProyecto
            // 
            this.tbProyecto.Location = new System.Drawing.Point(113, 216);
            this.tbProyecto.Name = "tbProyecto";
            this.tbProyecto.Size = new System.Drawing.Size(240, 20);
            this.tbProyecto.TabIndex = 4;
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(113, 178);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(240, 20);
            this.tbCargo.TabIndex = 3;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(113, 137);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(240, 20);
            this.tbEdad.TabIndex = 2;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(113, 97);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(240, 20);
            this.tbApellido.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(113, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(240, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 383);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(218, 55);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(53, 223);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(52, 13);
            this.lblProyecto.TabIndex = 4;
            this.lblProyecto.Text = "Proyecto:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(53, 185);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(50, 144);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(50, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 582);
            this.Controls.Add(this.tlpPrincipal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1014, 621);
            this.MinimumSize = new System.Drawing.Size(1014, 621);
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD EMPLEADOS";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.pGrilla.ResumeLayout(false);
            this.pGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pDatos.ResumeLayout(false);
            this.pDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pGrilla;
        private System.Windows.Forms.Panel pDatos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbProyecto;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}

