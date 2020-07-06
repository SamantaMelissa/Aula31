namespace Aula31
{
    public class Mensagem
    {
        public string Texto { get; set; }

        public Contato Destinatario {get; set;}

        public string Enviar( string Nome){
            return $"Enviar '{Texto}' para {Destinatario}";
        }

}
}