using ConferenceMauiDemo.Services;

namespace ConferenceMauiDemo.Views;

public partial class PartialDemoPage : ContentPage
{
	public PartialDemoPage()
	{
		InitializeComponent();
		var deviceService = new DeviceService();
		DeviceInfoLabel.Text = deviceService.GetDeviceName();
	}
}