using Libros1.Controllers;
using Libros1.Models;

namespace Libros1
{
    public partial class frm_Libro : Form
    {
         
        public frm_Libro()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            LibroModel libro = new LibroModel
            {
                Libro_id = codigolibro,
                titulo = txt_Detalle.Text
            };
            try
            {
                if (codigolibro == 0)
                {
                    respuesta = libroController.insertar(libro);
                }
                else
                {
                    respuesta = libroController.actualziar(libro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardo con exito");
           codigolibro = 0;
            txt_Detalle.Enabled = false;
            txt_Detalle.Text = "";
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txt_Detalle.Enabled = true;
            codigolibro = Convert.ToInt16(lst_Libros.SelectedValue);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LibroModel libroModel = new LibroModel { Libro_id = codigolibro };
            DialogResult result = MessageBox.Show("Desea Eliminar el libro", "Formulario de Libros", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (libroController.eliminar(libroModel) == "ok")
                {
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la eliminacion");

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Detalle.Text = "";
            codigolibro = 0;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            codigolibro = 0;
            this.Close();
        }

        private void lst_Libros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lst_Paises_DoubleClick(object sender, EventArgs e)
        {
            codigolibro = Convert.ToInt16(lst_Libros.SelectedValue);
            txt_Detalle.Text = lst_Libros.GetItemText(lst_Libros.SelectedItem);
        }
        private void frm_Libro_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        LibroController libroController = new LibroController();
        public int codigolibro = 0;
        public void cargaLista()
        {
            lst_Libros.Items.Clear();
            lst_Libros.DataSource = libroController.todos();
            lst_Libros.DisplayMember = "titulo"; //muestra el texto en la lista        
            lst_Libros.ValueMember = "libro_id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
