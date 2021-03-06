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
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionCommerciale.Models
{
    public partial class PRODUITS
    {
        public PRODUITS()
        {
            this.LIGNES_AVOIRS_CLIENTS = new HashSet<LIGNES_AVOIRS_CLIENTS>();
            this.LIGNES_AVOIRS_FOURNISSEURS = new HashSet<LIGNES_AVOIRS_FOURNISSEURS>();
            this.LIGNES_BONS_LIVRAISONS_CLIENTS = new HashSet<LIGNES_BONS_LIVRAISONS_CLIENTS>();
            this.LIGNES_BONS_RECEPTIONS_FOURNISSEURS = new HashSet<LIGNES_BONS_RECEPTIONS_FOURNISSEURS>();
            this.LIGNES_COMMANDES_CLIENTS = new HashSet<LIGNES_COMMANDES_CLIENTS>();
            this.LIGNES_COMMANDES_FOURNISSEURS = new HashSet<LIGNES_COMMANDES_FOURNISSEURS>();
            this.LIGNES_DEVIS_CLIENTS = new HashSet<LIGNES_DEVIS_CLIENTS>();
            this.LIGNES_FACTURES_CLIENTS = new HashSet<LIGNES_FACTURES_CLIENTS>();
            this.LIGNES_FACTURES_FOURNISSEURS = new HashSet<LIGNES_FACTURES_FOURNISSEURS>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public string DESIGNATION { get; set; }
        public Nullable<int> FAMILLE { get; set; }
        public bool BLOQUE { get; set; }
        public string CODE_A_BARE { get; set; }
        public Nullable<decimal> PRIX_ACHAT_HT { get; set; }
        public Nullable<decimal> PRIX_VENTE_HT { get; set; }
        public Nullable<bool> AVEC_TVA { get; set; }
        public Nullable<int> TVA { get; set; }
        public Nullable<decimal> PRIX_VENTE_TTC { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public Nullable<int> QUANTITE_REPTURE_STOCK { get; set; }
        public string OBSERVATIONS { get; set; }

        [ForeignKey("FAMILLE")]
        public virtual FAMILLES_PRODUITS FAMILLES_PRODUITS { get; set; }
        
        public virtual ICollection<LIGNES_AVOIRS_CLIENTS> LIGNES_AVOIRS_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_AVOIRS_FOURNISSEURS> LIGNES_AVOIRS_FOURNISSEURS { get; set; }
        public virtual ICollection<LIGNES_BONS_LIVRAISONS_CLIENTS> LIGNES_BONS_LIVRAISONS_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_BONS_RECEPTIONS_FOURNISSEURS> LIGNES_BONS_RECEPTIONS_FOURNISSEURS { get; set; }
        public virtual ICollection<LIGNES_COMMANDES_CLIENTS> LIGNES_COMMANDES_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_COMMANDES_FOURNISSEURS> LIGNES_COMMANDES_FOURNISSEURS { get; set; }
        public virtual ICollection<LIGNES_DEVIS_CLIENTS> LIGNES_DEVIS_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_FACTURES_CLIENTS> LIGNES_FACTURES_CLIENTS { get; set; }
        public virtual ICollection<LIGNES_FACTURES_FOURNISSEURS> LIGNES_FACTURES_FOURNISSEURS { get; set; }
        public virtual ICollection<MOUVEMENETS_PRODUITS> MOUVEMENETS_PRODUITS { get; set; }
    }
    
}
