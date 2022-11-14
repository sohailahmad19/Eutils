


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekTrackingCore.Framework;
using TekTrackingCore.Services;

namespace TekTrackingCore.ViewModels
{
    public class BriefingViewModel
    {


        public int Reported { get; set; }
        public int Session { get; set; }
        public string Times { get; set; }
        public void SetBriefingViewModel(int reported, int session, string times)
        {
            Reported = reported;
            Session = session;
            Times = times;
        }
        public BriefingViewModel()
        {
            {
                Reported = 10;
                Session = 20;
            }

            DatabaseSyncService service = ServiceResolver.ServiceProvider.GetRequiredService<DatabaseSyncService>();
            service.Start();

            {
                Times = "4:20 hr";
            }



        }


    }
}
