using System;
using System.Collections.Generic;
using System.Linq;

namespace HierarchyDataTest.Web
{
    public partial class ProductGroup
    {
        public string FullName
        {
            get
            {
                ProductGroup productGroup = this;
                string fullName = productGroup.Name;
                
                while (productGroup.ParentProductId != null)
                {
                    productGroup = productGroup.ParentProductGroup;
                    fullName = String.Format("{0}{1}{2}",productGroup.Name, ApplicationStrings.ProductGroupsNameSeparator, fullName);
                }
                return fullName;
            }
        }
    }
}