using CommunityToolkit.Mvvm.ComponentModel;

namespace SwitchingSides.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase _currentViewModel = new ContactViewModel();
}