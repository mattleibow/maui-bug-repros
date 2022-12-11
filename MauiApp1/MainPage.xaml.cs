using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    public ObservableCollection<string> Items { get; } =
        new()
        {
            "Switch",
            "Slider",
            "Button",
        };
}

[ContentProperty(nameof(Templates))]
public class DynamicTemplateSelector : DataTemplateSelector
{
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var name = item?.ToString();

        DynamicDataTemplate def = null;

        foreach (var template in Templates)
        {
            if (template.Key == name)
                return template;

            if (template.Key == "Default" || template.Key is null)
                def = template;
        }

        return def ?? throw new InvalidOperationException("Missing the 'Default' data template.");
    }

    public ObservableCollection<DynamicDataTemplate> Templates { get; } = new();
}

[ContentProperty(nameof(Template))]
public class DynamicDataTemplate : BindableObject
{
    public string Key { get; set; }

    public DataTemplate Template { get; set; }

    public static implicit operator DataTemplate(DynamicDataTemplate dynamicTemplate) =>
        dynamicTemplate.Template;
}