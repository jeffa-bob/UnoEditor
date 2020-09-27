using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace UnoEditor.Shared.Views
{
  public sealed partial class Editor : UserControl, INotifyPropertyChanged
  {
    private string _filepath;
    public string filepath
    {
      get { return _filepath; }
      set
      {
        _filepath = value;
        curfile = new FileInfo(value);
        RaisePropertyChanged("filepath");
      }
    }

    private List<string> _filetextlines;
    List<string> filetextlines
    {
      get { return _filetextlines; }
      set
      {
        _filetextlines = value;
        RaisePropertyChanged("filetextlines");
      }
    }

    string fulltext { get; set; }

    private FileInfo _curfile;
    FileInfo curfile
    {
      get { return _curfile; }
      set { _curfile = value; RaisePropertyChanged("curfile"); }
    }

    public Editor()
    {
      this.InitializeComponent();
      filepath = @"E:\test.js";
      //Readfile();
    }

    public void Readfile()
    {
      //filetextlines = File.ReadAllLines(filepath).ToList();
      using (StreamReader sr = new StreamReader(filepath))
      {
        fulltext = sr.ReadToEnd();
      }
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
