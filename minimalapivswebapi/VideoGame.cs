namespace minimalapivswebapi
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
    }
}
