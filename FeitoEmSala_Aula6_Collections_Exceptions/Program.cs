// See https://aka.ms/new-console-template for more information
using FeitoEmSala_Aula6_Collections_Exceptions;
using ExemploInternal;
using System.Collections.Generic;
using System.Collections;

Console.WriteLine("Hello, World!");

//Exemplo Internal
//var teste = new ExemploInternal.ExemploInternal();
//teste.MyProperty = 1;


//Herança de Construtor

//Protect
var animal = new Animal();
//animal.TemPelo; //Funciona semelhante ao private e não permite visualizar a propriedade

var gato = new Gato();
//gato.DefinirTemPelo();


//Encapsulamento
var carro = new Carro();
//carro.cor; //Está inacessível por estar encapsulado




//Exemplo do coleção do tipo Array
string[] nomes = new string[10]; //Array tem tamanho fixo - vou 0 à 9
nomes[0] = "Nome Aluno";


//Exemplo de coleção do tipo List
List<string> nomesList = new List<string>();
nomesList.Add("Leo Yuuki");
nomesList.Add("Enzo");


//Exemplo de coleção do tipo Dictionary
//Tenho mais 2 mil registros
//Vamos imaginar que essa lista é carregada automaticamente na empresa
//Lista Fixa
List<Alunos> nomesAlunosList = new List<Alunos>();
nomesAlunosList.Add(new Alunos { Nome = "Leo Blanco", Idade = 45 });
nomesAlunosList.Add(new Alunos { Nome = "Prof Doug", Idade = 70 });
nomesAlunosList.Add(new Alunos { Nome = "Prof Gui", Idade = 16 });

//Prof Thiago pediu pra vc pegar a idade do prof Guilherme
var gui = nomesAlunosList.FirstOrDefault(aluno => aluno.Nome.Equals("Prof Gui"));
Console.WriteLine(gui.Idade);

Dictionary<string, int> alunosEIdades = new Dictionary<string, int>();
alunosEIdades.Add("Leo Blanco", 45);
alunosEIdades.Add("Prof Doug", 70);
alunosEIdades.Add("Prof Gui", 16);

Console.WriteLine(alunosEIdades["Prof Gui"]);


//Exemplo de coleção do tipo conjunto
List<string> nomesConjuntoLista = new List<string>();
nomesConjuntoLista.Add("Leo Blanco");
nomesConjuntoLista.Add("Mirely");
nomesConjuntoLista.Add("Juan");

if (!nomesConjuntoLista.Any(x => x.Equals("Leo Blanco")))
    nomesConjuntoLista.Add("Leo Blanco");

HashSet<string> nomesConjunto = new HashSet<string>();
nomesConjunto.Add("Leo Blanco");
nomesConjunto.Add("Mirely");
nomesConjunto.Add("Juan");
nomesConjunto.Add("Leo Blanco"); //Não permite duplicidade
//Não vai dar erro, mas tbm não adicionar o registro duplicado

//Exemplo pilha
Stack<int> valoresPilha = new Stack<int>();
valoresPilha.Push(1);
valoresPilha.Push(2);
valoresPilha.Push(3);

valoresPilha.Pop(); //Vai me retornar o valor 3 que foi o último inserido

//Exemplo Fila
Queue<int> valoresFila = new Queue<int>();
valoresFila.Enqueue(1);
valoresFila.Enqueue(2);
valoresFila.Enqueue(3);

valoresFila.Dequeue(); //Vai me retornar o valor 1 que foi o primeiro inserido



//Exemplo ArrayList
ArrayList minhaLista = new ArrayList();
minhaLista.Add("Nome do meu Aluno");
minhaLista.Add(15);
minhaLista.Add(true);
minhaLista.Add(16);
minhaLista.Add(false);
minhaLista.Add(new object());
minhaLista.Add(valoresFila);