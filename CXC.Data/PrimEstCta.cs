namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrimEstCta")]
    public partial class PrimEstCta
    {
        public int? CodigoCliente { get; set; }

        public int? Numero { get; set; }

        public double? DebeAnt { get; set; }

        public double? HaberAnt { get; set; }

        public double? SalAnt { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
