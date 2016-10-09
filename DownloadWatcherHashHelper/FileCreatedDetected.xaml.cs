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
using System.Windows.Shapes;

using System.IO;

namespace DownloadWatcherHashHelper
{
    /// <summary>
    /// Interaction logic for FileCreatedDetected.xaml
    /// </summary>
    public partial class FileCreatedDetected : Window
    {
        private string fullFilePath;
        public FileCreatedDetected(string path)
        {
            InitializeComponent();

            txtlblFilename.Content = System.IO.Path.GetFileName(path);
            fullFilePath = path;
        }

        private void txtBoxHash_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxHash.Text != "")
            {
                FileHasher hasher = new FileHasher();
                FileHashedPrompt prompt = new FileHashedPrompt(hasher.compareHash(fullFilePath, txtBoxHash.Text));
                prompt.ShowDialog();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
