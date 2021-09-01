using Domain.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authors
{
   public class Author
    {
        [StringLength(maximumLength: 10, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength:45, ErrorMessage ="El campo {0} no debe tener mas de {1} caracteres")]
        [FirstCapitalLetter]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 45, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres")]
        [FirstCapitalLetter]
        public string LastName { get; set; }
    }
}
