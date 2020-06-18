using System;

namespace Lider.Huacho.Model.dbModel
{
    public class iDocumentBody
    {
        public int PKID { get; set; }
        public string CodigoDistribuidor { get; set; }
        public string CDPedido { get; set; }
        public string CodigoProducto { get; set; }
        public int PedNrSecuencia { get; set; }
        public decimal CDPedDescuento { get; set; }
        public decimal CDPedValorSinIGV { get; set; }
        public decimal CDPedValorConIGV { get; set; }
        public decimal CDPedCantidadUC { get; set; }
        public decimal CDPedCantidadUV { get; set; }
        public string CDFactura { get; set; }
        public int FactNrSecuencia { get; set; }
        public decimal CDFactDescuento { get; set; }
        public decimal CDFactVentaSinIGV { get; set; }
        public decimal CDFactVentaConIGV { get; set; }
        public decimal CDFactCantidadUC { get; set; }
        public decimal CDFactCantidadUV { get; set; }
        public string IndicCombo { get; set; }
        public string CodCombo { get; set; }
        public string CodigoPromocion { get; set; }
        public decimal CantidadDevuelta { get; set; }
        public decimal BonificacionSoles { get; set; }
        public decimal BonificacionUnidades { get; set; }
    }
}
