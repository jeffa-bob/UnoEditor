using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace UnoEditor.Shared.Views.Editor
{
  public class suggest
  {
    string suggestcode;
    string title;
    string desc;

    public suggest(string _suggest, string _title, string _desc)
    {
      suggestcode = _suggest;
      title = _title;
      desc = _desc;
    }
  }

  public sealed partial class suggestbox : UserControl
  {
    List<suggest> suggestions = new List<suggest>();

    public suggestbox()
    {
      this.InitializeComponent();
    }
  }
}
