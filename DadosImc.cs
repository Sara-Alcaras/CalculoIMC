using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    public class DadosIMC
    {
        public static float Imc { get; set; }
        public static string ImcRisco { get; set; }
        public static string ImcRecomendacao { get; set; }


        public static void CalculaIMC(float peso, float altura) // Método que faz o calculo do IMC
        {
            Imc = peso / (altura * altura);
        }

        public static void VerificaIMC(float imc) // Método que verifica o resultado do IMC e retorna recomendação e risco conforme o calculo
        {
            switch (imc)
            {
                case < 20:
                    ImcRecomendacao = "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional";
                    ImcRisco = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
                    break;
                case >= 20 and < 25:
                    ImcRecomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos.";
                    ImcRisco = "Seu peso está ideal para suas referências.";
                    break;
                case >= 25 and < 30:
                    ImcRecomendacao = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante";
                    ImcRisco = "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                    break;
                case >= 30 and < 35:
                    ImcRecomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
                    ImcRisco = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                    break;
                case > 35:
                    ImcRecomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino).";
                    ImcRisco = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                    break;
            }
        }
    }
}
