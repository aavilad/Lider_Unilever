﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Lider.Huacho.Model.dbModel
{
    public partial class INVENTARIO
    {
        public INVENTARIO()
        {
            detinven = new HashSet<detinven>();
        }

        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<detinven> detinven { get; set; }
    }
}