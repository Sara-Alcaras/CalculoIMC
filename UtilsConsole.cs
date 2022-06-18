namespace CalculoIMC
{
    internal class UtilsConsole : Usuario
    {
        public static void Inicializacao() // Inicia o programa com a primeira mensagem
        {

            Console.WriteLine("Olá! Seja bem-vindo. Insira seus dados para calcular o DIAGNÓSTICO PRÉVIO IMC");
            Console.WriteLine("*****************************************************************************");

        }

        public static void Fim() // Método que retorna os dados na tela
        {
            ExibeMensagem("Resultado DIAGNÓSTICO PRÉVIO IMC");
            ExibeMensagem("********************************");

            ExibeMensagem($"Nome: {Nome}");
            ExibeMensagem($"Sexo: {Sexo}");
            ExibeMensagem($"Idade: {Idade}");
            ExibeMensagem($"Altura: {Altura}");
            ExibeMensagem($"Peso: {Peso}");
            ExibeMensagem($"Categoria: {Categoria}");

            ExibeMensagem($"\n\nIMC Desejável: Entre 20 e 24");
            ExibeMensagem($"\n\rResultado IMC: {Imc.ToString("F2")}");
            ExibeMensagem($"\n\rRiscos: {ImcRisco}");
            ExibeMensagem($"\n\rRecomendações: {ImcRecomendacao}");

            ExibeMensagem("\n\r**********************************************************************************");

        }

        public static void ExibeMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public static void LimparTela()
        {
            Console.Clear();
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

        public static string CapturaDadoDigitado() // Método para entrada de dado
        {
            return Console.ReadLine();
        }

        public static bool VerificaContinuidade() // Método para validar a continuidade da execução dos calculos
        {
            bool eValido = false;
            string opcaoEscolhida = String.Empty;

            ExibeMensagem("\n\rDeseja calcular novamente?\n1- Sim\n2- Não\n\r");

            var opcoes = new[] { "1", "2" }; // array para armazenar as opcoes validas

            while (!eValido)
            {
                opcaoEscolhida = CapturaDadoDigitado(); // entrada de dado
                // se a opcao escolhida estiver dentro do array com as opcoes validas e for igual a um, é uma opcao valida
                eValido = opcoes.Any(opcaoEscolhida.Contains) && opcaoEscolhida.Length == 1; 

                switch(opcaoEscolhida) // se for uma opcao valida, define opcao escolhida para um booleano em string
                {
                    case "1":
                        opcaoEscolhida = "true";
                        break;
                    case "2":
                        opcaoEscolhida = "false";
                        break;
                }

                if (!eValido) //se for uma opcao invalida, exibe mensagem e solicita novamente entrada de dado
                    Erro.ExibeErro(TipoDado.ExibirNovamente);
                else
                {
                    eValido = true; // se for opcao valida, sai do laço e limpa a tela
                    
                }

            }
            return bool.Parse(opcaoEscolhida); // converte a string em booleano
        }

        public static void FinalizacaoConsole() 
        {
            //Finaliza o console aberto automaticamente caso o modo debug estiver configurado
            //ou caso estiver sendo executado atraves do executavel
            Environment.Exit(1);
        }
    }
}
