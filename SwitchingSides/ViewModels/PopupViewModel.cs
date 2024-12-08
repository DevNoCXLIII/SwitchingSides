using CommunityToolkit.Mvvm.ComponentModel;

namespace SwitchingSides.ViewModels;

public partial class PopupViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _popupContent = string.Empty;
    
    private readonly DashboardViewModel _dashboardViewModel;
    
    public PopupViewModel(DashboardViewModel dashboardViewModel)
    {
        _dashboardViewModel = dashboardViewModel;
    }
    
    // Design Time Constructor
    public PopupViewModel()
    {
        _dashboardViewModel = new DashboardViewModel();
    }
}