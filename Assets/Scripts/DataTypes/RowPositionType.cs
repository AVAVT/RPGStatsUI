public class RowPositionType
{
  private static string[] values;
  public static string[] Values()
  {
    if (values == null)
    {
      values = new string[] {
        "Front",
        "Middle",
        "Rear"
      };
    }
    return values;
  }

  public const string Front = "Front";
  public const string Middle = "Middle";
  public const string Rear = "Rear";
}