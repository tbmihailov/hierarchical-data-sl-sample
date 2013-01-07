
namespace HierarchyDataTest.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using HierarchyDataTest.Web;


    // Implements application logic using the Entities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class HierachicalDataService : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PRODUCTGROUPS' query.
        
        public IQueryable<ProductGroup> GetPRODUCTGROUPS()
        {
            return this.ObjectContext.PRODUCTGROUPS;
        }

        [Query(IsDefault = true)]
        public IQueryable<ProductGroup> GetRootProductGroups()
        {
            return this.ObjectContext.PRODUCTGROUPS.Where(pg => pg.ParentProductId == null);
        }

        public void InsertProductGroup(ProductGroup productGroup)
        {
            if ((productGroup.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productGroup, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PRODUCTGROUPS.AddObject(productGroup);
            }
        }

        public void UpdateProductGroup(ProductGroup currentProductGroup)
        {
            this.ObjectContext.PRODUCTGROUPS.AttachAsModified(currentProductGroup, this.ChangeSet.GetOriginal(currentProductGroup));
        }

        public void DeleteProductGroup(ProductGroup productGroup)
        {
            if ((productGroup.EntityState == EntityState.Detached))
            {
                this.ObjectContext.PRODUCTGROUPS.Attach(productGroup);
            }
            this.ObjectContext.PRODUCTGROUPS.DeleteObject(productGroup);
        }
    }
}


