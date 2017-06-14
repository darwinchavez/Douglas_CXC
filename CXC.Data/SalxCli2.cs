namespace CXC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalxCli2
    {
        [Key]
        public int Numero { get; set; }

        public int? CodigoCliente { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Fecha { get; set; }

        [StringLength(25)]
        public string NFactura { get; set; }

        [Column(TypeName = "money")]
        public decimal? MFactura { get; set; }

        [StringLength(25)]
        public string NRecibo { get; set; }

        [Column(TypeName = "money")]
        public decimal? MRecibo { get; set; }

        [StringLength(14)]
        public string TipoVenta { get; set; }
    }
}
