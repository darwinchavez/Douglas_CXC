namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistrosxCliente")]
    public partial class RegistrosxCliente
    {
        [Key]
        public int Numero { get; set; }

        public int? CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaTransaccion { get; set; }

        [StringLength(15)]
        public string NumDocumento { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string TipoTransaccion { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
