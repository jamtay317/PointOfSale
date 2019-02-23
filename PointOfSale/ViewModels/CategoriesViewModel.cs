using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.DataProvider.Menu;
using PointOfSale.MenuService;
using PointOfSale.Services.Navigatoin;
using PointOfSale.ViewModels.Bases;
using Prism.Commands;
using Prism.Regions;

namespace PointOfSale.ViewModels
{
    public class CategoriesViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IMenuDataProvider _menuDataProvider;

        public CategoriesViewModel(INavigationService navigationService, IMenuDataProvider menuDataProvider)
        {
            _navigationService = navigationService;
            _menuDataProvider = menuDataProvider;
        }

        private Category _selectedCategory;

        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => SetProperty(ref _selectedCategory, value);
        }

        public ObservableCollection<Category> Categories { get; set; }
        

        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand CancelCommand{ get; set; }
        public DelegateCommand SaveAndCloseCommand { get; set; }

        protected override void RegiserCommands()
        {
            SaveCommand = new DelegateCommand(async () =>
            {
                await Save();
                GetData();
            });
            CancelCommand = new DelegateCommand(Cancel);
            SaveAndCloseCommand = new DelegateCommand(async ()=> await SaveAndClose());
        }

        protected override void RegisterCollections()
        {
            Categories = new ObservableCollection<Category>();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            SelectedCategory = new Category();
        }

        protected override async void GetData()
        {
            var catigories = await _menuDataProvider.GetCategoriesAsync();
            Categories.AddRange(catigories);
        }

        private async Task SaveAndClose()
        {
            await Save();
            Cancel();
        }

        private void Cancel()
        {
            SelectedCategory = null;
            _navigationService.RemoveViewFromAdmin();
        }

        private Task Save()
        {
            return _menuDataProvider.SaveCategory(SelectedCategory);
        }
    }
}
