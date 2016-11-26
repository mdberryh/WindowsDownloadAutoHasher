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

namespace FHasher.Controls
{
    /// <summary>
    /// Interaction logic for FileHasherControl.xaml
    /// </summary>
    public partial class FileHasherControl : UserControl
    {
        public FileHasherControl()
        {
            InitializeComponent();
        }
        public string GetHash()
        {
            return txtBxFileHash.Text.Trim();
        }
        public bool ValidHash()
        {
            //TODO: do we have a valid hash size?

            if (txtBxFileHash.Text == "")
            {
                //we do not have a hash...
                return false;
            }

            return true;
        }

        private string fullFilePath = "";
        private void cmbHashType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var fhasher = new FileHasher();

            var item = (ComboBoxItem)e.AddedItems[0];
            string text = item.Content.ToString();

            if (fullFilePath == "")
            {
                //we do not have a file to hash...user must be entering a hash manually...
                //TODO: determine what hash they are entering.
                return;
            }

            if (text == "MD5")
            {
                //set to md5 hash
                txtBxFileHash.Text = fhasher.getFileHashMd5(fullFilePath);
            }
            if (text == "Sha256")
            {
                //set to md5 hash
                txtBxFileHash.Text = fhasher.getFileHashSha256(fullFilePath);
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
        private void btnFileBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            // Get the selected file name and display in a TextBox 
            if (openFileDialog.ShowDialog() == true)
            {
                // Open document 
                string filename = openFileDialog.FileName;
                SetFileDescriptions(filename);
            }
        }
        private void SetFileDescriptions(string filepath)
        {
            fullFilePath = filepath;

            txtBxFileName.Text = System.IO.Path.GetFileName(fullFilePath);
            txtBxFileSize.Text = GetFileSize(filepath).ToString();
            //hash the file
            txtBxFileHash.Text = GetFileHash(fullFilePath);
            cmbHashType.SelectedItem = cmbHashType.Items[1]; //sha256
        }

        private void grdFileHashCnt_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] droppedFilePaths = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                foreach (var path in droppedFilePaths)
                {


                    SetFileDescriptions(path);

                    //string location = null;
                    //int pxWidth = 0, pxHeight = 0;

                    //FileInfo fi = new FileInfo(path);
                    ////fi.Length  //File size
                    ////fi.DirectoryName //Directory
                    //using (var fs = fi.OpenRead())
                    //{
                    //    try
                    //    {
                    //        var bmpFrame = BitmapFrame.Create(fs);
                    //        var m = bmpFrame.Metadata as BitmapMetadata;
                    //        if (m != null)
                    //            location = m.Location;
                    //        pxWidth = bmpFrame.PixelWidth;
                    //        pxHeight = bmpFrame.PixelHeight;
                    //    }
                    //    catch
                    //    {
                    //        //File isn't image
                    //    }
                    //}

                    // this.fileList.Items.Add(string.Format("({0}x{1}), location: {2}", pxWidth, pxHeight, location));
                }
            }
        }

        private void grdFileHashCnt_DragOver(object sender, DragEventArgs e)
        {
            // this.Background = Brushes.Blue;
            this.Opacity = 70;
            this.Focus();
        }

        private void txtBxFileHash_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();
            e.Handled = true;
        }

        private void txtBxFileHash_KeyUp(object sender, KeyEventArgs e)
        {
            //we are entering a hash, so remove the filename!
            fullFilePath = "";
            txtBxFileName.Text = "";
            txtBxFileSize.Text = "";
        }

        private void txtBxFileHash_LostFocus(object sender, RoutedEventArgs e)
        {
            //TODO: the user has left this textbox, so we need to figure out what hash this is...

        }

        private void txtBxFileHash_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBox tb = (sender as TextBox);

            if (tb != null)

            {

                if (!tb.IsKeyboardFocusWithin)

                {

                    e.Handled = true;

                    tb.Focus();

                }

            }
        }
    }
}
