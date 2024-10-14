using System;

class Cachorro
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Cachorro(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void ShowIdade()
    {
        Console.WriteLine($"A idade do cachorro é: {Idade} anos.");
    }

    public void ImprimirNome()
    {
        Console.WriteLine($"O nome do cachorro é: {Nome}");
    }
}

class CachorroGrande : Cachorro
{
    private string tamanho;

    public CachorroGrande(string nome, int idade, string tamanho) : base(nome, idade)
    {
        this.tamanho = tamanho;
    }

    public override void ShowIdade()
    {
        Console.WriteLine($"Este é um cachorro grande. A idade dele é: {Idade} anos.");
    }

    public void MostrarTamanho()
    {
        Console.WriteLine($"O tamanho do cachorro grande é: {tamanho}.");
    }
}

class CachorroPequeno : Cachorro
{
    public CachorroPequeno(string nome, int idade) : base(nome, idade) { }

    public override void ShowIdade()
    {
        Console.WriteLine($"Este é um cachorro pequeno. A idade dele é: {Idade} anos.");
    }
}

class Program
{
    static void ChamarShowIdade(Cachorro cachorro)
    {
        cachorro.ShowIdade();
    }

    static void Main(string[] args)
    {
        // Criando os objetos
        Cachorro cachorro = new Cachorro("Rex", 5);
        CachorroPequeno cachorroPequeno = new CachorroPequeno("Bolinha", 2);
        CachorroGrande cachorroGrande = new CachorroGrande("Thor", 8, "Grande");

        // Imprimindo atributos e métodos de cada classe
        Console.WriteLine("=== Cachorro ===");
        cachorro.ImprimirNome();
        ChamarShowIdade(cachorro);

        Console.WriteLine("\n=== Cachorro Pequeno ===");
        cachorroPequeno.ImprimirNome();
        ChamarShowIdade(cachorroPequeno);

        Console.WriteLine("\n=== Cachorro Grande ===");
        cachorroGrande.ImprimirNome();
        cachorroGrande.MostrarTamanho();
        ChamarShowIdade(cachorroGrande);
    }
}
