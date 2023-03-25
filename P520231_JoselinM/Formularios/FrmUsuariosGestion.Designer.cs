namespace P520231_JoselinM.Formularios
{
    partial class FrmUsuariosGestion
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
            this.Txt = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.cboxVerActivos = new System.Windows.Forms.CheckBox();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUsuarioRolDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbRolesUsuario = new System.Windows.Forms.ComboBox();
            this.TxtUsuarioDireccion = new System.Windows.Forms.TextBox();
            this.TxtUsuarioContrasennia = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.TxtUsuarioTelefono = new System.Windows.Forms.TextBox();
            this.TxtUsuarioCedula = new System.Windows.Forms.TextBox();
            this.TxtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.TxtUsuarioID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.ForeColor = System.Drawing.Color.White;
            this.Txt.Location = new System.Drawing.Point(25, 593);
            this.Txt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(79, 25);
            this.Txt.TabIndex = 0;
            this.Txt.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.HotPink;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.White;
            this.TxtBuscar.Location = new System.Drawing.Point(121, 593);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(622, 26);
            this.TxtBuscar.TabIndex = 1;
            // 
            // cboxVerActivos
            // 
            this.cboxVerActivos.AutoSize = true;
            this.cboxVerActivos.Checked = true;
            this.cboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxVerActivos.ForeColor = System.Drawing.Color.White;
            this.cboxVerActivos.Location = new System.Drawing.Point(755, 592);
            this.cboxVerActivos.Name = "cboxVerActivos";
            this.cboxVerActivos.Size = new System.Drawing.Size(216, 29);
            this.cboxVerActivos.TabIndex = 2;
            this.cboxVerActivos.Text = "Ver Usuarios Activos";
            this.cboxVerActivos.UseVisualStyleBackColor = true;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUsuarioID,
            this.CUsuarioNombre,
            this.CUsuarioCedula,
            this.CUsuarioTelefono,
            this.CUsuarioCorreo,
            this.CUsuarioRolDescripcion});
            this.DgLista.Location = new System.Drawing.Point(30, 320);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 62;
            this.DgLista.RowTemplate.Height = 28;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(984, 251);
            this.DgLista.TabIndex = 3;
            this.DgLista.VirtualMode = true;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CUsuarioID
            // 
            this.CUsuarioID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioID.DataPropertyName = "UsuarioID";
            this.CUsuarioID.HeaderText = "Codigo";
            this.CUsuarioID.MinimumWidth = 8;
            this.CUsuarioID.Name = "CUsuarioID";
            this.CUsuarioID.ReadOnly = true;
            this.CUsuarioID.Width = 120;
            // 
            // CUsuarioNombre
            // 
            this.CUsuarioNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUsuarioNombre.DataPropertyName = "UsuarioNombre";
            this.CUsuarioNombre.HeaderText = "Nombre";
            this.CUsuarioNombre.MinimumWidth = 8;
            this.CUsuarioNombre.Name = "CUsuarioNombre";
            this.CUsuarioNombre.ReadOnly = true;
            // 
            // CUsuarioCedula
            // 
            this.CUsuarioCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioCedula.DataPropertyName = "UsuarioCedula";
            this.CUsuarioCedula.HeaderText = "Cedula";
            this.CUsuarioCedula.MinimumWidth = 8;
            this.CUsuarioCedula.Name = "CUsuarioCedula";
            this.CUsuarioCedula.ReadOnly = true;
            this.CUsuarioCedula.Width = 130;
            // 
            // CUsuarioTelefono
            // 
            this.CUsuarioTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioTelefono.DataPropertyName = "UsuarioTelefono";
            this.CUsuarioTelefono.HeaderText = "Telefono";
            this.CUsuarioTelefono.MinimumWidth = 8;
            this.CUsuarioTelefono.Name = "CUsuarioTelefono";
            this.CUsuarioTelefono.ReadOnly = true;
            this.CUsuarioTelefono.Width = 120;
            // 
            // CUsuarioCorreo
            // 
            this.CUsuarioCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CUsuarioCorreo.DataPropertyName = "UsuarioCorreo";
            this.CUsuarioCorreo.HeaderText = "Email";
            this.CUsuarioCorreo.MinimumWidth = 8;
            this.CUsuarioCorreo.Name = "CUsuarioCorreo";
            this.CUsuarioCorreo.ReadOnly = true;
            this.CUsuarioCorreo.Width = 190;
            // 
            // CUsuarioRolDescripcion
            // 
            this.CUsuarioRolDescripcion.DataPropertyName = "UsuarioRolDescripcion";
            this.CUsuarioRolDescripcion.HeaderText = "Rol";
            this.CUsuarioRolDescripcion.MinimumWidth = 8;
            this.CUsuarioRolDescripcion.Name = "CUsuarioRolDescripcion";
            this.CUsuarioRolDescripcion.ReadOnly = true;
            this.CUsuarioRolDescripcion.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbRolesUsuario);
            this.groupBox1.Controls.Add(this.TxtUsuarioDireccion);
            this.groupBox1.Controls.Add(this.TxtUsuarioContrasennia);
            this.groupBox1.Controls.Add(this.TxtUsuarioCorreo);
            this.groupBox1.Controls.Add(this.TxtUsuarioTelefono);
            this.groupBox1.Controls.Add(this.TxtUsuarioCedula);
            this.groupBox1.Controls.Add(this.TxtUsuarioNombre);
            this.groupBox1.Controls.Add(this.TxtUsuarioID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Usuario";
            // 
            // CbRolesUsuario
            // 
            this.CbRolesUsuario.BackColor = System.Drawing.Color.HotPink;
            this.CbRolesUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRolesUsuario.ForeColor = System.Drawing.Color.White;
            this.CbRolesUsuario.FormattingEnabled = true;
            this.CbRolesUsuario.Location = new System.Drawing.Point(630, 34);
            this.CbRolesUsuario.Name = "CbRolesUsuario";
            this.CbRolesUsuario.Size = new System.Drawing.Size(321, 33);
            this.CbRolesUsuario.TabIndex = 16;
            // 
            // TxtUsuarioDireccion
            // 
            this.TxtUsuarioDireccion.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioDireccion.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioDireccion.Location = new System.Drawing.Point(630, 157);
            this.TxtUsuarioDireccion.Multiline = true;
            this.TxtUsuarioDireccion.Name = "TxtUsuarioDireccion";
            this.TxtUsuarioDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUsuarioDireccion.Size = new System.Drawing.Size(321, 35);
            this.TxtUsuarioDireccion.TabIndex = 15;
            this.TxtUsuarioDireccion.UseSystemPasswordChar = true;
            // 
            // TxtUsuarioContrasennia
            // 
            this.TxtUsuarioContrasennia.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioContrasennia.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioContrasennia.Location = new System.Drawing.Point(630, 117);
            this.TxtUsuarioContrasennia.Name = "TxtUsuarioContrasennia";
            this.TxtUsuarioContrasennia.Size = new System.Drawing.Size(321, 30);
            this.TxtUsuarioContrasennia.TabIndex = 14;
            this.TxtUsuarioContrasennia.UseSystemPasswordChar = true;
            // 
            // TxtUsuarioCorreo
            // 
            this.TxtUsuarioCorreo.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioCorreo.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioCorreo.Location = new System.Drawing.Point(630, 77);
            this.TxtUsuarioCorreo.Name = "TxtUsuarioCorreo";
            this.TxtUsuarioCorreo.Size = new System.Drawing.Size(321, 30);
            this.TxtUsuarioCorreo.TabIndex = 13;
            // 
            // TxtUsuarioTelefono
            // 
            this.TxtUsuarioTelefono.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioTelefono.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioTelefono.Location = new System.Drawing.Point(128, 160);
            this.TxtUsuarioTelefono.Name = "TxtUsuarioTelefono";
            this.TxtUsuarioTelefono.Size = new System.Drawing.Size(298, 30);
            this.TxtUsuarioTelefono.TabIndex = 11;
            // 
            // TxtUsuarioCedula
            // 
            this.TxtUsuarioCedula.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioCedula.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioCedula.Location = new System.Drawing.Point(128, 119);
            this.TxtUsuarioCedula.Name = "TxtUsuarioCedula";
            this.TxtUsuarioCedula.Size = new System.Drawing.Size(298, 30);
            this.TxtUsuarioCedula.TabIndex = 10;
            // 
            // TxtUsuarioNombre
            // 
            this.TxtUsuarioNombre.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioNombre.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioNombre.Location = new System.Drawing.Point(128, 78);
            this.TxtUsuarioNombre.Name = "TxtUsuarioNombre";
            this.TxtUsuarioNombre.Size = new System.Drawing.Size(298, 30);
            this.TxtUsuarioNombre.TabIndex = 9;
            // 
            // TxtUsuarioID
            // 
            this.TxtUsuarioID.BackColor = System.Drawing.Color.HotPink;
            this.TxtUsuarioID.ForeColor = System.Drawing.Color.White;
            this.TxtUsuarioID.Location = new System.Drawing.Point(128, 37);
            this.TxtUsuarioID.Name = "TxtUsuarioID";
            this.TxtUsuarioID.ReadOnly = true;
            this.TxtUsuarioID.Size = new System.Drawing.Size(298, 30);
            this.TxtUsuarioID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rol de Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(30, 247);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 50);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(229, 247);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(181, 50);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(428, 247);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(181, 50);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(627, 247);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(181, 50);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(826, 247);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 50);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1047, 649);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.cboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox cboxVerActivos;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbRolesUsuario;
        private System.Windows.Forms.TextBox TxtUsuarioDireccion;
        private System.Windows.Forms.TextBox TxtUsuarioContrasennia;
        private System.Windows.Forms.TextBox TxtUsuarioCorreo;
        private System.Windows.Forms.TextBox TxtUsuarioTelefono;
        private System.Windows.Forms.TextBox TxtUsuarioCedula;
        private System.Windows.Forms.TextBox TxtUsuarioNombre;
        private System.Windows.Forms.TextBox TxtUsuarioID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUsuarioRolDescripcion;
    }
}