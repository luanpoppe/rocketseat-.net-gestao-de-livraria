using GestaoDeLivraria.Entities;

namespace GestaoDeLivraria.Communication.Requests;

public class RequestRegisterBookJson
{
  public string Title { get; set; } = string.Empty;
  public string Author { get; set; } = string.Empty;
  public Genre Genre { get; set; }
  public double Price { get; set; }
  public double InStock { get; set; }
}
