using System;

namespace exercicios
{
    class ExerciseEighteen
    {
        public static void Eighteen(string[] args){
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "\nExercício 18.",
                "As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia.",
                "R$1,00 se forem compradas pelo menos 12.",
                "Escreva um programa que leia o número de maçãs compradas,",
                "calcule e escreva o custo total da compra."
            ));
        }
    }
}