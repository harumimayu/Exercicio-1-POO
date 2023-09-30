using System;

class Aluno

///<summary>
///// Campos privados para armazenar os dados do aluno , privado nos dados pois não é necessario que ninguém altere essas informações.
///Somente os membros (métodos ou outros membros) da mesma classe têm acesso direto a esses campos.

{
	private string Nome;
	private int Matricula;
	private double NotaProva1;
	private double NotaProva2;
	private double NotaTrabalho;

	/// <summary>
	/// Iniciado a classe Aluno com os atributos
	/// Inicializando um objeto Aluno com valores padrão
	/// </summary>


	public Aluno()
	{
		Matricula = 0;
		Nome = "";
		NotaProva1 = 0.0;
		NotaProva2 = 0.0;
		NotaTrabalho = 0.0;
	}
	/// <summary>
	/// Construtor personalizado da classe Aluno
	/// Inicializa um objeto Aluno com valores específicos para matrícula e nome
	/// </summary>
	/// <param name="matricula">atribui o valor do parâmetro matricula (um número de matrícula passado como argumento ao construtor) 
	/// ao campo Matricula da instância atual do objeto Aluno.</param>
	/// <param name="nome">atribui o valor do parâmetro nome (o nome do aluno passado como argumento ao construtor) 
	/// ao campo Nome da instância atual do objeto Aluno.</param>
	/// 
	public Aluno(int matricula, string nome)
	{
		Matricula = matricula;
		Nome = nome;
		NotaProva1 = 0.0;
		NotaProva2 = 0.0;
		NotaTrabalho = 0.0;
	}
	/// <summary>
	/// Registra as notas das provas dos aluno.
	/// </summary>
	/// <param name="notaProva1">Nota da primeira prova.</param>
	/// <param name="notaProva2">Nota da segunda prova.</param>
	/// Métodos públicos para definir e recuperar os valores dos campos privados.

	public void SetNotas(double notaProva1, double notaProva2)
	{
		NotaProva1 = notaProva1;
		NotaProva2 = notaProva2;
	}

	/// <summary>
	/// Registra as notas dos trabalhos dos alunos.
	/// </summary>
	/// <param name="notaTrabalho">Nota do trabalho.</param>

	public void SetNotaTrabalho(double notaTrabalho)
	{
		NotaTrabalho = notaTrabalho;
	}

	/// <summary>
	/// Calcula a média final do aluno com base nas notas das provas e do trabalho.
	/// </summary>
	/// <returns>A média final do aluno.</returns>

	internal double CalcularMediaFinal()
	{
		
		double mediaProvas = (NotaProva1 + NotaProva2) * 2.5;
		double mediaTrabalho = NotaTrabalho * 2.0;
		double mediaFinal = (mediaProvas + mediaTrabalho) / 7.0;
		
		mediaFinal = Math.Round(mediaFinal, 2);
    
    return mediaFinal;
	}
	/// <summary>
	/// Os métodos "GetNome" e "Get Matricula" servem para que a classe "Program" obtenha as informações do aluno.
	/// Isso mantém os dados do aluno protegido de alterações externas.
	/// </summary>
	


	public string GetNome()
	{
		return Nome;
	}

	public int GetMatricula()
	{
		return Matricula;
	}

	/// <summary>
	/// Obrigada professora!!Você explica muito bem,estou tentando estudar mais para conseguir adicionar mais elementos, por enquanto ainda
	/// consigo raciocinar só o básico mesmo lendo a documentação muitas partes eu ainda complemento com outros códigos otimizados que vejo mas
	/// tento pensar e fazer o máximo sozinha conforme eu vou entendendo vou tentando adicionar mais elementos para adicionar mais complexidade. Obrigada!!! 
}

