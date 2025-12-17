namespace Planeedid.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public string HeroImage { get; set; }
        public string Description { get; set; }

        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }

        public List<string> Images { get; set; } = new();

        public Brush Background
        {
            get
            {
                return new LinearGradientBrush(
                    new GradientStopCollection
                    {
                        new GradientStop(AccentColorStart, 0.0f),
                        new GradientStop(AccentColorEnd, 1.0f)
                    },
                    new Point(0, 0),
                    new Point(1, 1)
                );
            }
        }
    }
}
