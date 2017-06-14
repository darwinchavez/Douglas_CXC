namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RdeFactura
    {
        public int? CodigoCliente { get; set; }

        [StringLength(60)]
        public string Nombres { get; set; }

        [StringLength(60)]
        public string Apellidos { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaTransaccion { get; set; }

        [StringLength(25)]
        public string NumDocumento { get; set; }

        public double? Monto { get; set; }

        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
