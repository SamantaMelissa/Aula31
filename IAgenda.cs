using System.Collections.Generic;

namespace Aula31
{
    public interface IAgenda 
    {
        void Cadastrar(Contato _contato);
        
         void Excluir(string _contato);

         void Listar();
    }
}