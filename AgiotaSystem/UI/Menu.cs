using System;
using Agiota.Services;

namespace Agiota.UI;

public class Menu
{
    public static void Mostrar()
    {
        int op;
        //Sistema.p;
        Console.Clear();
        Console.WriteLine("1 - Ver Lista");
        Console.WriteLine("2 - Registrar");
        Console.WriteLine("3 - Divida quitada");
        Console.WriteLine("0- Sair");
        Console.Write(": ");
        if (!int.TryParse(Console.ReadLine(), out op) || op > 3 || op < 0) { Console.Clear(); Console.WriteLine("Escolha invalida\n\n\n"); return; }



        switch (op)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                Sistema.Mostrar();
                break;
            case 2:
                Sistema.Anotar();
                break;
            case 3:
                Sistema.Remover();
                break;
            default:
                Console.WriteLine("Opção invalida");
                return;
        }
    }
}