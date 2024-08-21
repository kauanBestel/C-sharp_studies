using System;

namespace HelloWorld
{
   abstract class Inimigo
   //tornala abstrada a torna "inutilizavel" e a unica forma de usar ela eh herdando suas propriedades em outra class
    {
        public int Hp;
        public string? nome;
        public int nivel;
        //se ao inves de "virtual void" eu usar "abstract" ele so via poder ser usado se for herdado, ele tambem nao teria um "corpo" {bla bla bla}
        public virtual void falaPadraoInimigo()
        {
            Console.WriteLine("se renda agora!");
        }
    }

    class Esqueleto : Inimigo
    {
        public Esqueleto()
        {
            Hp = 100;
            nivel = 1;
            nome = "esqueleto fragil";
        }

        public override void falaPadraoInimigo()
        {
            Console.WriteLine("esqueleto diz: ughh...");
        }

    }
  

    class Programa4
    {
        static void Main(string[] args)

        {
         Esqueleto esql1 = new Esqueleto();
            Console.WriteLine("um esqueleto aparece!\n");
            Console.WriteLine($"vida do esqueleto {esql1.Hp}\nnivel do esqueleto {esql1.nivel}");
            esql1.falaPadraoInimigo();
        }
    }
}