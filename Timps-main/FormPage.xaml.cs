
using CommunityToolkit.Maui.Markup;
using Newtonsoft.Json;
using TekTrackingCore.Sample.Models;
using TekTrackingCore.ViewModels;

namespace TekTrackingCore;

public partial class FormPage : ContentPage
{
    public FormPage(FormPageViewModel viewmodel)
    {
       
        InitializeComponent();
        BindingContext = viewmodel;
        viewmodel.setRenderCallBack = RenderForm;
     
    }
    public void RenderForm(string json)
    {
        var result = JsonConvert.DeserializeObject<dynamic>(json);
        var opt = result.opt1;
       // var tab = opt[0].sections[0].section_name;
        var scrollView = new ScrollView();
        var verticalStackLayout = new VerticalStackLayout();
        verticalStackLayout.Spacing = 25;
       // verticalStackLayout.BackgroundColor = Color.FromRgb(232, 227, 227);
        foreach(var tab in opt)
        {
            foreach (var section in tab.sections)
            {
                verticalStackLayout.Children.Add(new Label { Text = section.section_name, FontSize = 12 });
                foreach(var field in section.fields)
                {
                    if(field.field_type == "select")
                    {
                        var selectOptions = new List<string>();
                        foreach(var option in field.options)
                        {
                            string optionValue = option.label;
                            selectOptions.Add(optionValue);
                        }
                        Picker picker = new Picker { Title = field.field_label };
                        picker.ItemsSource = selectOptions;
                        verticalStackLayout.Children.Add(picker);

                    }else if(field.field_type == "text")
                    {
                        verticalStackLayout.Children.Add(new Entry { Placeholder = field.field_label } );
                    }else if(field.field_type == "checkbox")
                    {
                        verticalStackLayout.Children.Add(new Label { Text= field.field_label, FontSize = 12});
                        verticalStackLayout.Children.Add(new CheckBox { IsChecked = false });
                    }else if(field.field_type == "textArea")
                    {
                        verticalStackLayout.Children.Add(new Editor { Placeholder = field.field_label, HeightRequest = 250 });
                    }
                }
               
            }
        }
     
        verticalStackLayout.Paddings(25, 25, 25, 25);

        scrollView.Content = verticalStackLayout;
        Content = scrollView;

    }

}