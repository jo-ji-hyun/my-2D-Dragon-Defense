using System.Collections.Generic;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    protected override bool IsDestroy => false;

    [SerializeField] private GameData gameData;

    private Dictionary<int, UnitData> unitById = new Dictionary<int, UnitData>();

    protected override void Awake()
    {
        base.Awake();

        foreach(var data in gameData.Unit)
        {
            if (!unitById.ContainsKey(data.Id))
            {
                unitById.Add(data.Id, data);
            }
        }
    }

    public UnitData GetUnitData(int id)
    {
        if(unitById.TryGetValue(id, out var data))
        {
            return data;
        }

        return null;
    }
}
