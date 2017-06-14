namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TSaldoAnterior")]
    public partial class TSaldoAnterior
    {
        public int? CodigoCliente { get; set; }

        public double? SalAntCre { get; set; }

        public double? SalAnt { get; set; }

        public double? SaldoAnterior { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
