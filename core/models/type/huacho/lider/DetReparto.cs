﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;

namespace Lider.Huacho.Model.dbModel
{
    public partial class DetReparto
    {
        public string Numero { get; set; }
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public string TipoIng { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }
        public decimal Importe { get; set; }
        public decimal ALiquidar { get; set; }

        public virtual DOCUMENTO DOCUMENTO { get; set; }
        public virtual CabReparto NumeroNavigation { get; set; }
    }
}