using CadParcial2Mvajc;
using ClnParcial2Mvajc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2Mvajc
{
	public partial class FrmSerie : Form
	{
		bool esNuevo = false;
		public FrmSerie()
		{
			InitializeComponent();
			listar();
		}

		private void listar()
		{
			var series = SerieCln.listar();
			dgvSerie.DataSource = series;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if (dgvSerie.SelectedRows.Count > 0)
			{
				int id = (int)dgvSerie.SelectedRows[0].Cells["id"].Value;
				string Titulo = "titulo";
				SerieCln.eliminar(id, Titulo);
				listar();
			}
			else
			{
				MessageBox.Show("Seleccione una fila para eliminar.");
			}

		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			esNuevo = true;
			LimpiarCampos();
			HabilitarCampos(true);

		}
		private void btnEditar_Click(object sender, EventArgs e)
		{
			if (dgvSerie.SelectedRows.Count > 0)
			{
				esNuevo = false;
				HabilitarCampos(true);
				CargarCampos();
			}
			else
			{
				MessageBox.Show("Seleccione una fila para editar.");
			}

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string parametro = txtBuscar.Text;
			var series = SerieCln.listarPa(parametro);
			dgvSerie.DataSource = series;

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			var serie = new Serie
			{
				titulo = txtTitulo.Text,
				sinopsis = txtSinopsis.Text,
				director = txtDirector.Text,
				episodios = int.Parse(nudEpisodios.Text),
				fechaEstreno = DateTime.Parse(dtpFechaEstreno.Text),

			};

			if (esNuevo)
			{
				SerieCln.insertar(serie);
			}
			else
			{
				serie.id = (int)dgvSerie.SelectedRows[0].Cells["id"].Value;
				SerieCln.actualizar(serie);
			}

			listar();
			LimpiarCampos();
			HabilitarCampos(false);
		}


		private void dgvSerie_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				dgvSerie.Rows[e.RowIndex].Selected = true;
			}

		}
		private void LimpiarCampos()
		{
			txtTitulo.Text = "";
			txtSinopsis.Text = "";
			txtDirector.Text = "";
			nudEpisodios.Text = "";
			dtpFechaEstreno.Text = "";

		}
		private void HabilitarCampos(bool habilitar)
		{
			txtTitulo.Enabled = habilitar;
			txtSinopsis.Enabled = habilitar;
			txtDirector.Enabled = habilitar;
			nudEpisodios.Enabled = habilitar;
			dtpFechaEstreno.Enabled = habilitar;
			btnGuardar.Enabled = habilitar;

		}
		private void CargarCampos()
		{
			txtTitulo.Text = dgvSerie.SelectedRows[0].Cells["titulo"].Value.ToString();
			txtSinopsis.Text = dgvSerie.SelectedRows[0].Cells["sinopsis"].Value.ToString();
			txtDirector.Text = dgvSerie.SelectedRows[0].Cells["director"].Value.ToString();
			nudEpisodios.Text = dgvSerie.SelectedRows[0].Cells["episodios"].Value.ToString();
			dtpFechaEstreno.Text = dgvSerie.SelectedRows[0].Cells["fechaEstreno"].Value.ToString();
		}

		//private void dgvSerie_CellContentClick(object sender, DataGridViewCellEventArgs e)
		//{

		//}
	}
}
