using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace TekTrackingCore.Framework.Types
{
    public class StaticListItemDTO
    {
        [JsonPropertyName("_id")]
        public string Id;

        [JsonPropertyName("tenantId")]
        public string TenantId;

        [JsonPropertyName("listName")]
        public string ListName;

        [JsonPropertyName("code")]
        public string Code;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt;

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt;

        [JsonPropertyName("__v")]
        public int V;

        [JsonPropertyName("opt1")]
        public object Opt1;

        [JsonPropertyName("opt2")]
        public object Opt2;
    }

    public class MessageListResponseDTO
    {
        [JsonPropertyName("ts")]
        public string Ts { get; set; }

        [JsonPropertyName("result")]
        public List<List<StaticListItemDTO1>> Result { get; set; }
    }
    public class StaticListItemDTO1 : INotifyPropertyChanged
    {
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("listName")]
        public string ListName { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("optParam1")]
        public string OptParam1 { get; set; }

        [JsonPropertyName("optParam2")]
        public string OptParam2 { get; set; }


        [JsonPropertyName("contactName")]
        public string ContactName { get; set; }

        [JsonPropertyName("callTime")]
        public string CallTime { get; set; }

        [JsonPropertyName("contactImage")]
        public string ContactImage { get; set; }

     

        [JsonPropertyName("isvisible")]
        public bool IsVisible { get { return _isVisible; } set {  SetProperty(ref _isVisible, value); } }
        private bool _isVisible;
        internal IEnumerable<object> tasks;

        public StaticListItemDTO1()
        {
            IsVisible = false;

        }

         
        
            public event PropertyChangedEventHandler PropertyChanged;

            public bool SetProperty<T>(ref T field, T value, [CallerMemberName] string name = null)
            {
                if (EqualityComparer<T>.Default.Equals(field, value))
                {
                    return false;
                }
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
                return true;
            }
        }
    }

