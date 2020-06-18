using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class Movimiento {
        public string Codprod { get; set; }
        public string tipoing { get; set; }
        public string NumDoc { get; set; }
        public string TipDoc { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? cantidad { get; set; }
        public decimal trangratuita { get; set; }
        public decimal? faltante { get; set; }
        public decimal? precunit { get; set; }
        public short signo { get; set; }
        public decimal SalCantidad { get; set; }
        public decimal SalValor { get; set; }
        public decimal PrecProm { get; set; }
        public string Descripcion { get; set; }
        public string unimed { get; set; }
        public int Mostrar { get; set; }
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public string nia { get; set; }
        public string producto { get; set; }
        public string DocTipo { get; set; }
        public string Producto { get; set; }
    }
}