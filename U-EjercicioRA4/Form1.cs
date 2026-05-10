using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U_EjercicioRA4
{
    public partial class FormInteraz : Form
    {
        public FormInteraz()
        {
            InitializeComponent();
        }
        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\+?[\d-]{7,15}$");
        }
        private bool Campovacio()
        {
            foreach (Control c in this.gbdatos.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text))
                    return true;
            }
            return false;
        }
        private void Limpiar()
        {
            
            txtNombre.Clear();
            txtEdad.Clear();
            txtTele.Clear();
            txtCorreo.Clear();
        }



        private void lNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtTele.Text) ||
                   string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                   string.IsNullOrWhiteSpace(txtEdad.Text))
                {
                    throw new Exception("Todos los campos deben estar llenos");
                }

                int edad;
                if (!int.TryParse(txtEdad.Text, out edad))
                {
                    throw new FormatException("La edad debe ser un número válido");
                }

                if (!EsEmailValido(txtCorreo.Text))
                {

                    throw new Exception("Correo no valido");                       
                }

                if (!EsTelefonoValido(txtTele.Text))
                {
                    errorProvider1.SetError(txtTele, "Teléfono no válido");
                    throw new Exception("Telefono no valido");
                }

                MessageBox.Show("Datos guardados correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error de formato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?",
                "Confirmar Salida!",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gbdatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
