using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.ENT;

namespace AplicacionWeb
{
    public partial class WFPPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string apP = TextBox2.Text;
            string apM = TextBox3.Text;
            string correo = TextBox4.Text;
            string telefono = TextBox5.Text;
            Persona pr = new Persona(nombre ,apP ,apM ,correo ,telefono);
           // Comuna com = new Comuna("Maule", pr);
            Biblioteca.DAO.DAOPersona.insert_persona(pr);
        }
    }
}