poweshell
dotnet new mvc --auth Individual -o projeto_devops4 -f net6.0
dotnet new mvc --auth Individual -o C:\Users\Natanael\Desktop\projeto\projeto_tivit/projeto_devops4 -f net6.0
dotnet clean
dotnet build
dotnet add package Microsoft.VisualStudio.Web.CodeGereration.Desing
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet-aspnet-codegenerator controller -name TodoController -dc ApplicationDbContext -m Todo --useDefaultLayout --useSqlite --referenceScriptLibraries
dotnet tool install --global dotnet-ef
dotnet ef migrations add CreateTodoTable
dotnet ef database update


aplicação sempre rodando
dotnet watch run

Identity/Account/Register

"Data Source=DESKTOP-HK9S5K7\\MSSQLSERVER01; Initial Catalog=LanchesDatabase;Integrated Security=True"

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer(@"Data Source=DESKTOP-HK9S5K7\\MSSQLSERVER01;Database=projeto_devops3 ;Integrated Security=True"));

builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer(@"DESKTOP-HK9S5K7\\Natanael;Database=projeto_devops3"));

//(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=projeto_devops_2"));

program

using Microsoft.EntityFrameworkCore;
using projeto_devops3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=projeto_devops3"));



usuario


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace projeto_devops3.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um Nome")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Sexo")]
        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Informe o Cargo")]
        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        //[Column("Data")]
        //[Display(Name = "Data")]
        //public DateTime EnrollmentDate { get; set; }
        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

             



        [Required(ErrorMessage = "Informe a Cidade")]
        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o Endereço")]
        [Column("Endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        
        [Required(ErrorMessage ="Informe o Login")]
        [Column("login")]
        [Display(Name = "Login")]
        public string login { get; set; }


        [Required(ErrorMessage = "Informe um E-mail")]
        [Column("Email")]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Informe um email válido.")]
        public string Email { get; set; }

        
        [Column("Senha")]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

       

    }
}
