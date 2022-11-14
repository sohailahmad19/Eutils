using TekTrackingCore.ViewModels;

namespace TekTrackingCore.Views;

public partial class LoginPage : ContentPage
{


    public LoginPage(LoginViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }
}