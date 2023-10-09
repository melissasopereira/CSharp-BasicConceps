namespace Classes
{
    internal class Telefone
    {
        public Telefone(string numero, string observacao)
        {
            Numero = numero;
            Observacao = observacao;
        }

        public string Numero { get; set; }
        public string Observacao { get; set; }

        public string Imprimir()
        {
            string mensagem = "";

            if(string.IsNullOrEmpty(Observacao))
                mensagem = $"Telefone : {Numero}";
            else
                mensagem = $"Telefone : {Numero} - Observação : {Observacao}";

            return mensagem;
        }
    }

    
}
