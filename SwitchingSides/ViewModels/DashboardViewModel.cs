using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentAvalonia.UI.Controls;
using SwitchingSides.Views;

namespace SwitchingSides.ViewModels;

public partial class DashboardViewModel : ViewModelBase
{
    private readonly PopupViewModel _popupViewModel;
    
    [ObservableProperty]
    private string _gotPopupContent = string.Empty;
    
    public DashboardViewModel()
    {
        _popupViewModel = new PopupViewModel(this);
    }
    
    [RelayCommand]
    private async Task ShowPopup()
    {
        var contentDialog = new ContentDialog
        {
            Title = "This is a popup",
            PrimaryButtonText = "OK",
            CloseButtonText = "Cancel",
            Content = new PopupView
            {
                DataContext = _popupViewModel
            }
        };

        var result = await contentDialog.ShowAsync();
        if (result == ContentDialogResult.Primary) GotPopupContent = _popupViewModel.PopupContent;
    }
}