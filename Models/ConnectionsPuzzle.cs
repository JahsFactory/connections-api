using System.Drawing;

namespace ConnectionsApi.Models
{
    public class ConnectionsPuzzle
    {
        public string Title { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty; // e.g. "2025-07-21"
        public List<PuzzleGroup> Groups { get; set; } = new List<PuzzleGroup>();
    }

    public class PuzzleGroup
    {
        public string CategoryDescription { get; set; } = string.Empty;
        public string HexColor { get; set; } = string.Empty; // Should be one of: a0c35a, f9df6d, b0c4ef, ba81c5
        public List<string> Words { get; set; } = new List<string>();
    }
}
