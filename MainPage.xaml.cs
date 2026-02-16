using Goals.Models;
using System.Text.Json;

namespace Goals;

public partial class MainPage : ContentPage
{
    public List<Goal> Goals { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadGoalsAsync();
    }

    private async Task LoadGoalsAsync()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("goals.json");
            Goals = await JsonSerializer.DeserializeAsync<List<Goal>>(stream) ?? new List<Goal>();
            GoalsCollection.ItemsSource = Goals;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error loading goals: {ex.Message}");
            Goals = new List<Goal>();
            GoalsCollection.ItemsSource = Goals;
        }
    }

    private void OnGoalSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Goal goal)
        {
            System.Diagnostics.Debug.WriteLine($"Navigate to Detail Page for goal: {goal.Title}");
            ((CollectionView)sender).SelectedItem = null;
        }
    }

    private void OnAddGoalClicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Navigate to Add Item Page");
    }
}
