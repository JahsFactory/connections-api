using ConnectionsApi.Models;

namespace ConnectionsApi.Data
{
    public static class PuzzleRepository
    {
        // Put most recent puzzles at the TOP of the list!
        private static readonly List<ConnectionsPuzzle> Puzzles = new()
        {
            new ConnectionsPuzzle
            {
                Title = "July 28, 2025",
                Date = "2025-07-28",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Foremost", HexColor = "", Words = new List<string> { "First", "Initial", "Original", "Primary" } },
                    new PuzzleGroup { CategoryDescription = "Indication", HexColor = "", Words = new List<string> { "Evidence", "Hint", "Sign", "Trace" } },
                    new PuzzleGroup { CategoryDescription = "Item in a Collection", HexColor = "", Words = new List<string> { "Coin", "Comic", "Record", "Stamp" } },
                    new PuzzleGroup { CategoryDescription = "_ Movie", HexColor = "", Words = new List<string> { "Buddy", "Cult", "Date", "Silent" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 27, 2025",
                Date = "2025-07-27",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Nothing to it!", HexColor = "", Words = new List<string> { "Child's Play", "Easy", "No Sweat", "Piece of Cake" } },
                    new PuzzleGroup { CategoryDescription = "Outdoor Events", HexColor = "", Words = new List<string> { "Block Party", "Festival", "Picnic", "Tailgate" } },
                    new PuzzleGroup { CategoryDescription = "Words Before \"School\"", HexColor = "", Words = new List<string> { "Elementary", "Grade", "Grammar", "Primary" } },
                    new PuzzleGroup { CategoryDescription = "Associated With Tricks", HexColor = "", Words = new List<string> { "Con Game", "Halloween", "Hearts", "Magic Show" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 26, 2025",
                Date = "2025-07-26",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Travel on Foot", HexColor = "", Words = new List<string> { "Hike", "March", "Tramp", "Trek" } },
                    new PuzzleGroup { CategoryDescription = "Herbs and Spices", HexColor = "", Words = new List<string> { "Anise", "Dill", "Mace", "Sage" } },
                    new PuzzleGroup { CategoryDescription = "Shades of Green", HexColor = "", Words = new List<string> { "Bottle", "Hunter", "Kelly", "Pea" } },
                    new PuzzleGroup { CategoryDescription = "Starts of European Capitals", HexColor = "", Words = new List<string> { "Cope", "Luxe", "Sara", "Wars" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 25, 2025",
                Date = "2025-07-25",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Hush-Hush", HexColor = "", Words = new List<string> { "Mum", "Private", "Quiet", "Secret" } },
                    new PuzzleGroup { CategoryDescription = "Queen _", HexColor = "", Words = new List<string> { "Bed", "Bee", "Mary", "Mother" } },
                    new PuzzleGroup { CategoryDescription = "Baseball Calls", HexColor = "", Words = new List<string> { "Ball", "Fair", "Foul", "Out" } },
                    new PuzzleGroup { CategoryDescription = "State Abbreviations", HexColor = "", Words = new List<string> { "In", "Ma", "Oh", "Ok" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 24, 2025",
                Date = "2025-07-24",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Parts of a Basketball Hoop", HexColor = "", Words = new List<string> { "Backboard", "Net", "Pole", "Rim" } },
                    new PuzzleGroup { CategoryDescription = "Colossal", HexColor = "", Words = new List<string> { "Giant", "Great", "Mammoth", "Titanic" } },
                    new PuzzleGroup { CategoryDescription = "Leave Quickly", HexColor = "", Words = new List<string> { "Bounce", "Dip", "Jet", "Split" } },
                    new PuzzleGroup { CategoryDescription = "Homophones of Synonyms for \"Nab\"", HexColor = "", Words = new List<string> { "Knick", "Lute", "Rabe", "Steel" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 23, 2025",
                Date = "2025-07-23",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Related to Buying a Home", HexColor = "", Words = new List<string> { "Appraisal", "Escrow", "Insurance", "Mortgage" } },
                    new PuzzleGroup { CategoryDescription = "Kinds of Steaks", HexColor = "", Words = new List<string> { "Chateaubriand", "Flatiron", "Porterhouse", "Tomahawk" } },
                    new PuzzleGroup { CategoryDescription = "Dread-Inducing Figures", HexColor = "", Words = new List<string> { "Bogeyman", "Bugbear", "Hobgoblin", "Phantom" } },
                    new PuzzleGroup { CategoryDescription = "Animals Ending With Animals", HexColor = "", Words = new List<string> { "Geoduck", "Seahorse", "Titmouse", "Wombat" } }
                }
            },
            new ConnectionsPuzzle
            {
                Title = "July 22, 2025",
                Date = "2025-07-22",
                Groups = new List<PuzzleGroup>
                {
                    new PuzzleGroup { CategoryDescription = "Mitigate", HexColor = "", Words = new List<string> { "Cushion", "Dampen", "Soften", "Temper" } },
                    new PuzzleGroup { CategoryDescription = "Sassiness", HexColor = "", Words = new List<string> { "Attitude", "Cheek", "Lip", "Mouth" } },
                    new PuzzleGroup { CategoryDescription = "Patterns", HexColor = "", Words = new List<string> { "Camo", "Checkers", "Honeycomb", "Stripes" } },
                    new PuzzleGroup { CategoryDescription = "_ Pie", HexColor = "", Words = new List<string> { "Chess", "Cutie", "Humble", "Whoopie" } }
                }
            }
        };

        public static ConnectionsPuzzle GetRandomPuzzle()
        {
            var rand = new Random();
            return Puzzles[rand.Next(Puzzles.Count)];
        }

        public static ConnectionsPuzzle GetTodaysPuzzle()
        {
            return Puzzles[0];
        }

        public static ConnectionsPuzzle GetPuzzleByDate(string date)
        {
            var puzzle = Puzzles.FirstOrDefault(p => p.Date == date);
            return puzzle ?? GetTodaysPuzzle();
        }
    }
}
