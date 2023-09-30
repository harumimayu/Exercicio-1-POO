class Program
{
	static void Main()
	{
		Aluno aluno1 = new Aluno(890860, "Carolina");
		aluno1.SetNotas(7.0, 6.0);
		aluno1.SetNotaTrabalho(4.0);

		double mediaAluno1 = aluno1.CalcularMediaFinal();

		Console.WriteLine($"Aluno: {aluno1.GetNome()}");
		Console.WriteLine($"Matrícula: {aluno1.GetMatricula()}");
		Console.WriteLine($"Média F: {mediaAluno1}");

		Aluno aluno2 = new Aluno(900096, "Neymar");
		aluno2.SetNotas(7.0, 6.0);
		aluno2.SetNotaTrabalho(4.0);

		double mediaAluno2 = aluno2.CalcularMediaFinal();

		Console.WriteLine($"Aluno: {aluno2.GetNome()}");
		Console.WriteLine($"Matrícula: {aluno2.GetMatricula()}");
		Console.WriteLine($"Média F: {mediaAluno2}");
	}
}
