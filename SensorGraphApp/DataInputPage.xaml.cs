namespace SensorGraphApp;

public partial class DataInputPage : ContentPage
{
    public DataInputPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string value = SensorEntry.Text;

        if (double.TryParse(value, out double result))
        {
            ResultLabel.Text = $"Value submitted: {result}";
        }
        else
        {
            ResultLabel.Text = "Invalid number. Please try again.";
        }
    }
}
