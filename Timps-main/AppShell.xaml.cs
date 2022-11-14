using TekTrackingCore.Views;

namespace TekTrackingCore;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Briefing), typeof(Briefing));

        Routing.RegisterRoute(nameof(Hos), typeof(Hos));
        Routing.RegisterRoute(nameof(StaticListItemPage), typeof(StaticListItemPage));
        Routing.RegisterRoute(nameof(ExpandableView), typeof(ExpandableView));
        Routing.RegisterRoute(nameof(FormPage), typeof(FormPage));


    }
}
