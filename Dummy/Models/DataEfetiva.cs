﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Dummy.Models
{
    public partial class DataEfetiva
    {
        public int IdDataEfetiva { get; set; }
        public int IdCampo { get; set; }
        public int IdFuncionario { get; set; }
        public int IdAgendamento { get; set; }
        public string Valor { get; set; }
        public DateTime DataEfetiva1 { get; set; }
        public bool Processado { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}