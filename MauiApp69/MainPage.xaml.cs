using System.Collections;

namespace MauiApp69;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		//Content = new MyView()
		//{
		//	new Label()
		//};
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

public class MyView : View, IEnumerable
{
IEnumerator IEnumerable.GetEnumerator()
{
	yield return null;
}
}
