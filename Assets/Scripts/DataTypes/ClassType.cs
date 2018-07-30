public class ClassType
{
  private static string[] values;
  public static string[] Values()
  {
    if (values == null)
    {
      values = new string[] {
        "Werewolf",
        "Zombie",
        "Witch",
        "Vampire"
      };
    }
    return values;
  }

  public const string Werewolf = "Werewolf";
  public const string Zombie = "Zombie";
  public const string Witch = "Witch";
  public const string Vampire = "Vampire";
}