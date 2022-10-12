using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TekTrackingCore.Models;
using TekTrackingCore.Repositry;
using TekTrackingCore.Services;

namespace TekTrackingCore.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        readonly ILoginRepository loginRepository;

            public LoginViewModel() 
        {
            loginRepository = new LoginService();
        }

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;

        [RelayCommand]
        async Task Login() 
        {
         
           UserInfo info = await loginRepository.Login(email, password); 
            if(info == null) 
            {

            }
            else 
            { // Route to DashBoard.
                
            }
        
        }

        public bool IsLoggedIn
        {
            get
            {
                return loginRepository.IsAlreadyLoggedIn();
            }
        }

        public string BtnTextString
        {
            get
            {
                return loginRepository.BtnText();
            }
        }

        public bool IsLoggedOut
        {
            get
            {
                return !loginRepository.IsAlreadyLoggedIn();
            }
        }


        [RelayCommand]
        public void Proceed()
        {
            loginRepository.Proceed();
        }

    }
}
