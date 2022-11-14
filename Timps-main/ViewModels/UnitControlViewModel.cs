﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TekTrackingCore.Repositry;
using TekTrackingCore.Sample.Models;
using TekTrackingCore.Services;

namespace TekTrackingCore.ViewModels
{
    public partial class UnitControlViewModel : BaseViewModel
    {
        InspectionService inspectionService;

        public UnitControlViewModel()
        {
            inspectionService = new InspectionService();
        }


    }

}
