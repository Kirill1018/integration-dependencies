namespace IntegrationDependencies
{
	public class Chessboard
	{
		public WhiteCell WhiteCell { get; } = new WhiteCell();//объект рисования белой клетки
		public BlackCell BlackCell { get; } = new BlackCell();//объект рисования чёрной клетки
		public Chessboard() { }
	}
}