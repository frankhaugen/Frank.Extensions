﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.444.0.

using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.SBDH
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.444.0")]
    [Serializable()]
    [XmlType("BusinessScope", Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class BusinessScope
    {

        [XmlIgnore()]
        private Collection<Scope> _scope;

        [XmlElement("Scope")]
        public Collection<Scope> Scope
        {
            get
            {
                return this._scope;
            }
            private set
            {
                this._scope = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Scope-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Scope collection is empty.</para>
        /// </summary>
        [XmlIgnore()]
        public bool ScopeSpecified
        {
            get
            {
                return (this.Scope.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="BusinessScope" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="BusinessScope" /> class.</para>
        /// </summary>
        public BusinessScope()
        {
            this._scope = new Collection<Scope>();
        }
    }
}
