using TekTrackingCore.Sample.Models;

namespace TekTrackingCore;

public partial class UnitControl : ContentView
{
	private List<Unit> unitlist;

	public UnitControl()
	{
        unitlist=new List<Unit>();
        InitializeComponent();

	}
}