﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("Model", "FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(HierarchyDataTest.Web.ProductGroup), "PRODUCTGROUPS1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(HierarchyDataTest.Web.ProductGroup), true)]

#endregion

namespace HierarchyDataTest.Web
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProductGroup> PRODUCTGROUPS
        {
            get
            {
                if ((_PRODUCTGROUPS == null))
                {
                    _PRODUCTGROUPS = base.CreateObjectSet<ProductGroup>("PRODUCTGROUPS");
                }
                return _PRODUCTGROUPS;
            }
        }
        private ObjectSet<ProductGroup> _PRODUCTGROUPS;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PRODUCTGROUPS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPRODUCTGROUPS(ProductGroup productGroup)
        {
            base.AddObject("PRODUCTGROUPS", productGroup);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ProductGroup")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductGroup : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ProductGroup object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static ProductGroup CreateProductGroup(global::System.Int32 id)
        {
            ProductGroup productGroup = new ProductGroup();
            productGroup.Id = id;
            return productGroup;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ParentProductId
        {
            get
            {
                return _ParentProductId;
            }
            set
            {
                OnParentProductIdChanging(value);
                ReportPropertyChanging("ParentProductId");
                _ParentProductId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentProductId");
                OnParentProductIdChanged();
            }
        }
        private Nullable<global::System.Int32> _ParentProductId;
        partial void OnParentProductIdChanging(Nullable<global::System.Int32> value);
        partial void OnParentProductIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS1")]
        public EntityCollection<ProductGroup> ChildrenProductGroups
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS")]
        public ProductGroup ParentProductGroup
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ProductGroup> ParentProductGroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ProductGroup>("Model.FK_PRODUCTGROUPS_PRODUCTGROUPS", "PRODUCTGROUPS", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
