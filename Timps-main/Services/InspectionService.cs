
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
    public class InspectionService
    {
        public int count;
        public string results;
        public List<StaticListItemDTO1> staticListItemDTOs { get; set; }

        public string LastTimestamp { get; set; }

        private JsonSerializerOptions _serializerOptions;


        public async void Poll()
        {
            staticListItemDTOs.Clear();
            System.Diagnostics.Debug.WriteLine("This is a log", AppConstants.LIST_URL);

            JSONWebService service = ServiceResolver.ServiceProvider.GetRequiredService<JSONWebService>();
            string url = string.Format(AppConstants.LIST_URL, 300, LastTimestamp);
            results = await service.GetJSONAsync(url, 10000);
            var responseDTO = JsonSerializer.Deserialize<MessageListResponseDTO>(results);

            //Preferences.Set(typeof(LoginInfo).ToString(), responseDTO.ToString());
            Preferences.Default.Set("work_plan", responseDTO.Result);
            var a = Preferences.Get("work_plan", "");
            Console.WriteLine(a);


            if (responseDTO != null)
            {
                LastTimestamp = responseDTO.Ts;
                foreach (var itemDTO in responseDTO.Result)
                {
                    staticListItemDTOs.AddRange(itemDTO);
                }
            }
        }

    }
}
