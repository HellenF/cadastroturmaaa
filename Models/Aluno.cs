
//nome ok -  matricula ok- data de nascimento ok -  idade (calculada a partir da data atual) ok - 
//data de nascimento) ok - turma ok 


using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace cadastroturmaa.Models
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [Required ( ErrorMessage= " Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "nome do aluno  ")]
        [MinLength(2, ErrorMessage = "Este campo deve conter no maximo 20")]

        public string Nome{ get; set;}//nome

        [MaxLength(20, ErrorMessage = " Nome Errado ")]
        public string Description { get; set;}
        public int Id { get; internal set; }

        public int matricula1{ get; set; } //matricula

       

        //[Required(ErrorMessage = "Este campo é obrigatorio")]
        //[Range(1, int.MaxValue, ErrorMessage = "matricula invalida")]
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        


    }


}





