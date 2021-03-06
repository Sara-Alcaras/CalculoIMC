namespace CalculoIMC
{
    public static class Erro
    {
        public static void ExibeErro(TipoDado tipoErro) // Metodo para exibir mensagens de erro conforme o tipo do dado informado
        {
            string mensagemErro;
            switch (tipoErro)
            {
                case TipoDado.Nome:
                    mensagemErro = "\nNome Inválido! \r\nInforme seu nome novamente: ";
                    break;
                case TipoDado.Sexo:
                    mensagemErro = "\nSexo Inválido! \r\nInforme seu sexo novamente: ";
                    break;
                case TipoDado.Idade:
                    mensagemErro = "\nIdade Inválida! \r\nInforme sua idade novamente: ";
                    break;
                case TipoDado.Altura:
                    mensagemErro = "\nAltura Inválida! \r\nInforme sua altura novamente: ";
                    break;
                case TipoDado.Peso:
                    mensagemErro = "\nPeso Inválido! \r\nInforme seu peso novamente: ";
                    break;
                case TipoDado.ExibirNovamente:
                    mensagemErro = "\nOpção Inválida! \r\nInforme uma opção válida: ";
                    break;

                default:
                    mensagemErro = "\nOcorreu um erro desconhecido!";
                    break;

            }
            Console.Write(mensagemErro);
        }
    }
}
