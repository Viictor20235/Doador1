using cadastrofuncionarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace cadastrofuncionarios.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarFuncionario() // retorna a ação do resultado
        {
            return View(ListaDeFuncionario());
        }
        
      
        private List<Funcionario>  ListaDeFuncionario() // recebe 

        {
            Funcionario funcionario = new Funcionario();
            funcionario.nome = "joao";
            funcionario.idade=19;
            funcionario.Departamento = Edepartamento.Publicidade;
            funcionario.Sexo = Esexo.Masculino;
            funcionario.Cargo = "tester QA";
            funcionario.pessoaid = 1;
            funcionario.Funcionarioid = 1;  
            
            var list = new List<Funcionario>(); 
           
            list.Add(funcionario);
            return list;



           


            


        }
        


    } 
}
