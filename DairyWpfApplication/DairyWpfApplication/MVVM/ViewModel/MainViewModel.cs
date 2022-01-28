using DairyWpfApplication.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyWpfApplication.MVVM.ViewModel
{
	class MainViewModel : ObserableObject
	{
		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand DiscoveryViewCommand { get; set; }


		public HomeViewModel HomeViewModel { get; set; }
		public DiscoveryViewModel DiscoveryViewModel { get; set; }
		private object? _currentView;

		public object? CurrentView
		{
			get { return _currentView; }
			set { _currentView = value; OnPropertyChanged(); }
		}

		public MainViewModel()
		{
			HomeViewModel = new HomeViewModel();
			DiscoveryViewModel = new DiscoveryViewModel();
			CurrentView = HomeViewModel;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeViewModel;
			});

			DiscoveryViewCommand = new RelayCommand(o =>
			 {
				 CurrentView = DiscoveryViewModel;
			 });
		}

	}
}
