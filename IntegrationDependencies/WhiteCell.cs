namespace IntegrationDependencies
{
    public class WhiteCell : Drawning
    {
        public string? Color { get; set; }
        public WhiteCell() { }
        public void Draw() => this.Color = "white";//белый цвет
    }
}