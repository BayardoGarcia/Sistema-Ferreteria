﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Sistema_Ferreteria.Database
{

    public partial class Roles
    {
        public Roles(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
