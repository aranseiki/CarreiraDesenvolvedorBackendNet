using Balta.ContentContext.Enums;

namespace Balta.ContentContext {
    public class Lecture {
        public int Sort { get; set; }
        public string? Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
    }
}