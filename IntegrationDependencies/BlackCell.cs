namespace IntegrationDependencies
{
    public class BlackCell : Drawning
    {
        public string? Color { get; set; }
        public BlackCell() { }
        public void Draw() => this.Color = "black";//чёрный цвет
    }
}