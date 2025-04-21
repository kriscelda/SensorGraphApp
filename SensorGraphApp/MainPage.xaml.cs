using System;
using Microsoft.Maui.Controls;
using SensorGraphApp; // make sure this matches your actual namespace


namespace SensorGraphApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterBtn.Text = $"Clicked {count} times";
    }

    private async void OnGoToInputPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DataInputPage());
    }

    private async void OnGoToGraphPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GraphPage());
    }
}
