using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Departaments
    {
        [Key]
        public int DepartamentsId { get; set; }
        
        [Required (ErrorMessage="O campo {0} é requirido!!")]
        [MaxLength(50, ErrorMessage ="O campo Nome recebe no máximo 50 caracteres")]
        [Display (Name = "Nome")]
        [Index("Departament_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}