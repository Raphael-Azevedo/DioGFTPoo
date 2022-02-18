using System;
using DioPOO.src.Entities.Heroes;

namespace DioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introdução ao game
            System.Console.WriteLine("Seja bem vindo ao Ragnarok POO");
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("            MENU");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Iniciar o Jogo");
            System.Console.WriteLine("2 - Descrição do Jogo");
            System.Console.WriteLine("3 - Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            while (opcaoUsuario != "3")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Start();
                        break;
                    case "2":
                        System.Console.WriteLine("Jogo criado para estudo de POO, como projeto da DIO!");
                        break;
                    default:
                        System.Console.WriteLine("Valor Inválido, Por favor digite sua opção novamente:");
                        break;
                }
                opcaoUsuario = Console.ReadLine();
            }
        }

        public static void Start()
        {
            var Arus = new Knight("Arus", 23, "Cavaleiro", 469, 72, "Lança do Trovão");
            var Jennica = new Priest("Jennica", 23, "Sacerdotiza", 325, 474, "Cajado Sagrado");
            var Topapa = new Monk("Topapa", 23, "Monge", 106, 611, "Luvas da Morte");
            var Wedge = new Ninja("Wedge", 23, "Ninja", 292, 89, "Adaga Envenenada");

            System.Console.WriteLine();
            System.Console.WriteLine("Seu grupo: ");
            System.Console.WriteLine();
            System.Console.WriteLine(Arus);
            System.Console.WriteLine(Jennica);
            System.Console.WriteLine(Topapa);
            System.Console.WriteLine(Wedge);
            System.Console.WriteLine();
            Thread.Sleep(1000);
            System.Console.WriteLine(Arus.Attack());
            System.Console.WriteLine(Arus.Bash());
            System.Console.WriteLine(Arus.BrandishSpear());
            System.Console.WriteLine(Arus.Spearstab());
            System.Console.WriteLine(Arus.SwordMastery());
            System.Console.WriteLine(Jennica.Attack());
            System.Console.WriteLine(Jennica.Bless());
            System.Console.WriteLine(Jennica.Heal());
            System.Console.WriteLine(Jennica.HealAll());
            System.Console.WriteLine(Jennica.Protect());
            System.Console.WriteLine(Topapa.Attack());
            System.Console.WriteLine(Topapa.Foco());
            System.Console.WriteLine(Topapa.Heal());
            System.Console.WriteLine(Topapa.Protect());
            System.Console.WriteLine(Topapa.Storm());
            System.Console.WriteLine(Wedge.Attack());
            System.Console.WriteLine(Wedge.FinalStrike());
            System.Console.WriteLine(Wedge.LightningCrash());
            System.Console.WriteLine(Wedge.ThrowHuumaShuriken());
            System.Console.WriteLine(Wedge.ThrowKunai());

        }

    }
}