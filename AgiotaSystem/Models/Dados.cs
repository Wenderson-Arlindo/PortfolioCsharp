using System;

namespace Agiota.Models;

class Dados
{
    public int Numero { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public decimal Juros { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataVencimento { get; set; }

    public Dados(int numero, string nome, decimal valor, decimal juros, DateTime dataa, DateTime dataf)
    {
        Numero = numero;
        Nome = nome;
        Valor = valor;
        Juros = juros;
        DataInicio = dataa;
        DataVencimento = dataf;
    }
}