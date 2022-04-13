using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculaWS_Net
{
    /// <summary>
    /// Breve descripción de CalculaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, se debe descomentar la línea siguiente: 
    // [System.Web.Script.Services.ScriptService]
    public class CalculaWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public int cuadrado(int cu)
        {
            Calculando C = new Calculando();
            C.Area_cuadrado = cu;
            return C.cuadrado(cu);
        }
        [WebMethod]
        public decimal triangulo(decimal Base, decimal Altura)
        {
            Calculando A = new Calculando();
            A.Area_triNum1 = Base;
            A.Area_triNum2 = Altura;
            return A.triangulo(Base, Altura);
        }
        [WebMethod]
        public double circulo(double pi, int area)
        {
            Calculando Ci = new Calculando();
            Ci.Pi_circulo = pi;
            Ci.Area_circulo = area;
            return Ci.circulo(pi, area);

        }
    }
}
 //9J JIMENEZ GOMEZ PATRICIA AHTZIRI