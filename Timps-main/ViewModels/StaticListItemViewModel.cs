
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekTrackingCore.Framework;
using TekTrackingCore.Framework.Types;
using TekTrackingCore.Repositry;
using TekTrackingCore.Services;

namespace TekTrackingCore.ViewModels
{
    public static class LinqExtensions
    {
        public static ICollection<T> AddRange<T>(this ICollection<T> source, IEnumerable<T> addSource)
        {
            foreach (T item in addSource)
            {
                source.Add(item);
            }

            return source;
        }
    }
    public class ExtendedObservableCollection<T> : ObservableCollection<T>
    {
        public void Execute(Action<IList<T>> itemsAction)
        {
            itemsAction(Items);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
    public partial class StaticListItemViewModel :BaseViewModel    
    {
        [ObservableProperty]
        public ExtendedObservableCollection<StaticListItemDTO1> staticListItemsList;
        private DatabaseSyncService service;
        public StaticListItemViewModel()
        {
            service = ServiceResolver.ServiceProvider.GetRequiredService<DatabaseSyncService>();
            staticListItemsList = new ExtendedObservableCollection<StaticListItemDTO1>();
            //staticListItemsList.Add(new StaticListItemDTO1{ Code="666",Description="555",ListName="444",OptParam1="3333",OptParam2="33",TenantId="123"});


            service.SetSyncCallback = onSyncCallback;
            if (Preferences.Get(AppConstants.TOKEN_KEY, "") != "")
            {
                App.Current.Dispatcher.Dispatch(() => MauiProgram.SetMainDashboardPage());
            }
        }

        public void onSyncCallback() 
        {
            var filterdlist = (service.staticListItemDTOs.Where(p => p.ListName == "WorkPlanTemplate").Take(100));
            Console.WriteLine(filterdlist.ToString(), "filteredlist");


            //StaticListItemsList.Execute(items => { items.Clear(); items.AddRange(filterdlist); });

            if (filterdlist.Count() == 1)
            {
                var staticlistitem = filterdlist.FirstOrDefault();
                if (staticlistitem.Code != "-1")
                {
                    StaticListItemsList.Add(filterdlist.FirstOrDefault());
                }
            }
            else
            {
                StaticListItemsList.Execute(items =>
                {
                    //items.Clear(); 
                    items.AddRange(filterdlist);
                });

            }


        }

    }
}
