using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace DownloadWatcherHashHelper
{
    class FileHasher
    {
        //http://msdn.microsoft.com/en-us/library/ms752299(v=vs.110).aspx
        //http://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp
        //http://www.dotnetspark.com/kb/1888-compare-two-files-with-hash-algorithm.aspx
        //http://stackoverflow.com/questions/10520048/calculate-md5-checksum-for-a-file/10520086#10520086

        public FileHasher()
        {

        }

        public string getFileHash(string filePath)
        {
            //TODO: implement
            return null;
        }

        public bool compareHash(string filePath, string userHash)
        {

            //we don't know what the hash is before this, so we can check with length.
            //do the hash functions on the file.

            string md5hash;
            string sha256hash;
            string tocompare;
            Console.WriteLine("hash length " + userHash.Length );
            if (userHash.Length == 32) //number of characters in a md5 hash string
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        tocompare = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }
            }
            else if (userHash.Length == 64)
            {
                //we will assume it is sha256
                using (var sha256 = SHA256.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        tocompare = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }
            }
            else
            {
                //we dont know so check both
                Console.WriteLine("Couldn't figure out what hash type...");
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        tocompare = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }

                if (tocompare == userHash)
                {
                    return true;
                }

                using (var sha256 = SHA256.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        tocompare = BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }
                if (tocompare == userHash)
                {
                    return true;
                }


            }
            Console.WriteLine("Program's hash is: ");
            Console.WriteLine(tocompare);
            Console.WriteLine("Users's hash is: ");
            Console.WriteLine(userHash);
            if (tocompare == userHash)
            {
                return true;
            }




            return false;
        }

    }
}
