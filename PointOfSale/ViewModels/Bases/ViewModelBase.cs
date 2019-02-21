using Prism.Mvvm;
using Prism.Regions;

namespace PointOfSale.ViewModels.Bases
{
    public abstract class ViewModelBase:BindableBase,INavigationAware
    {
        protected ViewModelBase()
        {
            RegisterCollections();
            RegiserCommands();
            RegisterEvents();
        }
        protected virtual void RegisterCollections() { }
        protected virtual void RegiserCommands() { }
        protected virtual void RegisterEvents() { }
        protected virtual void GetData() { }
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            GetData();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
