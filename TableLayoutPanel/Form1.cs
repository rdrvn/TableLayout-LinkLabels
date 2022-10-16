using System.Diagnostics;

namespace TableLayoutPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(400, 450);
            this.Text = "ButtonForm";

            Button formButton = new();
            formButton.Text = "TablePanelLayout";
            formButton.Size = new System.Drawing.Size(120, 40);
            formButton.Left = (this.ClientSize.Width - formButton.Width) / 2;
            formButton.Top = (this.ClientSize.Height - formButton.Height) / 2;
            formButton.Anchor = AnchorStyles.None;
            formButton.Cursor = System.Windows.Forms.Cursors.Hand;

            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "developed by: @reedtzdrvn",
                LinkArea = new LinkArea(14, 25),
                Dock = DockStyle.Right,
                AutoSize = true,
            };

            linkLabel.LinkClicked += LinkLabel_LinkClicked;

            this.Controls.Add(formButton);
            this.Controls.Add(linkLabel);
            formButton.Click += FormButton_Click;
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new("https://github.com/rdrvn")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(psi);
        }

        private void FormButton_Click(object? sender, EventArgs e)
        {
            TablePanel newTablePanel = new();
            newTablePanel.Show();
        }
    }
}