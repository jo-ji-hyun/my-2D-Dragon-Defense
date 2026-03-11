using System.Collections.Generic;
using UnityEngine;

[ExcelAsset(AssetPath ="06.ScriptableObject")]
public class GameData : ScriptableObject
{
	public List<UnitData> Unit; 
	//public List<EntityType> Enemy; 
}
