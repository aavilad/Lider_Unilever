﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Lider.Huacho.Model.dbModel
{
    public partial class LIQUIDACION
    {
        public LIQUIDACION()
        {
            DETLIQUI = new HashSet<DETLIQUI>();
        }

        public string Liquidacion1 { get; set; }
        public string TipoLiq { get; set; }
        public string Personal { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public bool cerrado { get; set; }
        public string observacion { get; set; }
        public string repartidor { get; set; }
        public string reparto { get; set; }
        public string zona { get; set; }

        public virtual PERSONAL PersonalNavigation { get; set; }
        public virtual ICollection<DETLIQUI> DETLIQUI { get; set; }
    }
}