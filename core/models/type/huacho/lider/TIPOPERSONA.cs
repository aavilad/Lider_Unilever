﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Lider.Huacho.Model.dbModel
{
    public partial class TIPOPERSONA
    {
        public TIPOPERSONA()
        {
            PERSONAL = new HashSet<PERSONAL>();
        }

        public string TipoPersona1 { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PERSONAL> PERSONAL { get; set; }
    }
}