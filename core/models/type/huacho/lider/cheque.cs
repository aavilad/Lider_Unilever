﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;

namespace Lider.Huacho.Model.dbModel
{
    public partial class cheque
    {
        public int idcheque { get; set; }
        public string cheque1 { get; set; }
        public string cliente { get; set; }
        public DateTime femision { get; set; }
        public DateTime fcobro { get; set; }
        public string banco { get; set; }
        public byte moneda { get; set; }
        public decimal tcambio { get; set; }
        public decimal importe { get; set; }
        public string personal { get; set; }
        public bool cobrado { get; set; }

        public virtual CLIENTE clienteNavigation { get; set; }
    }
}