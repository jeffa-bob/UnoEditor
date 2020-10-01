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
  class line
  {
    private string text;

    int position;

    //indentation in spaces.
    int indentation;

    public line(string _text, int _position = 0)
    {
      position = _position;
      text = _text;
      indentation = text.TakeWhile(char.IsWhiteSpace).Count();
    }

    public string GetTextLine()
    {
      return new string(' ', indentation) + text;
    }

    public static string Listlinetostring(List<line> lines)
    {
      string output = string.Empty;
      foreach (line line in lines)
      {
        output += line.GetTextLine();
      }
      return output;
    }

  }

  public sealed partial class texteditor : UserControl, INotifyPropertyChanged
  {

    StorageFile StorageFile;


    public string filepath;

    public string filename;

    private List<line> _filetextlines;
    List<line> filetextlines
    {
      get { return _filetextlines; }
      set
      {
        _filetextlines = value;
        RaisePropertyChanged("filetextlines");
      }
    }


    private FileInfo _curfile;
    FileInfo curfile
    {
      get { return _curfile; }
      set { _curfile = value; RaisePropertyChanged("curfile"); }
    }

    private string _editorstring;
    public string editorstring
    {
      get { return _editorstring; }
      set { _editorstring = value; RaisePropertyChanged("editorstring"); }
    }

    public texteditor()
    {
      this.InitializeComponent();
      //Readfile();
    }

    public async Task Readfile(StorageFile file)
    {
      StorageFile = file;
      filepath = file.Path;
      filename = file.Name;
      try
      {
        Stream filestream = await file.OpenStreamForReadAsync();
        string lines = filestream.ReadToEnd();
        //  foreach (string i in lines.Split(new[] { '\r', '\n' }))
        //  {
        //    filetextlines.Add(new line(i, filetextlines.Count));
        //  }
        editorstring = lines;
        edit.Document.SetText(TextSetOptions.Unlink, lines);
      }
      catch (Exception e)
      {
        var a = new MessageDialog(e.Message);
        await a.ShowAsync();
      }
    }
    public async Task Savefile()
    {
      try
      {
        string text;
        edit.Document.GetText(TextGetOptions.None, out text);
        await Windows.Storage.FileIO.WriteTextAsync(StorageFile, text);
      }
      catch (Exception e)
      {
        var a = new MessageDialog(e.Message);
        await a.ShowAsync();
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
