﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Lider.Huacho.Model.dbModel
{
    public partial class LINEA
    {
        public LINEA()
        {
            ComisionLineaMarca = new HashSet<ComisionLineaMarca>();
            ComisionLineaPro = new HashSet<ComisionLineaPro>();
            MARCA = new HashSet<MARCA>();
        }

        public string Linea1 { get; set; }
        public int CanMenor { get; set; }
        public int CanMayor { get; set; }
        public string Descripcion { get; set; }
        public decimal ComiMayor { get; set; }
        public decimal ComiMenor { get; set; }
        public decimal CredMayor { get; set; }
        public decimal CredMenor { get; set; }
        public decimal ComiEspecial { get; set; }
        public decimal ComiSEspecial { get; set; }

        public virtual ICollection<ComisionLineaMarca> ComisionLineaMarca { get; set; }
        public virtual ICollection<ComisionLineaPro> ComisionLineaPro { get; set; }
        public virtual ICollection<MARCA> MARCA { get; set; }
    }
}