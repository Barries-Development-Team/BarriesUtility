using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarriesUtility.Pages;

public partial class Home : UserControl
{
    public Home()
    {
        InitializeComponent();
    }

    private void TestButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello World!");
    }
}
