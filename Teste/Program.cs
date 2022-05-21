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

