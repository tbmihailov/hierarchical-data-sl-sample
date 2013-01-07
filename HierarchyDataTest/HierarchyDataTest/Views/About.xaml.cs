namespace HierarchyDataTest
{
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using HierarchyDataTest.Web;
    using HierarchyDataTest.Web.Services;
    using System.Windows.Data;

    /// <summary>
    /// <see cref="Page"/> class to present information about the current application.
    /// </summary>
    public partial class About : Page
    {
        /// <summary>
        /// Creates a new instance of the <see cref="About"/> class.
        /// </summary>
        public About()
        {
            InitializeComponent();

            this.Title = ApplicationStrings.AboutPageTitle;
        }

        /// <summary>
        /// Executes when the user navigates to this page.
        /// </summary>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void productGroupDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }
    }
}