//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vueling.Infrastructure.Repository.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Policy
    {
        public string Id { get; set; }
        public decimal AmountInsured { get; set; }
        public string Email { get; set; }
        public System.DateTime InceptionDate { get; set; }
        public bool InstallmentPayment { get; set; }
        public string ClientId { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
