using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace Aula31
{
    public class Agenda : IAgenda

    {
        public List<Agenda> Cadastro{ get; set;}

        private const string PATH = "Database/arquivo.csv";

        public Agenda(){

            // Solução do desafio
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Cria o arquivo caso não exista
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        

        public void Cadastrar(Contato _contato)
        {
            var linha = new string[] { PrepararLinhaCSV(_contato) };
            File.AppendAllLines(PATH, linha);
        }

        public string Separar(string dado)
        {
           
            return dado.Split("=")[1];
        }

        public void Listar()
        {
            List<Agenda> lista = new List<Agenda>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {

                string[] dado = linha.Split(";");

                Contato pessoa = new Contato();
                pessoa.Nome = Separar(dado[0]);
                pessoa.Telefone = ( Separar(dado[1]) );

                lista.Add(pessoa);
            }

      //  lista = lista.OrderBy(y => y.lista).ToList();
        
        }


        public void Excluir(string  _contato) {

        List<string> linhas = new List<string>(); 
         
        using(StreamReader arquivo = new StreamReader(PATH)){
              string linha;
        while((linha = arquivo.ReadLine()) != null){

                  linhas.Add(linha);
              }
          }
        
        }
    


        private string PrepararLinhaCSV( Contato _nome){

                return $"Nome do contato: {_nome.Nome} / Número do contato: {_nome.Telefone}";

        }
    }
}