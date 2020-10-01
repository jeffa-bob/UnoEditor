using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows.Input;
using Uno.Extensions;
using Uno.Extensions.Specialized;
using UnoEditor.Shared.Views;
using UnoEditor.Shared.Views.Editor;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoEditor
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page, INotifyPropertyChanged
  {
    public MainPage()
    {
      this.InitializeComponent();
      _editors = new ObservableCollection<texteditor>();
    }

    ObservableCollection<texteditor> _editors;
    ObservableCollection<texteditor> editors { get { return _editors; } set { _editors = value; RaisePropertyChanged("editors"); } }

    public async void ButtonOpen(object sender, RoutedEventArgs e)
    {
      var picker = new Windows.Storage.Pickers.FileOpenPicker();
      picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
      picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
      picker.FileTypeFilter.Add("*");
      Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
      texteditor editor = new texteditor();
      await editor.Readfile(file);
      editors.Add(editor);
      StorageFolder tempfold = await file.GetParentAsync();
      fileviewer1.setdirectory(tempfold);
    }

    public async void Openfolder(object sender, RoutedEventArgs e)
    {
      var picker = new Windows.Storage.Pickers.FolderPicker();
      picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
      picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
      picker.FileTypeFilter.Add("*");
      Windows.Storage.StorageFolder folder = await picker.PickSingleFolderAsync();
      fileviewer1.setdirectory(folder);
    }
    public async void Savefile(object sender, RoutedEventArgs e)
    {
      editor1.Savefile();
    }
    public async void Closefile(object sender, RoutedEventArgs e)
    {
      Button button = sender as Button;
      editors = editors.Where(c => c.filepath != (string)button.Tag).ToObservableCollection();
    }
    public async void Showfile(object sender, RoutedEventArgs e)
    {
      Button button = sender as Button;
      editor1 = editors.Where(c => c.filepath == (string)button.Tag).First();
      editor1.SetValue(Grid.RowProperty, 1);
      editor1.SetValue(Grid.ColumnProperty, 1);
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
