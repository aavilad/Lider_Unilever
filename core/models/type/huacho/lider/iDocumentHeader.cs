using System;

namespace Lider.Huacho.Model.dbModel
{
    public class iDocumentHeader
    {
        public int PKID { get; set; }
        public string CodigoDistribuidor { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoVendedor { get; set; }
        public string CDPedido { get; set; }
        public string CDPedFecha { get; set; }
        public string CDPedStatus { get; set; }
        public string CDFactura { get; set; }
        public string CDFacFecha { get; set; }
        public string CDFacStatus { get; set; }
        public string MotivoCancelado { get; set; }
        public int Periodo { get; set; }
    }
}
