// tipos primitivos

var texto = "Testando";
Console.WriteLine(texto);

byte meuByte = 127;
sbyte outroByte = -127;

ushort idade = 72;
int outraIdade = 10;
long novaIdade = 55;

float valor = 2.500f;
double novoValor = 2.500;
decimal outroValor = 2.500m;

bool usuarioCadastrado = false;
bool pagamentoEfetuado = true;

char primeiraLetra = 'C';
char segundaLetra = 'D';

string primeiraPalavra = "Texto";
string segundaPalavra = "Novo texto";

object meuObjeto = 10;
object seuObjeto = 10.5;
object nossoObjeto = "10";

int? data = null;

// alias

int maisUmaIdade = 25; // alias
Int32 eitaOutraIdade = 25; // tipo

// valores padrões

/*
int => 0
float => 0
decimal => 0
bool => false
char => '\0'
string => ''
*/

// conversão de dados

/*

// caso possível - conversão implícita
float valor = 25.8f;
int outro = 25;
valor = outro;

// caso não possível
int outro = 25;
float valor = 25.8f;
valor = outro;

---
    --  conversões implícitas possíveis --
sbyte
    - short, int, long, float, double, decimal
byte
    - short, ushort, int, uint, long, ulong, float, double, decimal
short
    - int, long, float, double, decimal
ushort
    - int, uint, long, ulong, float, double, decimal
int
    - long, floart, double, decimal
uint
    - long, ulong, float, double, decimal
long
    - float, double, decimal
ulong
    - float, double, decimal
char
    - ushort, int, uint, long, ulong, float, double, decimal
float
    - double
---

*/

/*
// conversão explícita
int valor = 100;
uint outro = (uint)valor;
*/

/*
// parse
int inteiro = int.Parse("100");
*/

/*
// convert
int inteiro = Convert.ToInt32("100");
*/

// conversão implícita
int inteiro = 100;
float real = 25.5f;
real = inteiro;
Console.WriteLine(real);

// conversão explícita
int outroInteiro = 100;
float outroReal = 25.5f;
outroInteiro = (int)outroReal;
Console.WriteLine(outroInteiro);
// ou
string valorReal = real.ToString();
inteiro = int.Parse(valorReal);
Console.WriteLine(inteiro);
// ou
inteiro = Convert.ToInt32(real);

// operações aritméticos

/*
soma => +
subtração => -
multiplicação => *
divisão => /

** segue ordem de patênteses
** se o valor for real, será arredondadmento
*/

int valor1 = 2;
valor1 = 2 + 2; // soma
Console.WriteLine(valor1);
valor1 = 2 - 2; // subtração
Console.WriteLine(valor1);
valor1 = 2 * (2 - 3); // multiplicação com subtração (resolve parênteses primeiro)
Console.WriteLine(valor1);
valor1 = 2 / 2 + 5; // divisão com soma (resolve divisão primeiro)
Console.WriteLine(valor1);

// operadores de atribuição

/*
= => atribuição pura
+= => atribui somando
-= => atribui subtraindo
*= => atribui multiplicando
/2 => atribui dividindo
*/

int valor2 = 2;
valor2 = 3; // atribuição pura
Console.WriteLine(valor2);
valor2 += 3; // atribuição somando
Console.WriteLine(valor2);
valor2 -= 3; // atribuição subtraindo
Console.WriteLine(valor2);
valor2 *= 2; // atribuição multiplicando
Console.WriteLine(valor2);
valor2 /= 2; // atribuição dividindo
Console.WriteLine(valor2);

// operadores de comparação

/*
== => compara se é igual
!= => compara se é diferente
>  => compara se é maior
<  => compara se é menor
=> => compara se é maior ou igual
=< => compara se é menor ou igual

** Todos eles retornam true ou false, a depender da resolução lógica do contexto
*/

int valor3 = 2;
Console.WriteLine(valor3 == 2); // compara se é igual
Console.WriteLine(valor3 != 2); // compara se é diferente
Console.WriteLine(valor3 > 2); // compara se é maior
Console.WriteLine(valor3 < 2); // compara se é menor
Console.WriteLine(valor3 >= 2); // compara se é maior ou igual
Console.WriteLine(valor3 <= 2); // compara se é menor ou igual

// operadores lógicos

/*
and ou && => deve atender todas as condições 
or ou || => se atender uma condição retorna verdadeiro
not ou ! => compara se não é o valor passado e retorna true ou false, a depender da resolução lógica do contexto
*/

int valorQualquer = 12;
bool entre = (valorQualquer > 25) && (valorQualquer < 40);
Console.WriteLine(entre);
bool ou = (valorQualquer > 25) || (valorQualquer < 40);
Console.WriteLine(ou);
bool negacao = !(valorQualquer > 25);
Console.WriteLine(negacao);

// estrutura condicional

/*

// if:

aceita como valor entre parênteses uma comparação
composto por if, else, e else if
if para a condição atendida
else para a condição não atendida
else if para uma nova verificação de condição atendida

if() {
    ...
} else if() {
    ...
} else {
    ...
}
*/

int maisUmaVezAIdade = 18;
int maioridade = 21;
int idadeMaxima = 65;

if(maisUmaVezAIdade >= maioridade) {

    Console.WriteLine("Maioridade");

} else if(maisUmaVezAIdade >= idadeMaxima) {

    Console.WriteLine("Idoso");

} else {

    Console.WriteLine("Jovem demais");

}

/*

// switch

encadeia uma série de decisões.
break é necessário para a parada da estrutura

switch() {
    case "":
        ...;
        break;
    case "":
        ...;
        break;
    case "":
        ...;
        break;
    default:
        ...;
        break;
}

*/

bool? valorSwitch = true;
switch(valorSwitch) {
    case true:
        Console.WriteLine("verdadeiro");
        break;
    case false:
        Console.WriteLine("falso");
        break;
    default:
        Console.WriteLine("nulo");
        break;
}

// laços de repetição

/*
// for

repete uma estrutura de instruções sob determinada condição

são necessários 3 parâmetros:
    - contador
    - condição
    - incremento

for(var i = 0; i <= 5; i++) {
    ...
}
*/

for(var i = 0; i <= 5; i++) {
    
    Console.WriteLine("item: " + i);

}


/*
// while

repete uma estrutura de instruções sob determinada condição enquanto essa condição for verdadeira

é necessários uma condição verdadeira para o funcionamento

while(true){
    ...
}
*/

int valorWhile = 0;
while (valorWhile <= 5 ) {
    
    Console.WriteLine("Item: " + valorWhile);
    valorWhile += 1;

}

/*
// do-while

repete uma estrutura de instruções sob determinada condição enquanto essa condição for verdadeira
faz a execução da estrutura de instruçãoao menos uma vez

é necessários uma condição verdadeira para o funcionamento

do {
    ...
} while (true)
*/

int valorDoWhile = 0;
do {
    
    Console.WriteLine("Item: " + valorDoWhile);
    valorDoWhile = valorDoWhile + 1;

} while (valorDoWhile < 5);

// funções ou métodos

/*

agrupa um conjunto de instruções e os executa conforme o nome é invocado
recebe parametros personalizados e retorna valores de acordo com as instruções de dentro

static tipoDeRetorno nome(string parametro) {

    ...;
    return ...; //  caso não seja void
}

nome(parametro);

*/

// criando um método
static void MeuMetodo(string parametro) {

    // realizando uma instrução quando o método for chamado
    Console.WriteLine(parametro);

}

// invocando um método
MeuMetodo("C# é muito legal!");

// tipos de referência e tipos de valor

// tipo de valor acessa e armazena um valor na parte stack da memória

int x = 25; // instancia um valor na memória
int y = x; // faz uma cópia de x em y na memória
Console.WriteLine(x);
Console.WriteLine(y);
x = 32; // altera somente x
Console.WriteLine(x);
Console.WriteLine(y);

// tipo de referência acessa e armazena o endereço do valor na parte heap da memória
// depende do garbage collector para limpar o heap, nesse caso a referência é excluída da memória

var arr = new string[2];
arr[0] = "Item 1";
var arr2 = arr;
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

arr[0] = "Item alterado"; // altera as duas listas
Console.WriteLine(arr[0]);
Console.WriteLine(arr2[0]);

// structs

/*

// cria um tipo próprio e personalizado de objeto
// sempre é chamado com a palavra reservada new, e é quem instancia um tipo qualquer

struct nome {
    // propriedades

    // métodos
}

var variavel = new nome()

// exemplo com erro por conta da mudança de versão do C#
struct Produto {
    
    public Produto( int id, string nome, double preco) {

        Id = id;
        Nome = nome;
        Preco = preco;

    }

    public int Id;
    public string Nome;
    public float Preco;

    public double PrecoEmDolar(double dolar) {

        return Preco * dolar;
    }

}

var produto = new Produto(id=1, nome='qualquer', preco=5.0);

Console.WriteLine(produto.Preco);
*/

// enumeradores

/*
enum ENome {

    // codigo = 1;
    // codigoOutro = 2;
    // codigoNovo = 3;

}

// exemplo com erro por conta da mudança de versão do C#
enum ETipoProduto {

    produto = 1;
    servico = 2;

}

Console.WriteLine((int)ETipoProduto.produto);
Console.WriteLine((int)ETipoProduto.servico);

*/