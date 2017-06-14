namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RepVenta
    {
        public int? CodigoCliente { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        [Key]
        [Column(Order = 0)]
        public int Numero { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? FechaTransaccion { get; set; }

        [StringLength(15)]
        public string NumDocumento { get; set; }

        public double? Monto { get; set; }

        [StringLength(15)]
        public string TipoTransaccion { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
