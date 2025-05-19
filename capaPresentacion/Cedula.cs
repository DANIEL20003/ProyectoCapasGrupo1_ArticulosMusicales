using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacion
{
    internal class Cedula
    {
        private readonly string cedula;

        public Cedula(string cedula)
        {
            this.cedula = cedula;
        }

        public bool ComprobarCedula()
        {
            // Verificar si la cédula tiene exactamente 10 dígitos
            if (cedula.Length != 10 || !cedula.All(char.IsDigit))
                return false;

            // Validar que el primer dígito corresponda a una provincia válida (1 a 24)
            int provincia = int.Parse(cedula.Substring(0, 2));
            if (provincia < 1 || provincia > 24)
                return false;

            // Validar que el tercer dígito sea menor que 6 (para ser cédula personal)
            int tercerDigito = int.Parse(cedula[2].ToString());
            if (tercerDigito >= 6)
                return false;

            // Calcular el dígito verificador
            int sumaImpares = 0;
            int sumaPares = 0;

            for (int i = 0; i < 9; i++)
            {
                int num = int.Parse(cedula[i].ToString());
                if (i % 2 == 0) // impares (índices 0, 2, 4, 6, 8)
                {
                    int mult = num * 2;
                    if (mult > 9) mult -= 9; // Si el resultado es mayor que 9, restamos 9
                    sumaImpares += mult;
                }
                else // pares (índices 1, 3, 5, 7)
                {
                    sumaPares += num;
                }
            }

            int total = sumaImpares + sumaPares;
            int verificadorCalculado = (10 - (total % 10)) % 10; // Dígito verificador calculado
            int verificadorOriginal = int.Parse(cedula[9].ToString()); // Dígito verificador de la cédula

            return verificadorCalculado == verificadorOriginal; // Si coincide, la cédula es válida
        }
    }
}
