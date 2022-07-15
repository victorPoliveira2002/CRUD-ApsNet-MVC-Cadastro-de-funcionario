using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNet.Models
{
    public class Employee               //Classe dos funcionarios
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage ="Este campo é de preenchimento obrigatório!")]      // "Required" torna o campo "Não nullo", adicionei o "ErrorMessage" para dizer uma mensagem em portugues informando o usuario da obrigatoriedade"
        [DisplayName("Nome")]               // Nome a ser exibido no Display da aplicação
        public string FullName { get; set; }


        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matricula")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatiorio!")]
        public string EmpCode { get; set; }


        [Column(TypeName = "nvarchar(60)")]
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio!")]
        public string Position { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Localização")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatorio!")]
        public string OfficeLocaliton { get; set; }
       
    }

}
