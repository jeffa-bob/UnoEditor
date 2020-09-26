using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using System.Text.RegularExpressions;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.MediaProperties;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoEditor.Shared.Views
{
  public sealed partial class Terminal2 : UserControl, INotifyPropertyChanged
  {
    private static Regex winregex = new Regex(@"(([A-Z]:.*>).*\n)", RegexOptions.Singleline);
    private static Regex bashregex = new Regex(@"[^@\s]+[^:]+[^\$].*\n.*");


    string inputbox { get; set; }
    private string _output;
    string output { get { return _output; } set { _output = value; RaisePropertyChanged("output"); } }
    DirectoryInfo cur { get; set; } = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
    string curdir { get; set; }
    private List<string> pastcommand = new List<string>{""};
    private int index = 0;
    Process cmd = new Process();

    public void initterminal()
    {
      //Unix
      if (Environment.OSVersion.Platform == PlatformID.Unix)
      {
        cmd.StartInfo.FileName = "/bin/bash";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.StartInfo.UseShellExecute = false;
      }
      //Windows
      else if (Environment.OSVersion.Platform == PlatformID.Win32NT)
      {
        cmd.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.StartInfo.UseShellExecute = false;
        //output = cmd.StandardOutput.ReadToEnd();
      }
      //MacOS
      else if (Environment.OSVersion.Platform == (PlatformID)6)
      {
        cmd.StartInfo.FileName = "/bin/zsh";
        cmd.StartInfo.RedirectStandardInput = true;
        cmd.StartInfo.RedirectStandardOutput = true;
        cmd.StartInfo.CreateNoWindow = true;
        cmd.StartInfo.UseShellExecute = false;
      }
    }

    public void ExecuteCommand(string com)
    {
      cmd.StartInfo.WorkingDirectory = cur.FullName;
      cmd.Start();
      cmd.StandardInput.WriteLine(com);
      cmd.StandardInput.Flush();
      cmd.StandardInput.Close();
      string temp = cmd.StandardOutput.ReadToEnd();
      if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        output += winregex.Match(temp).Value;
      else
        output += bashregex.Match(temp).Value;
      cmd.Close();
    }

    public Terminal2()
    {
      this.InitializeComponent();
      curdir = cur.Parent.FullName + ">";
      initterminal();
    }

    public void textboxsubmit(object sender, KeyRoutedEventArgs e)
    {
      TextBox text = sender as TextBox;
      switch (e.Key)
      {
        case Windows.System.VirtualKey.Enter:

          ExecuteCommand(text.Text);
          pastcommand.Insert(1, text.Text);
          index = 0;
          text.Text = string.Empty;
          break;
        case Windows.System.VirtualKey.Up:
          if (index < pastcommand.Count-1)
          {
            text.Text = pastcommand[++index];
          }
          break;
        case Windows.System.VirtualKey.Down:
          if (index > 0)
          {
            text.Text = pastcommand[--index];
          }
          break;
        default:
          break;
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
