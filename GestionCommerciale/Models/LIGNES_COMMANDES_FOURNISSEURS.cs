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

namespace GestionCommerciale.Models
{
    public partial class LIGNES_COMMANDES_FOURNISSEURS
    {
        public int ID { get; set; }
        public Nullable<int> PRODUIT { get; set; }
        public string CODE_PRODUIT { get; set; }
        public string DESIGNATION_PRODUIT { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public Nullable<decimal> PRIX_UNITAIRE_HT { get; set; }
        public Nullable<decimal> REMISE { get; set; }
        public Nullable<decimal> TOTALE_REMISE_HT { get; set; }
        public Nullable<decimal> TOTALE_HT { get; set; }
        public Nullable<int> TVA { get; set; }
        public Nullable<decimal> TOTALE_TTC { get; set; }
        public Nullable<int> COMMANDE_FOURNISSEUR { get; set; }

        [ForeignKey("COMMANDE_FOURNISSEUR")]
        public virtual COMMANDES_FOURNISSEURS COMMANDES_FOURNISSEURS { get; set; }
        [ForeignKey("PRODUIT")]
        public virtual PRODUITS PRODUITS { get; set; }
    }
    
}