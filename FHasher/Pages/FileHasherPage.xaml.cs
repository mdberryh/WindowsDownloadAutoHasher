using FHasher.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace FHasher.Pages
{
    /// <summary>
    /// Interaction logic for FileHasherPage.xaml
    /// </summary>
    public partial class FileHasherPage : UserControl
    {
        public FileHasherPage()
        {
            InitializeComponent();


            FirstHash.Children.Add(new FileHasherControl());
            FirstHash.Children.Add(new FileHasherControl());
        }

        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            //popup window for file to compare against.
            //var popup = new MainWindow(this);
            //popup.ShowDialog();

            var firstFile = (FileHasherControl)FirstHash.Children[0];
            var SecondFile = (FileHasherControl)FirstHash.Children[1];

            if (firstFile.ValidHash() && SecondFile.ValidHash())
            {
                if (firstFile.GetHash() == SecondFile.GetHash())
                {
                    MessageBox.Show("File matches! File should be fine to run");
                }
                else
                {
                    MessageBox.Show("NOT A MATCH...DO NOT RUN IF COMPARING THE HASH!!");
                }
            }
        }

        private void btnFileBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            // Get the selected file name and display in a TextBox 
            if (openFileDialog.ShowDialog() == true)
            {
                // Open document 
                string filename = openFileDialog.FileName;
                //    txtBxFileName.Text = filename;
                //    txtBxFileSize.Text = GetFileSize(filename).ToString();
                //hash the file
                //txtBxFileHash.Text = GetFileHash(filename);
                //   cmbHashType.SelectedItem = cmbHashType.Items[1]; //sha256
            }
        }

        private string GetFileHash(string path)
        {
            var fhasher = new FileHasher();
            return fhasher.getFileHashSha256(path);

        }
        private static long GetFileSize(string filename)
        {
            FileInfo fi = new FileInfo(filename);
            return fi.Length;
        }
        private void cmbHashType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var fhasher = new FileHasher();

            var item = (ComboBoxItem)e.AddedItems[0];
            string text = item.Content.ToString();
            if (text == "MD5")
            {
                //set to md5 hash
                // txtBxFileHash.Text = fhasher.getFileHashMd5(txtBxFileName.Text);
            }
            if (text == "Sha256")
            {
                //set to md5 hash
                // txtBxFileHash.Text = fhasher.getFileHashSha256(txtBxFileName.Text);
            }

        }
    }
}
