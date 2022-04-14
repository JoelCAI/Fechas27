using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas27
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            Console.ReadKey();
            DateTime fecha = Validador.ValidarFechaIngresada("\n Ingrese una Fecha");

            Console.Clear();
            Console.WriteLine("\n La fecha ingresada es: " + fecha.ToLongDateString());

            DateTime fechaDos = fecha.AddDays(30);
            Console.WriteLine("\n La fecha ingresada + 30 días es: " + fechaDos.ToLongDateString());

            DateTime fechaTres = fecha.AddDays(60);
            Console.WriteLine("\n La fecha ingresada + 60 días es: " + fechaTres.ToLongDateString());

            DateTime fechaCuatro = fecha.AddDays(90);
            Console.WriteLine("\n La fecha ingresada + 90 días es: " + fechaCuatro.ToLongDateString());

            DateTime fechaCinco = fecha.AddDays(180);
            Console.WriteLine("\n La fecha ingresada + 180 días es: " + fechaCinco.ToLongDateString());

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
