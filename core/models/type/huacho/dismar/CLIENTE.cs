using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class CLIENTE {
        public string Cliente { get; set; }
        public string Zona { get; set; }
        public string TipoCli { get; set; }
        public string Ruc { get; set; }
        public string Estado { get; set; }
        public DateTime FechIng { get; set; }
        public int? TopeCredito { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public decimal Saldo { get; set; }
        public bool Credito { get; set; }
        public string Alias { get; set; }
        public string Direccion { get; set; }
        public string iddistrito { get; set; }
        public string IdNegocio { get; set; }
        public string nuevo { get; set; }
        public DateTime? ultmod { get; set; }
        public string usuario { get; set; }
        public string observacion { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string codbase { get; set; }
        public string codant { get; set; }
        public byte clasecli { get; set; }
        public string ptollegada { get; set; }
        public string distllegada { get; set; }
        public decimal porcentaje { get; set; }
        public string RAZ { get; set; }
        public string control { get; set; }
        public bool? agente_ret { get; set; }
        public bool? agente_per { get; set; }
        public bool? agente_userf { get; set; }
        public string Correo { get; set; }
    }
}