using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    public class Usuario : DadosIMC
    {
        public static string Nome { get; set; }
        public static string Sexo { get; set; }
        public static int Idade { get; set; }
        public static float Altura { get; set; }
        public static float Peso { get; set; }
        public static TipoCategoria Categoria { get { return VerificaCategoria(Idade); } }

        public static TipoCategoria VerificaCategoria(int idade) // Define a categoria de idade
        {
            TipoCategoria tipoCategoria;

            switch (idade)
            {
                case < 12:
                    tipoCategoria = TipoCategoria.Infantil;
                    break;
                case >= 12 and <= 20:
                    tipoCategoria = TipoCategoria.Juvenil;
                    break;
                case >= 21 and <= 65:
                    tipoCategoria = TipoCategoria.Adulto;
                    break;
                case > 65:
                    tipoCategoria = TipoCategoria.Idoso;
                    break;

            }
            return tipoCategoria;
        }

        public static void VerificaDadosIMC() // Método que chama todos os dados de verificação
        {
            CalculaIMC(Peso, Altura);
            VerificaIMC(Imc);
        }
    }
}
