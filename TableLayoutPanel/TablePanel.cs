namespace TableLayoutPanel
{
    public partial class TablePanel : Form
    {
        public TablePanel()
        {
            InitializeComponent();
        }

        private void TablePanel_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(550, 550);

            
            tableLayoutPanel1.BackColor = Color.AliceBlue;
            for (int i = 0; i < 9; i++)
            {
                tableLayoutPanel1.Controls.Add(new Button() { Dock = DockStyle.Fill, Text = $"Button {i + 1}", Cursor = System.Windows.Forms.Cursors.Hand });
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //tableLayoutPanel1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            
        }
    }
}
