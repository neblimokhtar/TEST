//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace GestionCommerciale.Models
{
    public partial class CLIENTS
    {
        public CLIENTS()
        {
            this.AVOIRS_CLIENTS = new HashSet<AVOIRS_CLIENTS>();
            this.BONS_LIVRAISONS_CLIENTS = new HashSet<BONS_LIVRAISONS_CLIENTS>();
            this.COMMANDES_CLIENTS = new HashSet<COMMANDES_CLIENTS>();
            this.DEVIS_CLIENTS = new HashSet<DEVIS_CLIENTS>();
            this.FACTURES_CLIENTS = new HashSet<FACTURES_CLIENTS>();
            this.LIGNES_DECLARATIONS_FACS = new HashSet<LIGNES_DECLARATIONS_FACS>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NOM { get; set; }
        public string ADRESSE { get; set; }
        public string TELEPHONE { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string SITE_WEB { get; set; }
        public string ID_FISCAL { get; set; }
        public string AI { get; set; }
        public string NIS { get; set; }
        public string RC { get; set; }
        public string RIB { get; set; }
        public string CONTACT { get; set; }
    
        public virtual ICollection<AVOIRS_CLIENTS> AVOIRS_CLIENTS { get; set; }
        public virtual ICollection<BONS_LIVRAISONS_CLIENTS> BONS_LIVRAISONS_CLIENTS { get; set; }
        public virtual ICollection<COMMANDES_CLIENTS> COMMANDES_CLIENTS { get; set; }
        public virtual ICollection<DEVIS_CLIENTS> DEVIS_CLIENTS { get; set; }
        public virtual ICollection<FACTURES_CLIENTS> FACTURES_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_DECLARATIONS_FACS> LIGNES_DECLARATIONS_FACS { get; set; }
    }
    
}
