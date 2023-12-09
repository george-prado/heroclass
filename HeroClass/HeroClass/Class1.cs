using System;

class Hero
{
	private string[] types;
	private string[] attacks;
	private int _type;

	public string Name { get; set; }
	public int Age { get; set; }

	public Hero(string name, int age, int type, string[] types, string[] attacks)
	{
		Name = name;
		Age = age;
		this.types = types;
		this.attacks = attacks;
		_type = type % this.types.Length;
	}

	public string Type
	{
		get { return types[_type]; }
	}

	public string Attack
	{
		get { return attacks[_type]; }
	}

	public string PerformAttack()
	{
		return $"O {Type} atacou usando {Attack}";
	}

	public void Info()
	{
		Console.WriteLine($"Nome: {Name}, Idade: {Age}, Classe: {Type}");
	}
}

class Program
{
	static void Main()
	{
		int numberOfPlayers = 4;
		string[] types = { "mago", "guerreiro", "ladino", "arqueiro" };
		string[] attacks = { "magia", "espada", "adagas", "arco e flecha" };

		for (int i = 0; i < numberOfPlayers; i++)
		{
			Hero player = new Hero("NomeDeUsuárioTemporário", 0, i, types, attacks);
			Console.WriteLine(player.PerformAttack());
			player.Info();
		}
	}
}