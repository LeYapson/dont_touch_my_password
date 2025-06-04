using Avalonia.Controls;
using dont_touch_my_password.ViewModels;

namespace dont_touch_my_password.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Créer et assigner le ViewModel
        DataContext = new MainWindowViewModel();
        
        var passwordsGrid = this.Find<DataGrid>("PasswordsGrid");
        if (passwordsGrid != null)
        {
            // Configurer les colonnes du DataGrid
            passwordsGrid.Columns.Add(new DataGridTextColumn { Header = "Nom", Binding = new Avalonia.Data.Binding("Name") });
            passwordsGrid.Columns.Add(new DataGridTextColumn { Header = "Identifiant", Binding = new Avalonia.Data.Binding("Username") });
            passwordsGrid.Columns.Add(new DataGridTextColumn { Header = "Mot de passe", Binding = new Avalonia.Data.Binding("Password") });
            passwordsGrid.Columns.Add(new DataGridTextColumn { Header = "URL", Binding = new Avalonia.Data.Binding("Url") });
            passwordsGrid.Columns.Add(new DataGridTextColumn { Header = "Notes", Binding = new Avalonia.Data.Binding("Notes") });
            
            // Assigner la source de données pour le DataGrid
            passwordsGrid.ItemsSource = (DataContext as MainWindowViewModel)?.Passwords;
        }
    }
}
