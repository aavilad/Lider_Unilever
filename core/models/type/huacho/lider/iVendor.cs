using System;

namespace Lider.Huacho.Model.dbModel
{
    public class iVendor
    {
        public string CodigoEmpresa { get; set; }
        public string VendCodigo { get; set; }
        public string VendNombre { get; set; }
        public string VendExclusivo { get; set; }
        public decimal Comision { get; set; }
        public string VendCodSupervisor { get; set; }
        public string VendCodMesa { get; set; }
    }
}
