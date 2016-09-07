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
    public partial class FOURNISSEURS
    {
        public FOURNISSEURS()
        {
            this.COMMANDES_FOURNISSEURS = new HashSet<COMMANDES_FOURNISSEURS>();
            this.BONS_RECEPTIONS_FOURNISSEURS = new HashSet<BONS_RECEPTIONS_FOURNISSEURS>();
            this.FACTURES_FOURNISSEURS = new HashSet<FACTURES_FOURNISSEURS>();
            this.AVOIRS_FOURNISSEURS = new HashSet<AVOIRS_FOURNISSEURS>();
            this.LIGNES_DECLARATIONS_FACTURES = new HashSet<LIGNES_DECLARATIONS_FACTURES>();
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
    
        public virtual ICollection<COMMANDES_FOURNISSEURS> COMMANDES_FOURNISSEURS { get; set; }
        public virtual ICollection<BONS_RECEPTIONS_FOURNISSEURS> BONS_RECEPTIONS_FOURNISSEURS { get; set; }
        public virtual ICollection<FACTURES_FOURNISSEURS> FACTURES_FOURNISSEURS { get; set; }
        public virtual ICollection<AVOIRS_FOURNISSEURS> AVOIRS_FOURNISSEURS { get; set; }
        public virtual ICollection<LIGNES_DECLARATIONS_FACTURES> LIGNES_DECLARATIONS_FACTURES { get; set; }
    }
    
}