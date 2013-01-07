
namespace HierarchyDataTest.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductGroupMetadata as the class
    // that carries additional metadata for the ProductGroup class.
    [MetadataTypeAttribute(typeof(ProductGroup.ProductGroupMetadata))]
    public partial class ProductGroup
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductGroup class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductGroupMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductGroupMetadata()
            {
            }

            public EntityCollection<ProductGroup> ChildrenProductGroups { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public ProductGroup ParentProductGroup { get; set; }

            public Nullable<int> ParentProductId { get; set; }
        }
    }
}
