using System;
namespace Lider_Unilever.core.models.type.huacho.dismar {
    public class DOCUMENTO {
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public string Personal { get; set; }
        public DateTime? Fecha { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Pedido { get; set; }
        public string Estado { get; set; }
        public string DocRefer { get; set; }
        public string TipoDocR { get; set; }
        public byte Motivo { get; set; }
        public decimal Pagado { get; set; }
        public string Generado { get; set; }
        public string TipoIng { get; set; }
        public byte Nrodia { get; set; }
        public bool Cerrado { get; set; }
        public DateTime? FechaRep { get; set; }
        public string PersonalRep { get; set; }
        public string Marca { get; set; }
        public DateTime? fecha1 { get; set; }
        public DateTime? FechaCancelar { get; set; }
        public bool Procesado { get; set; }
        public string observacion { get; set; }
        public string hora { get; set; }
        public byte diasfinta { get; set; }
        public string rsocial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string dni { get; set; }
        public DateTime fechacont { get; set; }
        public decimal afecto { get; set; }
        public decimal inafecto { get; set; }
        public decimal igv { get; set; }
        public decimal total { get; set; }
        public bool impreso { get; set; }
        public string registro { get; set; }
        public string encargado { get; set; }
        public string npersonal { get; set; }
        public string nencargado { get; set; }
        public decimal totdscto { get; set; }
        public string gestion { get; set; }
        public string ptollegada { get; set; }
        public string distllegada { get; set; }
        public decimal percepcion { get; set; }
        public decimal? detraccion { get; set; }
    }
}