using System.Text.RegularExpressions;

namespace HolaMundo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Función que ejecutamos al dar clic al botón "btnValidar"
        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Validamos una expresión regular REGEX que valida las reglas definidas en este ejercicio:
            //La contraseña debe contener al menos una letra mayúscula, una minúscula, un símbolo y un número.
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            //Comparamos que los textBox no estén vacíos.
            if (string.IsNullOrEmpty(txtContrasenaUno.Text) &&
                string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos están vacíos");
                return;
            }

            //Condicional que valida
            //Si no son iguales los textos
            //El signo de exclamación indica negación
            if(!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }

            //Analizamos ambos textos y si se cumple o no la validación, mostramos un mensaje.
            if (validacion.IsMatch(txtContrasenaUno.Text))
            {
                MessageBox.Show("La contraseña es válida");


            } else
            {
                MessageBox.Show("La contraseña no es válida");
            }
        }
    }
}