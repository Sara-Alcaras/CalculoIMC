using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CalculoIMC
{
    public static class Validador
    {
        public static string Nome(string nome) // Verifica se o nome é válido
        {
            bool eInvalido = true; // inicializa como verdadeiro pra realizar a validação do dado inicial
            
            while (eInvalido)
            {
                bool somenteLetras = Regex.IsMatch(nome, "^[a-zA-Z]"); // verifica se é somente letras
                // Verifica se o usuário está inserindo nulo, vazio ou numero 
                bool eVazioOuNumero = string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out int r);
                //verifica se é vazio, nulo, numero ou string
                eInvalido = eVazioOuNumero || nome.Length <= 2 || !somenteLetras;

                if (!eInvalido) //se for falso, o dado é valido e sai do laço
                {
                    eInvalido = false;
                }
                else
                { // se for invalido, continua o laço solicitando novamente a entrada do dado
                    Erro.ExibeErro(TipoDado.Nome);
                    nome = UtilsConsole.CapturaDadoDigitado();
                }
            }
            return nome; //retorna o dado valido
        }


        public static string Sexo(string strSexo) // Verifica se o sexo é válido
        {
            bool eValido = false;
            TipoSexo tipoSexo = TipoSexo.NaoEspecificado;

            while (!eValido)
            {
                eValido = Enum.TryParse(strSexo, out tipoSexo) && !int.TryParse(strSexo, out int r);

                switch (tipoSexo) //veirifica tipo do sexo
                {
                    case TipoSexo.Masculino:
                    case TipoSexo.Feminino:
                    case TipoSexo.Outro:
                        eValido = true;
                        break;
                    default: // se nao existir o tipo na classe TipoSexo, solicita correcao do dado de entrada
                        Erro.ExibeErro(TipoDado.Sexo);
                        strSexo = Console.ReadLine();
                        break;
                }
            }
            return tipoSexo.ToString();
        }

        public static string Idade(string strIdade) // Verifica se a idade é válida
        {
            int idade;
            bool eValido = false;

            while(!eValido)
            {
                int.TryParse(strIdade, out idade);
                switch (idade)
                {
                    case > 1 and < 130:
                        eValido = true;
                        break;
                    default:
                        Erro.ExibeErro(TipoDado.Idade);
                        strIdade = Console.ReadLine();
                        break;
                }
            }
            return strIdade;
        }

        public static string Altura(string strAltura) // Verifica se a altura é válida
        {
            float altura;
            bool eValido = false;

            while(!eValido)
            {
                float.TryParse(strAltura.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out altura); // Aceita ponto e virgula
                switch (altura)
                {
                    case > 0 and <= 2.60f:
                        eValido = true;
                        break;
                    default:
                        Erro.ExibeErro(TipoDado.Altura);
                        strAltura = Console.ReadLine();
                        break;
                }
            }
            return strAltura.Replace(".", ",");
        }

        public static string Peso(string strPeso) // Verifica se o peso é válido
        {
            float peso;
            bool eValido = false;

            while(!eValido)
            {
                float.TryParse(strPeso.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out peso);
                switch (peso)
                {
                    case >= 10 and <= 250:
                        eValido = true;
                        break;
                    default:
                        Erro.ExibeErro(TipoDado.Peso);
                        strPeso = Console.ReadLine();
                        break;
                }
            }
            return strPeso;
        }

    }
}
