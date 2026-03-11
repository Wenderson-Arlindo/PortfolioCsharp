using System;
using System.Collections.Generic;
using Agiota.Models;

namespace Agiota.Services;

class Sistema
{
    //variaveis importantes para cadrastar criente
    public static int Numeracao { get; private set; }
    static List<Dados> Pessoas = new List<Dados>();


    //cadastra pessoas e adiciona a lista de endividados
    public static void Anotar()
    {
        //variaveis
        string n;
        decimal v;
        decimal j = 0;

        Console.Clear();

        //pergunta e verifica o nome
        Console.Write("Nome: "); n = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(n) || int.TryParse(n, out int numero)) { Console.Clear(); Console.WriteLine("Nome invalido\n\n\n"); return; }


        //pegunta e verifica o valor
        Console.Write("Valor: ");
        if (!decimal.TryParse(Console.ReadLine(), out v) || v <= 0) { Console.Clear(); Console.WriteLine("Valor invalido\n\n\n"); return; }


        //calcula juros
        j = CalcularJuros(v);

        //Registra a pessoa
        Numeracao++;
        DateTime data = DateTime.Now;
        Dados pessoa = new Dados(Numeracao, n, v, j, data, data.AddMonths(1));

        Pessoas.Add(pessoa);

        //conclui o registro
        Console.Clear();
        Console.WriteLine($"{n} foi registrado com sucesso\n\n\n");
    }
    public static void Remover()
    {
        if (Pessoas.Count == 0) { Console.Clear(); Console.WriteLine("Lista vazia!\n\n\n"); return; }
        int op;

        Mostrar();

        Console.Write("Numero: ");
        if (!int.TryParse(Console.ReadLine(), out op) || op > Pessoas.Count || op <= 0) { Console.Clear(); Console.WriteLine("Valor invalido\n\n\n"); return; }


        Console.Clear();
        Console.WriteLine($"{Pessoas[op - 1].Nome} Removida com sucesso\n\n\n");
        Pessoas.RemoveAt(op - 1);
        for (int i = 0; i < Pessoas.Count; i++) { Pessoas[i].Numero = i + 1; }
        Numeracao--;
    }
    public static decimal CalcularJuros(decimal v)
    {
        return v * .4m;
    }
    //Mostrando as listas
    public static void Mostrar()
    {
        Console.Clear();
        //Verifica se a lista fa vazia
        if (Pessoas.Count == 0) { Console.WriteLine("Lista vazia!\n\n\n"); return; }
        foreach (var p in Pessoas)
        {
            Console.WriteLine($"{p.Numero} - {p.DataVencimento.ToString("dd/MM")} Cliente: {p.Nome} // R${p.Valor:F2} - R${p.Juros:F2}  ");
            Console.WriteLine(new string('-', 54));
        }
    }
    public static void pausar()
    {
        Console.WriteLine("Digite qualquer tecla...");
        Console.ReadKey();
    }
}