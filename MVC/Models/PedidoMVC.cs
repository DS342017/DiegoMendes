using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class PedidoMVC
    {
        [Key]
        public int IdPedido { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome do medicamento obrigatório", AllowEmptyStrings = false)]
        public string NomeMedicamento { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Quantidade obrigatória", AllowEmptyStrings = false)]
        public string QtdeMedicamento { get; set; }

        [Display(Name = "Código Cliente")]
        [Required(ErrorMessage = "Código do cliente obrigatório", AllowEmptyStrings = false)]
        public string CodCliente { get; set; }

        [Display(Name = "Data de entrega")]
        [Required(ErrorMessage = "Data de entrega obrigatória", AllowEmptyStrings = false)]
        [DataType(DataType.Date)]
        public string DataEntrega { get; set; }
    }
}