using BarriesUtility.Services;
using BarriesUtility.

namespace BarriesUtility.Forms;

public partial class MainForm : Form
{
    private NavigationService _navigationService;
    public MainForm()
    {
        InitializeComponent();
        _navigationService = new NavigationService(ContentPanel);
        _navigationService.NavigateTo

    }

    private void ContentPanel_Paint(object sender, PaintEventArgs e) { }
}

