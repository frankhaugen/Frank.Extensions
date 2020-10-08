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
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.SBDH
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.444.0")]
    [Serializable()]
    [XmlType("Manifest", Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public partial class Manifest
    {

        [Required()]
        [XmlElement("NumberOfItems")]
        public string NumberOfItems { get; set; }

        [XmlIgnore()]
        private Collection<ManifestItem> _manifestItem;

        [Required()]
        [XmlElement("ManifestItem")]
        public Collection<ManifestItem> ManifestItem
        {
            get
            {
                return this._manifestItem;
            }
            private set
            {
                this._manifestItem = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Manifest" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Manifest" /> class.</para>
        /// </summary>
        public Manifest()
        {
            this._manifestItem = new Collection<ManifestItem>();
        }
    }
}
