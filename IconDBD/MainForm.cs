using System;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;

namespace IconDBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void selectIconPackButton_Click(object sender, EventArgs e)
        {
            using (VistaOpenFileDialog vistaOpenFileDialog = new VistaOpenFileDialog())
            {
                #region File Dialog Settings

                vistaOpenFileDialog.Title = "Select an Icon Pack";
                vistaOpenFileDialog.Filter = "ZIP Files (*.zip)|*.zip|RAR Files (*.rar)|*.rar";
                vistaOpenFileDialog.Multiselect = false;

                #endregion

                if (vistaOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    IconPackManager.SelectedIconPack = vistaOpenFileDialog.FileName;
                    selectedIconPackLabel.Text = $"Selected icon pack: {Path.GetFileNameWithoutExtension(IconPackManager.SelectedIconPack)}";
                }
            }
        }

        private void resetIconsToDefaultButton_Click(object sender, EventArgs e) => Utilities.MessageBox.Info("Information", "To reset the icons back to default:\n\n1. Open Steam and right-click Dead by Daylight.\n\n2. Click Properties.\n\n 3. Click Installed Files.\n\n 4. Click verify integrity of game files.\n\nWait for this to be done, and everything should be back to normal.");

        private void installSelectedIconPackButton_Click(object sender, EventArgs e) => InstallDBDIconPack();

        #endregion

        #region Methods

        private async void InstallDBDIconPack()
        {
            if (string.IsNullOrEmpty(IconPackManager.SelectedIconPack))
            {
                Utilities.MessageBox.Error("Wait...", "You must select an icon pack first!");
                return;
            }
            if (string.IsNullOrEmpty(IconPackManager.GetDbDIconPath()))
            {
                Utilities.MessageBox.Error("Oops", "Dead by Daylight is not installed.");
                return;
            }

            ToggleControls(false);

            await Utilities.DeleteIconsAsync();
            await Utilities.ExtractZipFileAsync(IconPackManager.SelectedIconPack, IconPackManager.GetDbDIconPath());

            Utilities.MessageBox.Info("Success!", "Icon pack installed successfully.");

            ToggleControls(true);
        }

        private void ToggleControls(bool enabled)
        {
            foreach (Control control in Controls)
            {
                control.Enabled = enabled;
            }
        }

        #endregion
    }
}