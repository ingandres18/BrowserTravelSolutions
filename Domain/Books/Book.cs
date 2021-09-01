using Domain.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Books
{
   public class Book
    {
        [StringLength(maximumLength: 13, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Key]
        public int ISBN { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 45, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [FirstCapitalLetter]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 500, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        public string Synopsis { get; set; }
        public string N_Pages { get; set; }
    }
}
