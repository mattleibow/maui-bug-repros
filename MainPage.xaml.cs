namespace TestMaui;

public partial class MainPage : ContentPage
{
    private string name = "This is text.";

    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    public string Name
    {
        get => name;
        set
        {
            System.Diagnostics.Debug.WriteLine($"Name fired: '{name}' => '{value}'");

            name = value;
        }
    }
}


