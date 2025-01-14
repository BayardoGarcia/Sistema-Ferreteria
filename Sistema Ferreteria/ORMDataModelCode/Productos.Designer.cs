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

    [Persistent(@"productos")]
    public partial class Productos : XPLiteObject
    {
        int fidProducto;
        [Key(true)]
        public int idProducto
        {
            get { return fidProducto; }
            set { SetPropertyValue<int>(nameof(idProducto), ref fidProducto, value); }
        }
        string fnombre;
        public string nombre
        {
            get { return fnombre; }
            set { SetPropertyValue<string>(nameof(nombre), ref fnombre, value); }
        }
        string fdescripcion;
        [Size(SizeAttribute.Unlimited)]
        public string descripcion
        {
            get { return fdescripcion; }
            set { SetPropertyValue<string>(nameof(descripcion), ref fdescripcion, value); }
        }
        Categorias fcategoria;
        [Association(@"ProductosReferencesCategorias")]
        public Categorias categoria
        {
            get { return fcategoria; }
            set { SetPropertyValue<Categorias>(nameof(categoria), ref fcategoria, value); }
        }
        double fprecioUnitario;
        public double precioUnitario
        {
            get { return fprecioUnitario; }
            set { SetPropertyValue<double>(nameof(precioUnitario), ref fprecioUnitario, value); }
        }
        int fcantidadStock;
        public int cantidadStock
        {
            get { return fcantidadStock; }
            set { SetPropertyValue<int>(nameof(cantidadStock), ref fcantidadStock, value); }
        }
        Proveedores fproveedor;
        [Association(@"ProductosReferencesProveedores")]
        public Proveedores proveedor
        {
            get { return fproveedor; }
            set { SetPropertyValue<Proveedores>(nameof(proveedor), ref fproveedor, value); }
        }
        [Association(@"DetallesVentaReferencesProductos")]
        public XPCollection<DetallesVenta> DetallesVentas { get { return GetCollection<DetallesVenta>(nameof(DetallesVentas)); } }
        [Association(@"EntradaProductosReferencesProductos")]
        public XPCollection<EntradaProductos> EntradaProductosCollection { get { return GetCollection<EntradaProductos>(nameof(EntradaProductosCollection)); } }
    }

}
