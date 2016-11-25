using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using System.Threading;
using System.Windows.Threading;
using Microsoft.Win32;

namespace DownloadWatcherHashHelper
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static FileCreatedDetected fileCreatedWindow;
        private static MainWindow main;
        private List<string> createdFiles = new List<string>();

        public MainWindow(MainWindow _main) : this()
        {
            //if I need to have a popup I can do that with this window.
            //BtnCompare.Visibility = Visibility.Hidden;
        }

        public MainWindow()
        {
            InitializeComponent();


            AppContent.Children.Add(new FileHasherControlPage());

            // fileCreatedWindow = new FileCreatedDetected();
            // fileCreatedWindow.Hide();

            //string PathTowatch = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //CreateFileWatcher(Directory.GetParent(PathTowatch) + "\\Downloads\\");
            //this.Hide();
            main = this;

        }
        private void startHashProcess(string filePath)
        {

            //this will ask the user about hashing the file.
            fileCreatedWindow = new FileCreatedDetected(filePath);
            fileCreatedWindow.Show();
        }

        public void CreateFileWatcher(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path; // Directory.GetParent(PathTowatch) + "\\Downloads";

            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            //watcher.Filter = "*.txt";

            // txtBox.Text = Directory.GetParent(PathTowatch) + "\\Downloads\\";
            //Console.WriteLine("path: " + Directory.GetParent(PathTowatch) + "\\Downloads\\");
            // Add event handlers.
            // watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            //watcher.Deleted += new FileSystemEventHandler(OnChanged);
            //watcher.Renamed += new RenamedEventHandler(OnRenamed);

            //watcher.IncludeSubdirectories = true;
            // Begin watching.
            watcher.EnableRaisingEvents = true;

        }

        //private static void ThreadProc(){
        //    //THIS IS WHERE THE CODE CAN DO THE HASHING ETC OR WE CAN FORGET THREADING.
        //    var fileCreatedWindow = new FileCreatedDetected();
        //    fileCreatedWindow.Show();
        //    fileCreatedWindow.Focus();
        //    Console.WriteLine("Running thread");
        //}




        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            //Check if this file is an exe, iso, img, msi 
            if ((!e.Name.Contains(".part")) && (e.Name.Contains(".exe") || e.Name.Contains(".iso") || e.Name.Contains(".img") || e.Name.Contains(".msi")))
            {
                //OPTIONAL THREADING...THIS IS NOT WHERE TO PUT IT
                //Thread t = new Thread(new ThreadStart(ThreadProc));
                //t.SetApartmentState(ApartmentState.STA);
                //t.Start();
                // fileCreatedWindow.ShowDialog();

                Action action = delegate ()
                {
                    // do stuff to UI
                  //  main.txtBxFileName.Text = e.Name;
                    main.createdFiles.Add(e.FullPath);
                    Console.WriteLine("Running thread");
                    //activate function to handle the file.
                    main.startHashProcess(e.FullPath);

                };
                main.Dispatcher.Invoke(DispatcherPriority.Normal, action);
                //lstRawDataFiles.Invoke(new MethodInvoker(delegate { Refresh_Files(true); }));
            }


            // Specify what is done when a file is changed, created, or deleted.
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //Open the Settings editor...
            //this is where they should be able to change which file types are watched.
            // change which directory is watched
            // set whether this app should auto start.
            // set if this app should start in minimized mode, where is is only a running process.


        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
