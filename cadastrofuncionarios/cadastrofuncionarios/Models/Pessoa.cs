namespace cadastrofuncionarios.Models
{
    public class Pessoa
    {
        public int pessoaid { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public Esexo Sexo  { get; set; }

    }
    public enum Esexo
    {
        Masculino=1,
        Femino=2,

    }
}
