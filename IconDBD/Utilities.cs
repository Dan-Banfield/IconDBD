using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace IconDBD
{
    public static class Utilities
    {
        public static class MessageBox
        {
            public static void Info(string caption, string content) => System.Windows.Forms.MessageBox.Show(content, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            public static void Error(string caption, string content) => System.Windows.Forms.MessageBox.Show(content, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static async Task DeleteIconsAsync()
        {
            await Task.Factory.StartNew(() =>
            {
                foreach (string directory in Directory.GetDirectories(IconPackManager.GetDbDIconPath()))
                {
                    Directory.Delete(directory, true);
                }
            });
        }

        public static async Task ExtractZipFileAsync(string sourceFile, string destination)
        {
            await Task.Factory.StartNew(() =>
            {
                ZipFile.ExtractToDirectory(sourceFile, destination);
            });
        }
    }
}