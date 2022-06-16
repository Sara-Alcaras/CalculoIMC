using System;
using System.Globalization;

namespace CalculoIMC
{
    public static class Validador
    {
        public static string Nome(string nome) // Verifica se o nome é válido
        {
            bool eInvalido = true; // inicializa como verdadeiro pra realizar a validação do dado inicial

            while (eInvalido)
            {
                // Verifica se o usuário está inserindo nulo, vazio ou numero 
                bool eVazioOuNumero = string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out int r);
                //verifica se é vazio, nulo, numero ou string
                eInvalido = eVazioOuNumero || nome.Length <= 2;

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
            bool eInvalido = true;
            TipoSexo tipoSexo = TipoSexo.NaoEspecificado;

            while (eInvalido)
            {
                eInvalido = Enum.TryParse(strSexo, out tipoSexo);

                switch (tipoSexo) //veirifica tipo do sexo
                {
                    case TipoSexo.Masculino:
                    case TipoSexo.Feminino:
                    case TipoSexo.Outro:
                        eInvalido = false;
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
            int.TryParse(strIdade, out idade);

            switch (idade)
            {
                case > 1 and < 130:
                    break;
                default:
                    Console.Write("\nIdade Inválida! \r\nInforme sua idade novamente: ");
                    Idade(Console.ReadLine());
                    break;
            }
            return idade.ToString();
        }

        public static string Altura(string strAltura) // Verifica se a altura é válida
        {
            float altura;
            float.TryParse(strAltura.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out altura); // Aceita ponto e virgula
            switch (altura)
            {
                case > 0 and <= 2.60f:
                    break;
                default:
                    Console.Write("\nAltura Inválida! \r\nInforme sua altura novamente: ");
                    Altura(Console.ReadLine());
                    break;
            }
            return altura.ToString();
        }

        public static string Peso(string strPeso) // Verifica se o peso é válido
        {
            float peso;
            float.TryParse(strPeso.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out peso);

            switch (peso)
            {
                case >= 10 and <= 250:
                    break;
                default:
                    Erro.ExibeErro(TipoDado.Peso);
                    Peso(Console.ReadLine());
                    break;
            }
            return peso.ToString();
        }

    }
}
