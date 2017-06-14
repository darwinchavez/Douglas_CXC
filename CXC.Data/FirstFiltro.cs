namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FirstFiltro")]
    public partial class FirstFiltro
    {
        [Key]
        [Column(Order = 0)]
        public int Numero { get; set; }

        public int? CodigoCliente { get; set; }

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

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
