using ErrandHandler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Models.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;

        public MainViewModel()
        {
            UserViewModel = new UserViewModel();
            NewUserViewModel = new NewUserViewModel();

            ErrandViewModel = new ErrandViewModel(); 
            NewErrandViewModel = new NewErrandViewModel();
  

            CurrentView = UserViewModel;

            UserViewCommand = new RelayCommand(x => CurrentView = UserViewModel);
            NewUserViewCommand = new RelayCommand(x => CurrentView = NewUserViewModel);
            ErrandViewCommand = new RelayCommand(x => CurrentView = ErrandViewModel);
            NewErrandViewCommand = new RelayCommand(x => CurrentView = NewErrandViewModel);
            
        }

        public object CurrentView 
        { 
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand UserViewCommand { get; set; }
        public UserViewModel UserViewModel { get; set; }

        public RelayCommand NewUserViewCommand { get; set; }
        public NewUserViewModel NewUserViewModel { get; set; }

        public RelayCommand ErrandViewCommand { get; set; }
        public ErrandViewModel ErrandViewModel { get; set; }

        public RelayCommand NewErrandViewCommand { get; set; }
        public NewErrandViewModel NewErrandViewModel { get; set; }


        

        

    }
}
