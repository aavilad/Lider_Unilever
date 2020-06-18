using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lider.Huacho.Model.dbModel
{
    public class iClientes
    {
        public int PKID { get; set; }
        public string CodigoDistribuidor { get; set; }
        public string CodigoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string RUC { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Column("E-mail")] public string Email { get; set; }
        public string Canal { get; set; }
        public string TipoNegocio { get; set; }
        public string Zona { get; set; }
        public string Modulo { get; set; }
        public string Distrito { get; set; }
        public string Georeferencia { get; set; }
        public string CodigoVendedor { get; set; }
        public string DiaVisita { get; set; }
        public string Status { get; set; }
        public string CodCorporativo { get; set; }
        public string Mercado { get; set; }
        public string Clasificacion { get; set; }
    }
}
