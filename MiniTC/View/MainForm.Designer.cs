namespace MiniTC
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private MiniTC.Views.PanelTC panelLeft;
        private MiniTC.Views.PanelTC panelRight;
        private System.Windows.Forms.Button buttonCopy;

        private void InitializeComponent()
        {
            panelLeft = new Views.PanelTC();
            panelRight = new Views.PanelTC();
            buttonCopy = new Button();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.CurrentPath = "";
            panelLeft.Location = new Point(13, 14);
            panelLeft.Margin = new Padding(4, 5, 4, 5);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(470, 629);
            panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            panelRight.CurrentPath = "";
            panelRight.Location = new Point(584, 18);
            panelRight.Margin = new Padding(4, 5, 4, 5);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(470, 615);
            panelRight.TabIndex = 2;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(491, 306);
            buttonCopy.Margin = new Padding(4, 5, 4, 5);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(93, 62);
            buttonCopy.TabIndex = 0;
            buttonCopy.Text = "Kopiuj";
            buttonCopy.Click += buttonCopy_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(buttonCopy);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MiniTC";
            ResumeLayout(false);
        }

        #endregion
    }
}
