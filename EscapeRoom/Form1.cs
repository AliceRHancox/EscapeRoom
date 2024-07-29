namespace EscapeRoom
{
    public partial class frmMainMenu : Form
    {
        int CompletedPuzzles;
        List<Puzzles> Puzzle = new List<Puzzles>();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            string[] PuzzleNames = {"Window", "Bookshelf", "Painting"};
            bool complete = false;
            for(int i = 0; i < PuzzleNames.Length; i++)
            {
                Puzzle.Add(new Puzzles(PuzzleNames[i], complete));
            }
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, Puzzle);
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
