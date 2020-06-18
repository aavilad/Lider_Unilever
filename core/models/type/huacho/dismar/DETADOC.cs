using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class DETADOC {
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public string Producto { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecUnit { get; set; }
        public decimal? Igv { get; set; }
        public decimal PrecProm { get; set; }
        public string Estado { get; set; }
        public decimal Comision { get; set; }
        public decimal Costo { get; set; }
        public string TipoPrecio { get; set; }
        public decimal trangratuita { get; set; }
        public decimal? pdscto { get; set; }
        public decimal? totdscto { get; set; }
        public decimal percepcion { get; set; }
        public string lote { get; set; }
        public DateTime? fvctolote { get; set; }
        public decimal? detraccion { get; set; }
    }
}