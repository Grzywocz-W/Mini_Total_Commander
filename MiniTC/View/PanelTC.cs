using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MiniTC.Presenters;

namespace MiniTC.Views
{
    public partial class PanelTC : UserControl
    {
        private readonly PanelTCPresenter _presenter;
        public ListBox ListBoxItems => listBoxItems;       //przydatne do MainForm.cs

        public PanelTC()
        {
            InitializeComponent();
            listBoxItems.SelectedIndexChanged += ListBoxItems_SelectedIndexChanged;
            _presenter = new PanelTCPresenter(this);
        }

        // ========== INTERFEJS PUBLICZNY ==========

        public string CurrentPath
        {
            get => textBoxPath.Text;
            set => textBoxPath.Text = value;
        }

        public string SelectedItem => listBoxItems.SelectedItem as string;

        public void SetDrives(IEnumerable<string> drives)
        {
            comboBoxDrives.Items.Clear();
            comboBoxDrives.Items.AddRange(drives.ToArray());
        }

        public void SetDirectoryContent(IEnumerable<string> items)
        {
            listBoxItems.Items.Clear();
            listBoxItems.Items.AddRange(items.ToArray());
        }

        public void SetDrive(string drive)
        {
            comboBoxDrives.SelectedItem = drive;
        }

        public void ForceRefresh()
        {
            _presenter.ChangeDrive(CurrentPath);
        }

        public void ClearSelection()
        {
            listBoxItems.ClearSelected();
        }



        // ========== OBSŁUGA ZDARZEŃ ==========

        private void comboBoxDrives_DropDown(object sender, EventArgs e)
        {
            _presenter.UpdateDrives();
        }

        private void comboBoxDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDrives.SelectedItem != null)
                _presenter.ChangeDrive(comboBoxDrives.SelectedItem.ToString());
        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem != null)
                _presenter.EnterItem(listBoxItems.SelectedItem.ToString());
        }

        public event EventHandler SelectionChanged;
        private void ListBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }




    }
}
