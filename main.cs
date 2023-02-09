using System;


  class Program {
    public static void Main (string[] args) 
  {

    Double notaf,nota1,nota2,nota3,exercicios;
    String entrada;
    
    
    Console.WriteLine ("nota 1: ");
    
      entrada = Console.ReadLine();
   nota1 = Double.Parse(entrada);

     Console.WriteLine(" nota 2: ");
    
      entrada = Console.ReadLine ();
    nota2 = Double.Parse(entrada);

     Console.WriteLine(" nota 3: ");
    
      entrada = Console.ReadLine ();
    nota3 = Double.Parse(entrada);

    Console.WriteLine(" Digite a Média dos Exércicios: ");
    entrada = Console.ReadLine ();
    exercicios = Double.Parse(entrada);

    notaf = (nota1 + nota2 + nota3 + exercicios) / 7;

    if (notaf >=9)
    {
      Console.WriteLine("PONTO A");
    }
    if (notaf <7.5 && notaf >= 9 )
    {
      Console.WriteLine("PONTO B");
      }
     if (notaf >= 6 && notaf <7.5 )
    {
     Console.WriteLine("PONTO C");  
    }
    if (notaf <6)
    {  
      Console.WriteLine("PONTO D"); 
      }
 
    }  
  }
 