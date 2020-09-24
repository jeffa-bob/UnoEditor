using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoEditor.Shared.Views
{
  public sealed partial class Terminal : UserControl, INotifyPropertyChanged
  {
    string textbox { get; set; }
    DirectoryInfo cur { get; set; }

    public void ExecuteCommand(string command) {
    
    }

    public Terminal()
    {
      this.InitializeComponent();
      cur = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void NotifyPropertyChanged(string info)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(info));
    }
  }
}
