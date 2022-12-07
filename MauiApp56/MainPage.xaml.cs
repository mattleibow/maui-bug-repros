using System.Collections.ObjectModel;

namespace MauiApp56;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    public ObservableCollection<DEVICE> DEVICES_OBSERVABLE_COLLECTION { get; } =
        new()
        {
            new DEVICE { DEVICE_ID = "1", DEVICE_NAME = "First" },
            new DEVICE { DEVICE_ID = "2", DEVICE_NAME = "Second" },
            new DEVICE { DEVICE_ID = "3", DEVICE_NAME = "Third" },
        };
}

public class DEVICE
{
    public string DEVICE_ID { get; set; }

    public string DEVICE_NAME { get; set; }
}
