using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo {0} é requirido!!")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe no máximo 50 caracteres")]
        [Display(Name = "Nome")]
        [Index("Departament_Name_Index", IsUnique = true)]

        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Telefone é requirido!!")]
        [MaxLength(50, ErrorMessage = "O campo Telefone recebe no máximo 50 caracteres")]
        [Display(Name = "Telefone")]
        //[Index("Departament_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo Endereço é requirido!!")]
        [MaxLength(50, ErrorMessage = "O campo Endereço recebe no máximo 50 caracteres")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "O campo Departamento é requirido!!")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo Cidade é requirido!!")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        public virtual Departaments Departaments { get; set; }
        public virtual City Cities { get; set; }
    }
}