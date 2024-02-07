using CadastroDePessoasmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDePessoasmvc.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult listarPessoas ()  
        {
            //to do: conectar o banco de dados, como não temos
            //vamos criar dados fake
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa { Cpf = 111112453, DataNascimento = DateTime.Now.AddDays(-200), nome = "Victor", cor="Preta", sexo="Masculino", telefone= 11956842598});
            pessoas.Add(new Pessoa { Cpf = 111112411, DataNascimento = DateTime.Now.AddDays(-100), nome = "Emanuel", cor = "Branca", sexo = "Masculino", telefone = 11956847845 });
            pessoas.Add(new Pessoa { Cpf = 111118996, DataNascimento = DateTime.Now.AddDays(-150), nome = "Lurdes", cor = "Preta", sexo = "Feminino", telefone = 119568458 });


            return View(pessoas);

        }   
        public IActionResult CriarPessoa()
        {

            return View();
        }
    }
}
