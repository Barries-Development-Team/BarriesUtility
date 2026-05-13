using System;
using System.Collections.Generic;
using System.Text;

namespace BarriesUtility.Services;

// Interface for navigation service that enforces a contract
// for navigating between UserControls in the application.
public interface INavigationService
{
    void NavigateTo(UserControl page);
}

// Implementation of the INavigationService interface that manages
// the navigation logic by adding and removing UserControls from a
// specified Panel.
public class NavigationService(Panel contentPanel) : INavigationService
{
    private readonly Panel _contentPanel = contentPanel; 
    private UserControl? _currentPage;

    public void NavigateTo(UserControl page)
    {
        if (_currentPage != null)
        {
            _contentPanel.Controls.Remove(_currentPage);
            _currentPage.Dispose();
        }

        _currentPage = page;
        page.Dock = DockStyle.Fill;
        _contentPanel.Controls.Add(page);
    }
}

