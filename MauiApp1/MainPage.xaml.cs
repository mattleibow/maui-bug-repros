using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	public CollectionItem[] Items { get; } =
		new []
		{
			new CollectionItem { Name = "First" },
			new CollectionItem { Name = "Second" },
			new CollectionItem { Name = "Third" },
			new CollectionItem { Name = "Fourth" },
        };
}

public class CollectionItem
{
    public string Name { get; set; }

	public SubItem[] SubItems { get; } =
		new[]
		{
			new SubItem { Name = "Sub 1" },
			new SubItem { Name = "Sub 2" },
			new SubItem { Name = "Sub 3" },
			new SubItem { Name = "Sub 4" },
        };
}


public class SubItem
{
    public string Name { get; set; }
}

