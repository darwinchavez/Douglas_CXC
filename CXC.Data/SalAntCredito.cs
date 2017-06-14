namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalAntCreditos")]
    public partial class SalAntCredito
    {
        [Key]
        [Column(Order = 0)]
        public int Numero { get; set; }

        public int? CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaCredito { get; set; }

        [StringLength(15)]
        public string Num_Factura { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
