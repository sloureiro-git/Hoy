using System.Data;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FormMenu : Form
    {
        LogicaLibro AccesoLogicaLibro = new LogicaLibro();
        public FormMenu()
        {
            InitializeComponent();
        }


        private void buttonAÑADIR_Click(object sender, EventArgs e)
        {
            Libro AñadirLibro = new Libro(textBoxID.Text, textBoxNOMBRE.Text, textBoxAUTOR.Text, int.Parse(textBoxAÑO.Text));
            AccesoLogicaLibro.AñadirLibro(AñadirLibro);
            ActualizarGridDataSource();
            ObtenerItemsListBox();
        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        {
            Libro ModificarLibro = new Libro(textBoxID.Text, textBoxNOMBRE.Text, textBoxAUTOR.Text, int.Parse(textBoxAÑO.Text));
            AccesoLogicaLibro.ModificarLibro(ModificarLibro);
            ActualizarGridDataSource();
            ObtenerItemsListBox();

        }

        private void buttonELIMINAR_Click(object sender, EventArgs e)
        {
            Libro EliminarLibro = new Libro(textBoxID.Text, textBoxNOMBRE.Text, textBoxAUTOR.Text, int.Parse(textBoxAÑO.Text));
            AccesoLogicaLibro.EliminarLibro(EliminarLibro);
            ActualizarGridDataSource();
            ObtenerItemsListBox();

        }

        private void buttonSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarGridDataSource()
        {
            dataGridLIBROS.DataSource = null;
            dataGridLIBROS.DataSource = AccesoLogicaLibro.ObtenerLibros();
        }

        public void ObtenerItemsListBox()
        {
            listBoxLIBROS.Items.Clear();
            listBoxLIBROS.DisplayMember = "Display";

            List<Libro> ItemsListBox = AccesoLogicaLibro.ObtenerLibros();
            for (int i = 0; i < ItemsListBox.Count; i++)
            {
                listBoxLIBROS.Items.Add(ItemsListBox[i]);
            }
        }

        private void listBoxLIBROS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libro ItemSeleccionado = listBoxLIBROS.SelectedItems[0] as Libro;

            textBoxID.Text = ItemSeleccionado.Id;
            textBoxNOMBRE.Text = ItemSeleccionado.Nombre;
            textBoxAUTOR.Text = ItemSeleccionado.Autor;
            textBoxAÑO.Text = ItemSeleccionado.Año.ToString();
        }

        private void dataGridLIBROS_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridLIBROS.SelectedRows.Count > 0)
            {
                textBoxID.Text = dataGridLIBROS.SelectedRows[0].Cells[0].Value.ToString();
                textBoxNOMBRE.Text = dataGridLIBROS.SelectedRows[0].Cells[0].Value.ToString();
                textBoxAUTOR.Text = dataGridLIBROS.SelectedRows[0].Cells[0].Value.ToString();
                textBoxAÑO.Text = dataGridLIBROS.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
