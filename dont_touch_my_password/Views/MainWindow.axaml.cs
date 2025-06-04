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
            
            // Assigner la source de données pour le DataGrid
            passwordsGrid.ItemsSource = (DataContext as MainWindowViewModel)?.Passwords;
        }
    }
}
