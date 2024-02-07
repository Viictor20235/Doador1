namespace CadastroProduto.Models
{
    public class Produto:Base
    {
        public int ProdutoId { get; set; }
        public decimal Preco {  get; set; } 
        public int QuantidadeDisponivel { get; set; }
        public Ecor Cor { get; set; }
        public int Potencia { get; set; }   

    }
    public enum Ecor
    {
      Rosa=1,
      Vermelhor=2,
      Azul=3,
      Verde=4,

    }

}
