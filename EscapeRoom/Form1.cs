namespace EscapeRoom
{
    public partial class frmMainMenu : Form
    {
        int CompletedPuzzles;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmNorth frmNorth = new frmNorth();
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnLeaderBoard_Click(object sender, EventArgs e)
        {
            frmLeaderBoard frmLeaderBoard = new frmLeaderBoard();
            frmLeaderBoard.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
