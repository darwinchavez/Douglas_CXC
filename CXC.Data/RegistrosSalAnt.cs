namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegistrosSalAnt")]
    public partial class RegistrosSalAnt
    {
        public int? CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaTransaccion { get; set; }

        [StringLength(15)]
        public string TipoTransaccion { get; set; }

        public double? Monto { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
