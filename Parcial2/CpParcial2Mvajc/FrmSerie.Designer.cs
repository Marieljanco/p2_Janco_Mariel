namespace CpParcial2Mvajc
{
	partial class FrmSerie
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
			this.components = new System.ComponentModel.Container();
			this.pnlAcciones = new System.Windows.Forms.Panel();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.lblBusqueda = new System.Windows.Forms.Label();
			this.lblTituloPrincipal = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.nudEpisodios = new System.Windows.Forms.NumericUpDown();
			this.lblFechaEstreno = new System.Windows.Forms.Label();
			this.lblEpisodios = new System.Windows.Forms.Label();
			this.dgvSerie = new System.Windows.Forms.DataGridView();
			this.gbxSerie = new System.Windows.Forms.GroupBox();
			this.txtSinopsis = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.lblSinopsis = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.gbxDatos = new System.Windows.Forms.GroupBox();
			this.lblGenero = new System.Windows.Forms.Label();
			this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblDirector = new System.Windows.Forms.Label();
			this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpEpisodios = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
			this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cbxGenero = new System.Windows.Forms.ComboBox();
			this.pnlAcciones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).BeginInit();
			this.gbxSerie.SuspendLayout();
			this.gbxDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlAcciones
			// 
			this.pnlAcciones.Controls.Add(this.btnEliminar);
			this.pnlAcciones.Controls.Add(this.btnEditar);
			this.pnlAcciones.Controls.Add(this.btnNuevo);
			this.pnlAcciones.Location = new System.Drawing.Point(16, 262);
			this.pnlAcciones.Name = "pnlAcciones";
			this.pnlAcciones.Size = new System.Drawing.Size(819, 43);
			this.pnlAcciones.TabIndex = 19;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = global::CpParcial2Mvajc.Properties.Resources.delete;
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(397, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(98, 39);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = global::CpParcial2Mvajc.Properties.Resources.edit;
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(303, 2);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 39);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = global::CpParcial2Mvajc.Properties.Resources._new;
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.Location = new System.Drawing.Point(205, 2);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(92, 39);
			this.btnNuevo.TabIndex = 6;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// lblBusqueda
			// 
			this.lblBusqueda.AutoSize = true;
			this.lblBusqueda.Location = new System.Drawing.Point(13, 59);
			this.lblBusqueda.Name = "lblBusqueda";
			this.lblBusqueda.Size = new System.Drawing.Size(165, 13);
			this.lblBusqueda.TabIndex = 15;
			this.lblBusqueda.Text = "Buscar por Código o Descripción:";
			// 
			// lblTituloPrincipal
			// 
			this.lblTituloPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTituloPrincipal.Location = new System.Drawing.Point(11, 17);
			this.lblTituloPrincipal.Name = "lblTituloPrincipal";
			this.lblTituloPrincipal.Size = new System.Drawing.Size(820, 32);
			this.lblTituloPrincipal.TabIndex = 14;
			this.lblTituloPrincipal.Text = "Series";
			this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(243, 56);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(494, 20);
			this.txtBuscar.TabIndex = 16;
			// 
			// nudEpisodios
			// 
			this.nudEpisodios.Location = new System.Drawing.Point(482, 28);
			this.nudEpisodios.Name = "nudEpisodios";
			this.nudEpisodios.Size = new System.Drawing.Size(120, 20);
			this.nudEpisodios.TabIndex = 8;
			// 
			// lblFechaEstreno
			// 
			this.lblFechaEstreno.AutoSize = true;
			this.lblFechaEstreno.Location = new System.Drawing.Point(362, 58);
			this.lblFechaEstreno.Name = "lblFechaEstreno";
			this.lblFechaEstreno.Size = new System.Drawing.Size(93, 13);
			this.lblFechaEstreno.TabIndex = 7;
			this.lblFechaEstreno.Text = "Fecha de estreno:";
			// 
			// lblEpisodios
			// 
			this.lblEpisodios.AutoSize = true;
			this.lblEpisodios.Location = new System.Drawing.Point(362, 30);
			this.lblEpisodios.Name = "lblEpisodios";
			this.lblEpisodios.Size = new System.Drawing.Size(55, 13);
			this.lblEpisodios.TabIndex = 6;
			this.lblEpisodios.Text = "Episodios:";
			// 
			// dgvSerie
			// 
			this.dgvSerie.AllowUserToAddRows = false;
			this.dgvSerie.AllowUserToDeleteRows = false;
			this.dgvSerie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSerie.Location = new System.Drawing.Point(6, 23);
			this.dgvSerie.Name = "dgvSerie";
			this.dgvSerie.ReadOnly = true;
			this.dgvSerie.RowHeadersWidth = 51;
			this.dgvSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSerie.Size = new System.Drawing.Size(803, 133);
			this.dgvSerie.TabIndex = 0;
			// 
			// gbxSerie
			// 
			this.gbxSerie.Controls.Add(this.dgvSerie);
			this.gbxSerie.Location = new System.Drawing.Point(16, 93);
			this.gbxSerie.Name = "gbxSerie";
			this.gbxSerie.Size = new System.Drawing.Size(815, 162);
			this.gbxSerie.TabIndex = 18;
			this.gbxSerie.TabStop = false;
			this.gbxSerie.Text = "Lista de Series";
			// 
			// txtSinopsis
			// 
			this.txtSinopsis.Location = new System.Drawing.Point(125, 55);
			this.txtSinopsis.Name = "txtSinopsis";
			this.txtSinopsis.Size = new System.Drawing.Size(194, 20);
			this.txtSinopsis.TabIndex = 4;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(125, 27);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(194, 20);
			this.txtTitulo.TabIndex = 3;
			// 
			// lblSinopsis
			// 
			this.lblSinopsis.AutoSize = true;
			this.lblSinopsis.Location = new System.Drawing.Point(15, 58);
			this.lblSinopsis.Name = "lblSinopsis";
			this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
			this.lblSinopsis.TabIndex = 1;
			this.lblSinopsis.Text = "Sinopsis:";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(15, 30);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(38, 13);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Título:";
			// 
			// gbxDatos
			// 
			this.gbxDatos.Controls.Add(this.cbxGenero);
			this.gbxDatos.Controls.Add(this.lblGenero);
			this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
			this.gbxDatos.Controls.Add(this.txtDirector);
			this.gbxDatos.Controls.Add(this.btnCancelar);
			this.gbxDatos.Controls.Add(this.btnGuardar);
			this.gbxDatos.Controls.Add(this.nudEpisodios);
			this.gbxDatos.Controls.Add(this.lblFechaEstreno);
			this.gbxDatos.Controls.Add(this.lblEpisodios);
			this.gbxDatos.Controls.Add(this.txtSinopsis);
			this.gbxDatos.Controls.Add(this.txtTitulo);
			this.gbxDatos.Controls.Add(this.lblDirector);
			this.gbxDatos.Controls.Add(this.lblSinopsis);
			this.gbxDatos.Controls.Add(this.lblTitulo);
			this.gbxDatos.Location = new System.Drawing.Point(16, 311);
			this.gbxDatos.Name = "gbxDatos";
			this.gbxDatos.Size = new System.Drawing.Size(819, 123);
			this.gbxDatos.TabIndex = 20;
			this.gbxDatos.TabStop = false;
			this.gbxDatos.Text = "Datos";
			// 
			// lblGenero
			// 
			this.lblGenero.AutoSize = true;
			this.lblGenero.Location = new System.Drawing.Point(363, 85);
			this.lblGenero.Name = "lblGenero";
			this.lblGenero.Size = new System.Drawing.Size(45, 13);
			this.lblGenero.TabIndex = 14;
			this.lblGenero.Text = "Género:";
			// 
			// dtpFechaEstreno
			// 
			this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaEstreno.Location = new System.Drawing.Point(482, 55);
			this.dtpFechaEstreno.Name = "dtpFechaEstreno";
			this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 20);
			this.dtpFechaEstreno.TabIndex = 13;
			this.dtpFechaEstreno.Value = new System.DateTime(2024, 11, 4, 14, 44, 50, 0);
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(125, 81);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(194, 20);
			this.txtDirector.TabIndex = 12;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CpParcial2Mvajc.Properties.Resources.cancel;
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(707, 80);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(108, 39);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = global::CpParcial2Mvajc.Properties.Resources.save;
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(600, 80);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(101, 39);
			this.btnGuardar.TabIndex = 10;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblDirector
			// 
			this.lblDirector.AutoSize = true;
			this.lblDirector.Location = new System.Drawing.Point(15, 86);
			this.lblDirector.Name = "lblDirector";
			this.lblDirector.Size = new System.Drawing.Size(47, 13);
			this.lblDirector.TabIndex = 2;
			this.lblDirector.Text = "Director:";
			// 
			// erpFechaEstreno
			// 
			this.erpFechaEstreno.ContainerControl = this;
			// 
			// erpEpisodios
			// 
			this.erpEpisodios.ContainerControl = this;
			// 
			// erpDirector
			// 
			this.erpDirector.ContainerControl = this;
			// 
			// erpSinopsis
			// 
			this.erpSinopsis.ContainerControl = this;
			// 
			// erpTitulo
			// 
			this.erpTitulo.ContainerControl = this;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = global::CpParcial2Mvajc.Properties.Resources.search;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(743, 49);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(92, 39);
			this.btnBuscar.TabIndex = 17;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// cbxGenero
			// 
			this.cbxGenero.FormattingEnabled = true;
			this.cbxGenero.Items.AddRange(new object[] {
            "Drama",
            "Comedia",
            "Terror"});
			this.cbxGenero.Location = new System.Drawing.Point(473, 83);
			this.cbxGenero.Name = "cbxGenero";
			this.cbxGenero.Size = new System.Drawing.Size(121, 21);
			this.cbxGenero.TabIndex = 16;
			// 
			// FrmSerie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(846, 450);
			this.Controls.Add(this.pnlAcciones);
			this.Controls.Add(this.lblBusqueda);
			this.Controls.Add(this.lblTituloPrincipal);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.gbxSerie);
			this.Controls.Add(this.gbxDatos);
			this.Controls.Add(this.btnBuscar);
			this.Name = "FrmSerie";
			this.Text = "FrmSerie";
			this.pnlAcciones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudEpisodios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSerie)).EndInit();
			this.gbxSerie.ResumeLayout(false);
			this.gbxDatos.ResumeLayout(false);
			this.gbxDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpEpisodios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Panel pnlAcciones;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Label lblBusqueda;
		private System.Windows.Forms.Label lblTituloPrincipal;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.NumericUpDown nudEpisodios;
		private System.Windows.Forms.Label lblFechaEstreno;
		private System.Windows.Forms.Label lblEpisodios;
		private System.Windows.Forms.DataGridView dgvSerie;
		private System.Windows.Forms.GroupBox gbxSerie;
		private System.Windows.Forms.TextBox txtSinopsis;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label lblSinopsis;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.GroupBox gbxDatos;
		private System.Windows.Forms.Label lblDirector;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.ErrorProvider erpFechaEstreno;
		private System.Windows.Forms.ErrorProvider erpEpisodios;
		private System.Windows.Forms.ErrorProvider erpDirector;
		private System.Windows.Forms.ErrorProvider erpSinopsis;
		private System.Windows.Forms.ErrorProvider erpTitulo;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
		private System.Windows.Forms.Label lblGenero;
		private C1ComboBox c1ComboBox1;
		private System.Windows.Forms.ComboBox cbxGenero;
	}
}

