using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Thiskord_Front.ViewModels;

namespace Thiskord_Front;

public sealed partial class Login : Page
{
    public LoginViewModel ViewModel { get; }

    public Login()
    {
        this.InitializeComponent();
        ViewModel = new LoginViewModel();
        ViewModel.OnSimulationPopupRequested += ShowJsonPopup;
    }

    private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    {
        if (sender is PasswordBox pb)
        {
            ViewModel.Password = pb.Password;
        }
    }

    private async void ShowJsonPopup(string jsonContent)
    {
        if (Content is FrameworkElement fe && fe.XamlRoot != null)
        {
            ContentDialog dialog = new ContentDialog
            {
                XamlRoot = fe.XamlRoot,
                Title = "Simulation Communication API",
                Content = new ScrollViewer
                {
                    MaxHeight = 600,
                    Content = new TextBlock 
                    { 
                        Text = jsonContent, 
                        TextWrapping = TextWrapping.Wrap,
                        FontFamily = new Microsoft.UI.Xaml.Media.FontFamily("Consolas"),
                        Padding = new Thickness(10)
                    }
                },
                PrimaryButtonText = "OK",
                DefaultButton = ContentDialogButton.Primary
            };

            await dialog.ShowAsync();
        }
    }
}