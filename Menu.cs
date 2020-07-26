using System;

namespace exercicios {
    class Exercicios {
        static void Main (string[] args)
        {
            int choice = 0;

            while(true){

                Console.WriteLine("Este projeto contém 18 Exercícios. \nDigite um número para ver a solução. \nDigite 0 para sair.");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice){
                    case 1:
                        ExerciseOne.One(null);
                        break;
                    case 2:
                        ExerciseTwo.Two(null);
                        break;
                    case 3:
                        ExerciseThree.Three(null);
                        break;
                    case 4:
                        ExerciseFour.Four(null);
                        break;
                    case 5:
                        ExerciseFive.Five(null);
                        break;
                    case 6:
                        ExerciseSix.Six(null);
                        break;
                    case 7:
                        ExerciseSeven.Seven(null);
                        break;
                    default:
                        break;
                }

                if(choice == 0){
                    break;
                }
            }
        }
    }
}