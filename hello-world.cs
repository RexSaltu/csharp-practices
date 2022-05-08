using System;

public class GFG {

    static public void Main()
    {
        Console.WriteLine("Hello World!");
        decimal num1; 
        decimal num2;
        int opcion = 0;
        
        while(opcion == 0){
            Console.WriteLine("que quieres hacer");
            Console.WriteLine("1. sumar");
            Console.WriteLine("2. restar");
            Console.WriteLine("3. multiplicar");
            Console.WriteLine("4. dividir");
            opcion=int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("ingrese el numero 1 ");
        num1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("igrese el numero 2");
        num2 = decimal.Parse(Console.ReadLine());
        if(opcion == 1){
            Console.WriteLine("el resultado de la suma es: " + sumar(num1, num2));
        }
        if(opcion == 2){
            Console.WriteLine("el resultado de la resta es: " + resta(num1, num2));
        }
          if(opcion == 3){
            Console.WriteLine("el resultado de la resta es: " + multiplicacion(num1, num2));
        }
          if(opcion == 4){
            Console.WriteLine("el resultado de la resta es: " + dividir(num1, num2));
        }
    }
    static public decimal sumar(decimal num1 ,decimal num2){
        return num1 + num2;
    }
    static public decimal resta(decimal num1 ,decimal num2){
       return num1 - num2; 
    }
    static public decimal multiplicacion(decimal num1 ,decimal num2){
       return num1 * num2; 
    }
    static public decimal dividir(decimal num1 ,decimal num2){
        return num1 / num2; 
    }

}