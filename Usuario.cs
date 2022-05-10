using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Usuario : Form1
    {
        string nombre;
        string contraseña;

        public Usuario() : this("","")
        {

        }

        public Usuario(string nombre,string contraseña)
        {
            this.contraseña = contraseña;
            this.nombre = nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }

        public string GetContraseña()
        {
            return this.contraseña;
        }

        public void Loggearse()
        {
            if (textBox1.Text == "administrador" && textBox2.Text == "1234")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
