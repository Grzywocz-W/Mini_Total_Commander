using System;
using System.Collections.Generic;
using System.IO;

namespace MiniTC.Models
{
    public class FileSystemModel
    {
        // Zwraca listę dostępnych dysków (np. C:\, D:\ itd.)
        public List<string> GetAvailableDrives()
        {
            List<string> drives = new List<string>();

            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                    drives.Add(drive.Name);
            }

            return drives;
        }

        // Zwraca pełną zawartość katalogu (foldery i pliki) z uwzględnieniem prefiksów
        public List<string> GetDirectoryContent(string path)
        {
            List<string> items = new List<string>();

            try
            {
                if (!IsRoot(path))
                    items.Add(".."); // dodaj cofnięcie się w górę katalogów

                // Dodaj foldery z prefiksem <D>
                foreach (var dir in Directory.GetDirectories(path))
                {
                    string folderName = "<D> " + Path.GetFileName(dir);
                    items.Add(folderName);
                }

                // Dodaj pliki
                foreach (var file in Directory.GetFiles(path))
                {
                    items.Add(Path.GetFileName(file));
                }
            }
            catch (UnauthorizedAccessException)
            {
                items.Add("[Brak dostępu]");
            }
            catch (Exception ex)
            {
                items.Add("[Błąd] " + ex.Message);
            }

            return items;
        }

        
        
        // Sprawdza, czy dana ścieżka jest katalogiem głównym (np. C:\)
        public bool IsRoot(string path)
        {
            if (string.IsNullOrEmpty(path)) return false;
            string root = Path.GetPathRoot(path);
            return string.Equals(root, path, StringComparison.OrdinalIgnoreCase);
        }

        
        // Zwraca katalog nadrzędny
        public string GetParentDirectory(string path)
        {
            try
            {
                return Directory.GetParent(path)?.FullName;
            }
            catch
            {
                return path;
            }
        }

        
        // Sprawdza, czy element w liście to folder
        public bool IsDirectory(string displayItem)
        {
            return displayItem.StartsWith("<D> ");
        }

        
        // Wyciąga nazwę elementu bez prefiksu
        public string GetItemName(string displayItem)
        {
            if (IsDirectory(displayItem))
                return displayItem.Substring(4);
            return displayItem;
        }
    }
}

