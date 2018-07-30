using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SkillConfig", menuName = "Databases/SkillConfig")]
public class SkillConfig : ScriptableObject
{
  public string Name;
  [SelectableString(typeof(DamageType))] public string DamageType;
  [TextArea(4, 10)] public string Description;
  [SelectableString(typeof(RowPositionType))] public string[] UsablePositions;
}