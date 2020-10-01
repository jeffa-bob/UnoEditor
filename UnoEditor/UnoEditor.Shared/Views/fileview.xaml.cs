using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
  public sealed partial class fileview : UserControl, INotifyPropertyChanged
  {
    StorageFolder directory;
    //IReadOnlyList<IStorageItem> combined;
    //IReadOnlyList<StorageFolder> dirs;
    IReadOnlyList<StorageFile> _files;
    IReadOnlyList<StorageFile> files { get { return _files; } set { _files = value; RaisePropertyChanged("files"); } }

    public async Task setdirectory(StorageFolder folder)
    {
      directory = folder;
      files = await directory.GetFilesAsync();
      //combined = directory.GetItemAsync();
      //dirs = directory.GetFolderAsync();
    }

    public fileview()
    {
      this.InitializeComponent();
    }

    private System.Delegate delpage;
    public Delegate Callpagemethod
    {
      set { delpage = value; }
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
