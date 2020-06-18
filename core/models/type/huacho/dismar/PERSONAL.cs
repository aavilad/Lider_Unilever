using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class PERSONAL {
        public string Personal { get; set; }
        public string TipoPersona { get; set; }
        public string Nombre { get; set; }
        public string LibElec { get; set; }
        public DateTime? FechIng { get; set; }
        public DateTime? FechNac { get; set; }
        public string Telefono { get; set; }
        public bool Comision { get; set; }
        public bool Activo { get; set; }
        public decimal Sueldo { get; set; }
        public byte vendedor { get; set; }
        public int clase { get; set; }
        public string grupo { get; set; }
        public string distrito { get; set; }
        public string fzavtas { get; set; }
        public bool novedad { get; set; }
        public bool dms { get; set; }
        public decimal pparticipa { get; set; }
        public decimal pcuota { get; set; }
        public string supercodigo { get; set; }
    }
}