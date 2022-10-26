
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TekTrackingCore.Framework;
using TekTrackingCore.Framework.Types;

namespace TekTrackingCore.Services
{
    public class DatabaseSyncService
    {
        public TimerDelegate<string> timerTask;
        public int count;
        public string results;
        public List<StaticListItemDTO1> staticListItemDTOs { get; set; }
        public Action SetSyncCallback { get;  set; }

        JsonSerializerOptions _serializerOptions;
        public async void Start()
        {

            staticListItemDTOs = new List<StaticListItemDTO1>();
            Poll();
           
            timerTask = new TimerDelegate<string>(  () =>
            {

                Application.Current.Dispatcher.DispatchAsync(() =>
                {
                    Poll();
                });
                 
                return results;

            }, 35000);
            timerTask.OnCompleted += TimerTask_OnCompleted; ; ;
            timerTask.Start();
           

        }

        public void Stop() 
        { 
        timerTask.Stop();
        
        }

        public async void Poll() 
        {
            staticListItemDTOs.Clear();
            System.Diagnostics.Debug.WriteLine("This is a log", AppConstants.LIST_URL);

            JSONWebService service = ServiceResolver.ServiceProvider.GetRequiredService<JSONWebService>();
            results = await service.GetJSONAsync(AppConstants.LIST_URL, 10000);
            var responseDTO = JsonSerializer.Deserialize<MessageListResponseDTO>(results);
            foreach(var itemDTO in responseDTO.Result) 
            {
                staticListItemDTOs.AddRange(itemDTO);
            }
        }



        private void TimerTask_OnCompleted(object sender, string e)
        {
            Console.WriteLine(e);

            if (SetSyncCallback!=null) { SetSyncCallback(); } ;
        }
    }
}
