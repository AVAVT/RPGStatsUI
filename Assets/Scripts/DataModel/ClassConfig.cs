using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ClassConfig", menuName = "Databases/ClassConfig")]
public class ClassConfig : ScriptableObject
{
  [SelectableString(typeof(ClassType))] public string ClassType;
  public Sprite Avatar;
  [Range(StatsModel.MIN_STATS_VALUE, StatsModel.MAX_STATS_VALUE)] public int HP;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Atk;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Def;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Mag;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Res;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Spd;
  [Range(StatsModel.MIN_ATTRIBUTE_VALUE, StatsModel.MAX_ATTRIBUTE_VALUE)] public int Luk;
  public SkillConfig[] skills;
}