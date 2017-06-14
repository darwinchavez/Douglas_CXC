namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EstCta1
    {
        public int? CodigoCliente { get; set; }

        public int? Numero { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Fecha { get; set; }

        [StringLength(25)]
        public string NFactura { get; set; }

        public double? MFactura { get; set; }

        [StringLength(25)]
        public string NRecibo { get; set; }

        public double? MRecibo { get; set; }

        [StringLength(14)]
        public string TipoVenta { get; set; }

        public double? Saldo { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
