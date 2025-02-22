﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Sistema_Ferreteria.Database
{

    public partial class Usuarios
    {
        public Usuarios(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        public string NombreCompleto
        {
            get => nombre + " " + apellido;
        }
    }

}
