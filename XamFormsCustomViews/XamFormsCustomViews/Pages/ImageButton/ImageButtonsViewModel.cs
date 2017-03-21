using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamFormsCustomViews.MockData;

namespace XamFormsCustomViews.Pages.ImageButton
{
    public class ImageButtonsViewModel : BaseViewModel
    {
        private FishSpecies _selectedFishSpecies;
        private List<FishSpecies> _availableFish;

        public ImageButtonsViewModel(IMyNavigationService navService) : base(navService)
        {
            _availableFish = FishSpecies.GetFishList();
        }

        public List<FishSpecies> AvailableFishSpecies
        {
            get { return _availableFish; }
        }

        public async Task FishSelected(string fish)
        {
            SelectedFishSpecies = _availableFish.FirstOrDefault(f => f.Name == fish);
        }

        public FishSpecies SelectedFishSpecies
        {
            get
            {
                return _selectedFishSpecies;
            }
            set
            {
                _selectedFishSpecies = value;
                OnPropertyChanged();
            }
        }

    }
}
