public class DamageType
{
  private static string[] values;
  public static string[] Values()
  {
    if (values == null)
    {
      values = new string[] {
        "Atk",
        "Mag",
        "None"
      };
    }
    return values;
  }

  public const string Atk = "Atk";
  public const string Mag = "Mag";
  public const string None = "None";
}