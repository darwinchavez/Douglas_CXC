namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalAntAbonos")]
    public partial class SalAntAbono
    {
        [Key]
        public int Numero { get; set; }

        public int? CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaAbono { get; set; }

        [StringLength(15)]
        public string Num_Recibo { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string Tipo { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
