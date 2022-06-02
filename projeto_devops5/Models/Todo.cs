using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_devops5.Models
{
    public class Todo
    {

        
        
        
        //public DateTime CreatedAt { get; set; }  = DateTime.Now;
        //public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
        

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


        [Required(ErrorMessage = "Informe o Login")]
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
