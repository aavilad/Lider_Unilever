using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class uVendedor {
        public int PKID { get; set; }
        public string RvInterno { get; set; }
        public string RvReportado { get; set; }
        public bool StatusRvInterno { get; set; }
        public bool StatusRvReportado { get; set; }
        public Guid cdRow { get; set; }
    }
}