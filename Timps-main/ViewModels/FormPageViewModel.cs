
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekTrackingCore.Sample.Models;
using TekTrackingCore.Services;



namespace TekTrackingCore.ViewModels
{
    [QueryProperty("OptParam1", "OptParam1")]
   
    public partial class FormPageViewModel : BaseViewModel
    {
        [ObservableProperty]
    
        private string optParam1;
        public Action<string> setRenderCallBack { get; set; }

        partial void OnOptParam1Changed(string? value)
        {
            var result = JsonConvert.DeserializeObject<dynamic>(value);
            var opt = result.opt1;
            var tab = opt[0].tabName;

            setRenderCallBack(value);
        }


    }


        //[RelayCommand]
        //public async void Click()
        //{
        //    var result = JsonConvert.DeserializeObject<dynamic>(optParam1);
        //    var opt = result.opt1;
        //    var tab = opt[0].tabName;


        //}

    
}
