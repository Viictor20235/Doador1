namespace cadastrofuncionarios.Models
{
    public class Funcionario:Pessoa 
    {
        public int Funcionarioid { get; set; }  
        public string Cargo { get; set; }
        public decimal Salario { get; set; }        
        public Edepartamento  Departamento { get; set; }    

    }
    public enum Edepartamento 
    {
        Publicidade =1,
        TI=2,
        Jurudico=3,
        outro=4,

    }

}
