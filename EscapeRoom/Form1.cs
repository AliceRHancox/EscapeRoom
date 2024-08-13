namespace EscapeRoom
{
    public partial class frmMainMenu : Form
    {
        //creates an int and a list of object puzzles that are public to the form. This means it can be accessed in any method without having to be sent across
        int CompletedPuzzles;
        List<Puzzles> allPuzzles = new List<Puzzles>();
        public frmMainMenu()
        {
            InitializeComponent();
        }
        //if the start button is clicked this code will play
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //Creates an array of type sting holding the puzzle codes
            string[] Puzzlecodes = {"umbrella", "301489", "10"};
            //creates a bool called complete and sets it to false
            bool complete = false;
            //for the length of the puzzle code array
            for(int i = 0; i < Puzzlecodes.Length; i++)
            {
                //add the responding code and a complete bool to the puzzle class and puts that into the list of objects
                allPuzzles.Add(new Puzzles(Puzzlecodes[i], complete));
            }
            //Opens the north form and sends across completed puzzles int and the list of objects
            //also makes it so when re opened this form will close
            frmNorth frmNorth = new frmNorth(CompletedPuzzles, allPuzzles);
            frmNorth.ShowDialog();
            System.Windows.Forms.Application.ExitThread();
        }
        //if leaderboard button is clicked this will play
       

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
           
        }

        //If end button is clicked it will close this form
        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }


    }
}
