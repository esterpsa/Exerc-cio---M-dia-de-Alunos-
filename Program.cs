using System;

namespace Exerc_cio___M_dia_de_Alunos_
{
    class Program
    {
        static void Main(string[] args)
        {
             string [] nome = new string [10];
            int [] nota1  = new int [10];
            int [] nota2  = new int [10];
            int [] nota3  = new int [10];
            int [] nota4  = new int [10];
            int media = 0;
            int aprovado = 0;
            int reprovado = 0;
            int mediag = 0;
        

            Console.WriteLine("Lista de aprovados");
            Console.WriteLine("==================");

            //Entrada de notas

            for (var contador = 0; contador <=10; contador++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nome[contador] = Console.ReadLine();
                Console.WriteLine("Informe a 1º nota: ");
                nota1[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 2º nota: ");
                nota2[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 3º nota: ");
                nota3[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a 4º nota: ");
                nota4[contador] = int.Parse(Console.ReadLine());
                media= nota1[contador] + nota2[contador] + nota3[contador] + nota4[contador] /4;
                Console.WriteLine("A média do aluno é "+media);
                mediag = media /10;

                if(media >=7)
               {
                   Console.WriteLine("O aluno foi aprovado!");
                   aprovado = aprovado+1;
                   
               }
               else{
                   Console.WriteLine("O aluno foi reprovado");
                   reprovado = reprovado+1;
               }
            }
            
                Console.WriteLine("O total de alunos aprovados é: "+aprovado);
                Console.WriteLine("O total de alunos reprovados é: "+reprovado);
                Console.WriteLine("A média geral da sala é: "+mediag);
        }
    }
}
