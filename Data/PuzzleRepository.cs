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
