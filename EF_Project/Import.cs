
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EF_Project
{

using System;
    using System.Collections.Generic;
    
public partial class Import
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Import()
    {

        this.Import_Categories = new HashSet<Import_Categories>();

    }


    public int Id { get; set; }

    public System.DateTime Date { get; set; }

    public int WarehouseId { get; set; }

    public int SupplierId { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Import_Categories> Import_Categories { get; set; }

    public virtual Supplier Supplier { get; set; }

    public virtual Warehouse Warehouse { get; set; }

}

}
