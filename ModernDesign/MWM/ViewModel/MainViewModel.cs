﻿using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MWM.ViewModel
{
     class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public Object CurrentView 
        {
            get { return _currentView; }
            
            set 
            { _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o => { 
            CurrentView = HomeVM;
            });


            DiscoveryViewCommand = new RelayCommand(o => {
                CurrentView = DiscoveryVM;
            });
        }
    }
}
