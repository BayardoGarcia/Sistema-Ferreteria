﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Sistema_Ferreteria.Database
{

    [Persistent(@"categorias")]
    public partial class Categorias : XPLiteObject
    {
        int fidCategoria;
        [Key(true)]
        public int idCategoria
        {
            get { return fidCategoria; }
            set { SetPropertyValue<int>(nameof(idCategoria), ref fidCategoria, value); }
        }
        string fnombre;
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        [Association(@"ProductosReferencesCategorias")]
        public XPCollection<Productos> ProductosCollection { get { return GetCollection<Productos>(nameof(ProductosCollection)); } }
    }

}
