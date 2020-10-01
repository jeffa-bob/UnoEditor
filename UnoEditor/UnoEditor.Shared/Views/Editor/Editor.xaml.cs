using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Uno.Extensions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoEditor.Shared.Views.Editor
{

  public sealed partial class texteditor : UserControl, INotifyPropertyChanged
  {
    public editorclass Editorclass = new editorclass();

    public texteditor()
    {
      this.InitializeComponent();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void RaisePropertyChanged(string name)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(name));
      }
    }
  }
}
