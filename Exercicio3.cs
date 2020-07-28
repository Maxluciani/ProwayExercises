using System;

namespace exercicios
{
    class ExerciseThree
    {
        public static void Three(string[] args)
        {
            Console.WriteLine("\nExercício 3");
            Console.WriteLine("Imprimir todos os números ímpares menores de 200");
            for(int i = 0; i < 201; i++){
                if(i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }

            Console.WriteLine("******************* \nFim do exercício 3\n");
            Console.ReadLine();
        }
    }
}