//titulo da turma - quantidade de alunos - idade.média aluno

using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace cadastroturmaa.Models
{
    
    public class Turma
    {
        [Key]
        public int Id{ get; set;}

       
        public string Description {get;set;}

        //[Required(ErrorMessage = "Este campo é obrigatorio")]
        //Range(1, int.MaxValue, ErrorMessage = " O numero da turma ")]
        public int QtdAluno {get;set;}// quantidade de alunos

        //[Required(ErrorMessage = "Este campo é obrigatorio")]
        //[Range(1, int.MaxValue, ErrorMessage = "Categorio invalida")]
        //QtdAluno = QtdAluno;

        //IdadeMediaAlunos

        public int Idade {get;set;}// idade média aluno

        //[Required(ErrorMessage = "Este campo é obrigatorio")]


        //media = (idadeAlunos + QtdAluno ) / 2 



    }


    
}



