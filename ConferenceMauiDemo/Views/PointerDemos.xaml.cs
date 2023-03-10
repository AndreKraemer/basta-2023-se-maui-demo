using CommunityToolkit.Maui.Extensions;
using Microsoft.Maui.Controls.Shapes;

namespace ConferenceMauiDemo.Views;

public partial class PointerDemos : ContentPage
{
	public PointerDemos()
	{
		InitializeComponent();
	}

    private async void PrimaryTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Click", "Primary", "OK");
    }

private async void SecondaryTapped(object sender, TappedEventArgs e)
{
    await DisplayAlert("Click", "Secondary", "OK");
}

private async void OnPointerEntered(object sender, PointerEventArgs e)
{
    var rectangle = sender as Rectangle;
    await rectangle.BackgroundColorTo(Colors.Red);
}

private async void OnPointerExited(object sender, PointerEventArgs e)
{
    var rectangle = sender as Rectangle;
    await rectangle.BackgroundColorTo(Color.FromArgb("#512BD4"));
}

private void OnPointerMoved(object sender, PointerEventArgs e)
{
    Point? windowPosition = e.GetPosition(null);

    if(windowPosition.HasValue) 
    {
        PositionLabel.Text = $"Position: x: {windowPosition.Value.X} -  y: {windowPosition.Value.Y}";
    }
    else
    {
        PositionLabel.Text = "unbekannte Position";
    }
}
}