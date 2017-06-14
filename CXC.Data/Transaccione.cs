namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaccione
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Numero { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaTransaccion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string NumDocumento { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string TipoTransaccion { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
