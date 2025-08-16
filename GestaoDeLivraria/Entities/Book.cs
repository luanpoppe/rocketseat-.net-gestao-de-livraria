namespace GestaoDeLivraria.Entities;

public class Book
{
  public string Id { get; set; } = string.Empty;
  public string Title { get; set; } = string.Empty;
  public string Author { get; set; } = string.Empty;
  public Genre Genre { get; set; }
  public double Price { get; set; }
  public double InStock { get; set; }
}
