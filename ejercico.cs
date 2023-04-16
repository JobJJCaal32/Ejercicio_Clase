Console.WriteLine("escoja una de las opciones");

Console.WriteLine("1. ejercicio 1");
Console.WriteLine("2. ejercicio 2");
Console.WriteLine("3. ejercicio 3");

int opcion;

opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.Write(" escoja uno de los meses en forma de numero del 1 al 12:  ");
        int Op_meses;
       Op_meses= int.Parse(Console.ReadLine());
        switch (Op_meses)
        {
            case 1:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Enero");
                break;
            case 2:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Febrero");
                break;
            case 3:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Marzo");
                break;
            case 4:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Abril");
                break;
            case 5:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Mayo ");
                break;
            case 6:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Junio");
                break;
            case 7:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Julio");
                break;
            case 8:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Agosto");
                break;
            case 9:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Septiembre");
                break;
            case 10:
                Console.WriteLine("numero de mes {Op_meses}, nombre de mes Octubre");
                break;
            case 11:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Noviembre");
                break;
            case 12:
                Console.WriteLine($"numero de mes {Op_meses}, nombre de mes Diciembre");
                break;
            default:
                Console.WriteLine("Por favor elija una de las opciones");
                break;
        }
        break;
    case 2:
        string num1;
        int num2;
        Console.WriteLine("Ingrese un numero");
        num1 = Console.ReadLine();
        num2 = Convert.ToInt32(num1);

        if (num2 %2 == 0)
        {
            Console.WriteLine($"El numero que ingreso es par {num2}");
        }
        else
        {
            Console.WriteLine($"El numero que ingreso es impar {num2}");
        }
        break;
    case 3:
        Console.WriteLine("escoja una de las opciones par asaber cuanto va a ser su pago de estacionamiento");
        Console.WriteLine("1. Desde que entro hasto los 60 minustos");
        Console.WriteLine("2. Desde que pase la primera hora hasta las dos horas");
        Console.WriteLine("3. Desde de las dos horas en adelante");
        int horas = 0; 
        horas = int.Parse(Console.ReadLine());  
        if (horas == 1)
        {
            Console.WriteLine("El pago de estacionamiento por una hora o menos de ella es de: Q5.00");
        }else if(horas == 2)
        {
            Console.WriteLine("El pago de estacionamiento de mas de una hora o las dos horas es de: Q15.00");
        }
        else
        {
            Console.WriteLine("El pago de estacionamiento de mas de dos horas es de: Q40.00");
        }
        break;
    default:
        Console.WriteLine("No ha elejido ninguna de las opciones, vuelva a intentarlo");
        break;
}