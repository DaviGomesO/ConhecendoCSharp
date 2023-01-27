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
            string frase = "Hoje malhei glúteos!";

            Console.WriteLine(frase.Substring(0,4));
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