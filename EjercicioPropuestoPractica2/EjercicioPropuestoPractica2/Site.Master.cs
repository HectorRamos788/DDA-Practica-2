using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuestoPractica2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (this.IsPostBack == false)
                {
                    Electro.Items.Add(new ListItem("Licuadora", "1"));
                    Electro.Items.Add(new ListItem("Horno Microondas", "2"));
                    Electro.Items.Add(new ListItem("Refrigeradora", "3"));
                    Electro.Items.Add(new ListItem("Freidora de Aire", "4"));
                    Electro.Items.Add(new ListItem("Lavadora", "5"));
                }
                Grafico.Visible = false;
            }

        }

        protected void Convertir_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Electro.Items[Electro.SelectedIndex];
            if (elemento.Value == "1")
            {
                Resultado.InnerText = " Datos Generales\r \n";
                Resultado.InnerText += "Codigo: 9635047  " +
                 "Nombre: Licuadora" + "Marca: Oster" + "Precio: 250";
            }
            if (elemento.Value == "2")
            {
                Resultado.InnerText = " Datos Generales\r";
                Resultado.InnerText += "Codigo: 9636247  " +
                 "Nombre: Horno Microondas" + "Marca: Oster" + "Precio: 400";
            }
            if (elemento.Value == "3")
            {
                Resultado.InnerText = " Datos Generales\r";
                Resultado.InnerText += "Codigo: 9637347  " +
                 "Nombre: Refrigeradora" + "Marca: Oster" + "Precio: 1800";
            }
            if (elemento.Value == "4")
            {

                Resultado.InnerText = " Datos Generales\r";
                Resultado.InnerText += "Codigo: 9637447  " +
                 "Nombre: Freidora de Aire" + "Marca: Oster" + "Precio: 500";

            }
            if (elemento.Value == "5")
            {

                Resultado.InnerText = " Datos Generales\r";
                   Resultado.InnerText += "Codigo: 9638547  "+  
                    "Nombre: Lavadora"+ "Marca: LG" + "Precio: 1200";

            }

        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "figura" + Electro.SelectedIndex.ToString() +".jpg";
            Grafico.Alt = "Grafico Temperatura";
            Grafico.Visible = true;

        }
    }
}

