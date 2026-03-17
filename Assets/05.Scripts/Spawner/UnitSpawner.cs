using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject unit;

    public void Spawn(int id)
    {
        var data = DataManager.Instance.GetUnitData(id);

        if (data != null)
        {
            Debug.Log($"소환 {data.Name}, 공격력 {data.Atk}, Hp: {data.Hp}");

            Vector3 pos = transform.position;

            Instantiate(unit, pos, Quaternion.identity);
        } 
    }
}
