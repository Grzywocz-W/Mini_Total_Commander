namespace MiniTC.Views
{
    partial class PanelTC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListBox listBoxItems;
        private void InitializeComponent()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            // comboBoxDrives
            this.comboBoxDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(10, 10);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDrives.DropDown += new System.EventHandler(this.comboBoxDrives_DropDown);
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrives_SelectedIndexChanged);

            // textBoxPath
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(120, 10);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(300, 20);

            // listBoxItems
            this.listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(10, 40);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(800, 320);
            this.listBoxItems.DoubleClick += new System.EventHandler(this.listBoxItems_DoubleClick);

            // PanelTC
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.listBoxItems);
            this.Name = "PanelTC";
            this.Size = new System.Drawing.Size(430, 350);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        
    }
}
