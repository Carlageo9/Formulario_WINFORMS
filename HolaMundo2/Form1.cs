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
        //Funci�n que ejecutamos al dar clic al bot�n "btnValidar"
        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Validamos una expresi�n regular REGEX que valida las reglas definidas en este ejercicio:
            //La contrase�a debe contener al menos una letra may�scula, una min�scula, un s�mbolo y un n�mero.
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[\\W_]).*$");

            //Comparamos que los textBox no est�n vac�os.
            if (string.IsNullOrEmpty(txtContrasenaUno.Text) &&
                string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos est�n vac�os");
                return;
            }

            //Condicional que valida
            //Si no son iguales los textos
            //El signo de exclamaci�n indica negaci�n
            if(!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }

            //Analizamos ambos textos y si se cumple o no la validaci�n, mostramos un mensaje.
            if (validacion.IsMatch(txtContrasenaUno.Text))
            {
                MessageBox.Show("La contrase�a es v�lida");


            } else
            {
                MessageBox.Show("La contrase�a no es v�lida");
            }
        }
    }
}