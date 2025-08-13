using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MiniTC.Models;
using MiniTC.Views;

namespace MiniTC.Presenters
{
    public class PanelTCPresenter
    {
        private readonly PanelTC _view;
        private readonly FileSystemModel _model;

        public PanelTCPresenter(PanelTC view)
        {
            _view = view;
            _model = new FileSystemModel();
        }

        // Pobierz dostępne napędy
        public void UpdateDrives()
        {
            var drives = _model.GetAvailableDrives();
            _view.SetDrives(drives);
        }

        // Po wyborze napędu – ustaw jako bieżącą ścieżkę
        public void ChangeDrive(string drive)
        {
            if (Directory.Exists(drive))
            {
                _view.CurrentPath = drive;
                var items = _model.GetDirectoryContent(drive);
                _view.SetDirectoryContent(items);
            }
        }

        // Po kliknięciu folderu / ".." / pliku
        public void EnterItem(string selectedItem)
        {
            if (string.IsNullOrWhiteSpace(selectedItem)) return;

            string currentPath = _view.CurrentPath;

            if (selectedItem == "..")
            {
                var parent = _model.GetParentDirectory(currentPath);
                if (parent != null)
                {
                    _view.CurrentPath = parent;
                    _view.SetDirectoryContent(_model.GetDirectoryContent(parent));
                }
            }
            else
            {
                string name = _model.GetItemName(selectedItem);
                string newPath = Path.Combine(currentPath, name);

                if (_model.IsDirectory(selectedItem) && Directory.Exists(newPath))
                {
                    _view.CurrentPath = newPath;
                    _view.SetDirectoryContent(_model.GetDirectoryContent(newPath));
                }
            }
        }

        /*// Aktualizacja zawartości folderu
        private void UpdateDirectoryContent(string path)
        {
            var items = new List<string>();

            if (Directory.GetParent(path) != null)
                items.Add("..");

            try
            {
                var directories = Directory.GetDirectories(path)
                    .Select(d => "<D> " + Path.GetFileName(d));
                var files = Directory.GetFiles(path)
                    .Select(f => Path.GetFileName(f));

                items.AddRange(directories);
                items.AddRange(files);
            }
            catch (Exception)
            {
                // Możesz tu zalogować lub pokazać błąd, jeśli potrzebujesz
            }

            _view.SetDirectoryContent(items);
        }*/
    }
}
