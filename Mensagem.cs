namespace Aula31
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public Contato Destinatario {get; set;}

        public string Enviar( Contato _Nome){
            return $"Enviar '{Texto}' para {_Nome.Nome}";
        }

}
}