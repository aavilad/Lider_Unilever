﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;

namespace Lider.Huacho.Model.dbModel
{
    public partial class DETLIQUI
    {
        public string Liquidacion { get; set; }
        public string TipoLiq { get; set; }
        public int Item { get; set; }
        public string Documento { get; set; }
        public string TipoDoc { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string TipoPago { get; set; }
        public string NroDocum { get; set; }
        public string rmOperator { get; set; }
        public DateTime? rmFechRegistro { get; set; }
        public string Personal { get; set; }
        public decimal? sldanterior { get; set; }
        public decimal? sldnuevo { get; set; }

        public virtual LIQUIDACION LIQUIDACION { get; set; }
    }
}