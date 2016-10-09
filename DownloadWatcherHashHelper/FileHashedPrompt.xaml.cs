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

namespace DownloadWatcherHashHelper
{
    /// <summary>
    /// Interaction logic for FileHashedPrompt.xaml
    /// </summary>
    public partial class FileHashedPrompt : Window
    {
        public FileHashedPrompt(bool filepassed)
        {
            InitializeComponent();
            string message;

            if (filepassed)
            {
                message = "The file matched the provided\nhash. This means the file\nis OK to install!!\n";
            }
            else
            {
                
                message = "The file did not match the\nhash. This means the file\nhas been modified from the\noriginal.\n\nDO NOT INSTALL!!";
            }
            txtlblMessage.Content = message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
