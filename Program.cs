using System;

class Program
{
    static void Main(string[] args)
    {
        // Produto 1
        Console.WriteLine("=== Cadastro do Produto 1 ===");
        Console.Write("Nome: ");
        string nome1 = Console.ReadLine();

        Console.Write("Preço unitário: ");
        double preco1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade: ");
        int qtd1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Desconto (%): ");
        double desc1 = Convert.ToDouble(Console.ReadLine());

        Produto p1 = new Produto(nome1, preco1, qtd1, desc1);

        // Produto 2
        Console.WriteLine("\n=== Cadastro do Produto 2 ===");
        Console.Write("Nome: ");
        string nome2 = Console.ReadLine();

        Console.Write("Preço unitário: ");
        double preco2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade: ");
        int qtd2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Desconto (%): ");
        double desc2 = Convert.ToDouble(Console.ReadLine());

        Produto p2 = new Produto(nome2, preco2, qtd2, desc2);

        // Exibir resultados
        Console.WriteLine("\n=== RESULTADOS ===");
        p1.ExibirDetalhes();
        p2.ExibirDetalhes();

        // Comparação
        if (p1.GetCustoFinal() > p2.GetCustoFinal())
        {
            Console.WriteLine("\nProduto com maior custo final: " + p1.GetNome());
        }
        else if (p2.GetCustoFinal() > p1.GetCustoFinal())
        {
            Console.WriteLine("\nProduto com maior custo final: " + p2.GetNome());
        }
        else
        {
            Console.WriteLine("\nOs dois produtos possuem o mesmo custo final.");
        }
    }
}