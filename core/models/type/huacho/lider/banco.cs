﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Lider.Huacho.Model.dbModel
{
    public partial class banco
    {
        public banco()
        {
            PlanillaCobD = new HashSet<PlanillaCobD>();
        }

        public string banco1 { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<PlanillaCobD> PlanillaCobD { get; set; }
    }
}