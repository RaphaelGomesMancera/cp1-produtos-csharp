using System;

public class Produto
{
    // Atributos privados
    private string nome;
    private double precoUnitario;
    private int quantidade;
    private double desconto;

    // Construtor
    public Produto(string nome, double precoUnitario, int quantidade, double desconto)
    {
        this.nome = nome;
        this.precoUnitario = precoUnitario;
        this.quantidade = quantidade;
        this.desconto = desconto;
    }

    // Método para calcular custo total
    public double CalcularCustoTotal()
    {
        return precoUnitario * quantidade;
    }

    // Método para calcular custo final (com desconto)
    public double CalcularCustoFinal()
    {
        double total = CalcularCustoTotal();

        if (total > 5000)
        {
            return total - (total * (desconto / 100));
        }

        return total;
    }

    // Método para exibir detalhes do produto
    public void ExibirDetalhes()
    {
        Console.WriteLine("\nProduto: " + nome);
        Console.WriteLine("Custo Total: R$ " + CalcularCustoTotal());
        Console.WriteLine("Custo Final: R$ " + CalcularCustoFinal());
    }

    // Getter para custo final (usado na comparação)
    public double GetCustoFinal()
    {
        return CalcularCustoFinal();
    }

    // Getter para nome
    public string GetNome()
    {
        return nome;
    }
}