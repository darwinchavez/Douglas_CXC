namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RepTarjeta
    {
        public int? CodigoCliente { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        public int? Numero { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaIngreso { get; set; }

        [StringLength(15)]
        public string Num_Lote { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string Tipo { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
