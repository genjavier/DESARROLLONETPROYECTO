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
            string id =  TextBox6.Text;
            int x ;
            int.TryParse(id, out x);
            Persona pr = new Persona(x,nombre,apP,apM,correo,telefono);
           // Comuna com = new Comuna("Maule", pr);
            Biblioteca.NEG.NEGPersona.insert_persona(pr);
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string apP = TextBox2.Text;
            string apM = TextBox3.Text;
            string correo = TextBox4.Text;
            string telefono = TextBox5.Text;
            string id = TextBox6.Text;
            int x;
            int.TryParse(id, out x);
            Persona pr = new Persona(x, nombre, apP, apM, correo, telefono);
            Biblioteca.NEG.NEGPersona.selectTodas(pr);

            leer = comando.ExecuteReader();
            while (leer.Read() == true)
            {
                listBox3.Items.Add(leer[0].ToString());
                //Aqui quiero que los muestre tambien
                textBox5.Text = leer["SMT"].ToString();
                textBox6.Text = leer["SMT"].ToString();
                textBox7.Text = leer["SMT"].ToString();
            }


        }
}