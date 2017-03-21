using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamFormsCustomViews.MockData;

namespace XamFormsCustomViews.Pages.DynamicAccordian
{
    public  class DynamicAccordionViewModel : BaseViewModel
    {
        private List<LunchMenuItem> _availableMenuItems;
        private List<string> _categories;
        private LunchMenuItem _selectedItem;

        public DynamicAccordionViewModel(IMyNavigationService navService) : base(navService)
        {
            _categories = LunchMenuItem.GetCategories();
            _availableMenuItems = LunchMenuItem.GetAllMenuItems();
        }

        public LunchMenuItem SelectedMenuItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public List<string> Categories
        {
            get { return _categories; }
        }

        public async Task MenuItemSelected(object objMenuItemText)
        {
            this.SelectedMenuItem = _availableMenuItems.FirstOrDefault(m => m.Name == objMenuItemText.ToString());
        }

        public List<LunchMenuItem> GetMenuItems(string category)
        {
            return _availableMenuItems.Where(m => m.Category == category).ToList();
        }
    }
}
