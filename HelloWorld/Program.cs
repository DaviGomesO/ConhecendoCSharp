//chamar um espaço criado que contem classes e métodos
using Aluno;

namespace PrimeirosPassos
{
    public class Tipos
    {
        public void ConhecendoTipos()
        {
            int i = 50;

            float f = 15.6f;

            double d = 20.7;

            decimal dm = 14.6m;

            bool b = true;

            char c = 'A';

            string s = "Davi";

            //atribuição implicita
            var cidade = "Russas";
            var idade = 30;

            //atribuição que negam a alteração de uma variável

            const string pais = "Brasil";

            //conversão explicita
            f = (float)dm;

            Console.WriteLine(f);
            Console.WriteLine(s);
        }

        public void ConhecendoMaisString()
        {
            string frase = "Hoje malhei glúteos!!!!!";

            //Console.WriteLine(frase.Substring(0,4));

            Console.WriteLine(frase.Replace("glúteos", "panturrilha e abdominal"));
            //Remove espaços no inicio e no fim e caracteres
            Console.WriteLine(frase.Trim());
            Console.WriteLine(frase.TrimEnd());
            Console.WriteLine(frase.TrimStart());
            Console.WriteLine(frase.Trim('!'));

            string cpf = "345678910";

            //preencher string a esquerda
            Console.WriteLine(cpf.PadLeft(11, '0'));

            //concatenar strings
            string frase2;
            frase2 = frase.Trim('!') + ", panturrilha e abdominal";

            Console.WriteLine(frase2);

            //ToUpper deixa a string totalmente em caixa alta (Maiusculo)
        }
    }

    public class Operadores
    {
        public void ConhecendoOperadores()
        {
            //Operadores Aritméticos
            int soma = 52 + 4;
            int subtração = 6-8;
            int produto = 7*5;
            int divisao = 36/3;

            //Operadores Relacionais
            string nome = "Davi";
            string sobrenome = "Gomes";

            bool resp1 = nome == sobrenome;
            bool resp2 = !(nome== sobrenome);

            Console.WriteLine(resp2);

            //Operadores Lógicos
            //&& e ||
        }
    }

    public class Estruturas
    {
        public void Decisao()
        {
            const string APROVADO = "Aprovado!";
            const string REPROVADO = "Reprovado!";
            const string RECUPERAR = "Recuperação!";

            Console.WriteLine("Digite a nota final: ");
            decimal nota = Convert.ToDecimal(Console.ReadLine());

            if(nota >= 5)
            {
                Console.WriteLine(APROVADO);
            }else if (nota >= 4 && nota < 5)
            {
                Console.WriteLine(RECUPERAR);
            }
            else
            {
                Console.WriteLine(REPROVADO);
            }

            /*
             switch (variavel)
            {
                case valor1:
                    Comando;
                    break;
                default:
                    Comando;
                    break;
            }
             
             */
        }

        public void Repeticao()
        {
            /*while (condicao)
            {
                comando;
            }
            
            for(variavel; condicao; incremento){
                Comando;
            }
            *
            *foreach trabalha em cima de listas:
            *foreach(tipo variavel in lista){
            *   Comando;
            *}
            *
            */
        }

        public void Colecoes()
        {
            //utilizar array precisa definir o tipo e a capacidade, List apenas o tipo
            int[] numeros = new int[5];

            List<int> listNumeros = new List<int>();
            // adicionar elementos com .Add, contar os elementos com .Count, e remover elementos com .Remove
            //Limpar lista com .Clear, recuperar uma posição com .ElementAt

            //Dictionary se define a chave e o valor
            Dictionary<int, string> estados = new Dictionary<int, string>();
            estados.Add(1, "CE");

            //.ConstainsKey confere se uma chave já existe, e TryGetValue verifica se uma chave existe e atribui o valor a uma variavel

            //Queue tem o conceito de FIFo,  a ordem que insere os elementos, é a ordem que sai, não trabalha com indice
            Queue<int> lista = new Queue<int>();
            //.Enqueue insere os elementos e o .Dequeue remove os elementos, .Peek retorna o primeiro elemento da lista

            //Stack segue o LIFO, último a entrar e primeiro a sair
            Stack<int> stack = new Stack<int>();
            //.Push insere os elementos, .Pop() remove o próximo elemento da lista. .Peek e .Count

            //SortedList define a chave o valor de tal maneira que se ordene de acordo com a chave
            SortedList<int, string> nomes = new SortedList<int, string>();
            //trabalha igual o Dictionary
        }
    }

    class Program
    {
        static void Main()
        {
            Tipos tipos = new Tipos();
            Operadores oper = new Operadores();

            tipos.ConhecendoTipos();
            tipos.ConhecendoMaisString();
            oper.ConhecendoOperadores();

            
        }
    }
}