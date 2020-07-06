using System;


namespace Aula31
{
 class Program
    {
        static void Main(string[] args)
        {
             Agenda cont = new Agenda();

            Contato c1 = new Contato();

            c1.Nome = "Juju";
            c1.Telefone = "(11)96841-6308";

    
            Mensagem wpp = new Mensagem();
            wpp.Texto = "Qual a boa de hoje?";
            wpp.Destinatario = c1;

            cont.Cadastrar(c1);

            cont.Excluir("Juju");

            Console.WriteLine(wpp.Enviar(wpp.Destinatario));
            
            
        }
    }
}

