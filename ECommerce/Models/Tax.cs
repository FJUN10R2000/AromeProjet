using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Tax
    {
        [Key]
        [Display(Name = "Taxa Id")]
        public int TaxaId { get; set; }

        [Required(ErrorMessage = "O campo Categoria é requirido!!")]
        [Display(Name = "Descrição")]
        [Index("Category_Description_CompanyId_Index", 2, IsUnique = true)]
        [MaxLength(100, ErrorMessage = "O campo Nome recebe no máximo 100 caracteres")]
        public string Description { get; set; }

        [Display(Name = "Imposto")]
        [Required(ErrorMessage = "O campo Categoria é requirido!!")]
        [Range(0, 1, ErrorMessage = "Apenas valores de 0 a 1")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public double Rate { get; set; }

        [Required(ErrorMessage = "O campo Distribuidora é requirido!!")]
        [Index("Category_Description_CompanyId_Index", 1, IsUnique = true)]
        [Display(Name = "Distribuidoras")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Distribuidora")]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}