using SimpleOrientationApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleOrientationApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string DeviceOrientation { get; set; }
        public ICommand GetDeviceOrientationCommand { get; }

        public MainViewModel()
        {
            GetDeviceOrientationCommand = new Command(GetOrientation);
        }

        private void GetOrientation()
        {
            var orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();

            DeviceOrientation = orientation.ToString();
        }
    }
}
