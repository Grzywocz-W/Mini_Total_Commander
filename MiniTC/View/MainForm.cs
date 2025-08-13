using System;
using System.IO;
using System.Windows.Forms;
using MiniTC.Views;

namespace MiniTC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelLeft.SelectionChanged += PanelLeft_SelectionChanged;
            panelRight.SelectionChanged += PanelRight_SelectionChanged;

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            PanelTC sourcePanel = null;
            PanelTC destPanel = null;

            if (panelLeft.ListBoxItems.SelectedItem != null && !panelLeft.SelectedItem.StartsWith("<D>") && panelLeft.SelectedItem != "..")
            {
                sourcePanel = panelLeft;
                destPanel = panelRight;
            }
            else if (panelRight.ListBoxItems.SelectedItem != null && !panelRight.SelectedItem.StartsWith("<D>") && panelRight.SelectedItem != "..")
            {
                sourcePanel = panelRight;
                destPanel = panelLeft;
            }

            if (sourcePanel == null || string.IsNullOrEmpty(sourcePanel.SelectedItem))
            {
                MessageBox.Show("Wybierz PLIK do skopiowania.");
                return;
            }

            string selectedFile = sourcePanel.SelectedItem;
            string sourceFilePath = Path.Combine(sourcePanel.CurrentPath, selectedFile);
            string destFilePath = Path.Combine(destPanel.CurrentPath, selectedFile);

            try
            {
                File.Copy(sourceFilePath, destFilePath, overwrite: true);
                MessageBox.Show("Plik skopiowany.");
                destPanel.ForceRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas kopiowania: " + ex.Message);
            }
        }


        private void PanelLeft_SelectionChanged(object sender, EventArgs e)
        {
            // Jeœli coœ zaznaczono w lewym panelu – odznacz prawy
            if (panelLeft.ListBoxItems.SelectedIndex >= 0)
            {
                panelRight.ClearSelection();
            }
        }
        private void PanelRight_SelectionChanged(object sender, EventArgs e)
        {
            // Jeœli coœ zaznaczono w prawym panelu – odznacz lewy
            if (panelRight.ListBoxItems.SelectedIndex >= 0)
            {
                panelLeft.ClearSelection();
            }
        }


    }
}

