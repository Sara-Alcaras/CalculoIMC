namespace CalculoIMC
{
    internal class UtilsConsole : Usuario
    {
        public static string CapturaDadoDigitado() // Método para entrada de dado
        {
            return Console.ReadLine();
        }

        public static void ExibeMensagemEntradaDado(TipoDado tipoMensagem) 
        {
            string mensagem = String.Empty;
            switch (tipoMensagem)
            {
                case TipoDado.Nome:
                    mensagem = "\nInforme seu nome: ";
                    break;
                case TipoDado.Sexo:
                    mensagem = "\nDigite o número que corresponde ao seu sexo: \n1- Masculino\n2- Feminino\n3- Outro\n\r";
                    break;
                case TipoDado.Idade:
                    mensagem = "\nInforme sua idade: ";
                    break;
                case TipoDado.Altura:
                    mensagem = "\nInforme sua altura: ";
                    break;
                case TipoDado.Peso:
                    mensagem = "\nInforme seu peso(kg): ";
                    break;

                default:
                    break;

            }
            Console.Write(mensagem);
        }

        public static void Inicializacao() // Inicia o programa com a primeira mensagem
        {

            Console.WriteLine("Olá! Seja bem-vindo. Insira seus dados para calcular o DIAGNÓSTICO PRÉVIO IMC");
            Console.WriteLine("*****************************************************************************");

        }

        public static void Fim() // Método que retorna os dados na tela
        {
            Console.WriteLine("Resultado DIAGNÓSTICO PRÉVIO IMC");
            Console.WriteLine("********************************");

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Categoria: {Categoria}");

            Console.WriteLine($"\n\nIMC Desejável: Entre 20 e 24");

            Console.WriteLine($"\n\rResultado IMC: {Imc.ToString("F2")}");

            Console.WriteLine($"\n\rRiscos: {ImcRisco}");

            Console.WriteLine($"\n\rRecomendações: {ImcRecomendacao}");
        }

        public static void LimparTela()
        {
            Console.Clear();
        }

        public static void ExibeMensagem(string mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
