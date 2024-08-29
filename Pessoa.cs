namespace SaveToXmL
{
    public class Pessoa
    {
        public string? Nome{get;set;}
        public string? Sobrenome{get;set;}
        public string? Cpf{get;set;}
        public string? Escolaridade{get;set;}
        public decimal RendaMensal{get;set;}

        public override string ToString()
        {
            return $"Nome:{this.Nome} - Sobrenome:{this.Sobrenome} "+ 
            $"Cpf:{this.Cpf} - Escolaridade:{this.Escolaridade} - Renda{this.RendaMensal}";
        }
    }
}