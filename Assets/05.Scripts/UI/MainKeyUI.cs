using UnityEngine;
using UnityEngine.InputSystem;

public class MainKeyUI : MonoBehaviour
{
    [SerializeField] private UnitSpawner unitSpawner;

    private float oneUnitCooltime = 0.0f;

    private void Update()
    {
        if (oneUnitCooltime > 0.0f)
        {
            oneUnitCooltime -= Time.deltaTime;
        }
    }

    public void OnSpawn1(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        if (oneUnitCooltime > 0.0f)
        {
            Debug.LogError($"유닛 1 쿨타임 남은 시간{oneUnitCooltime}초");
            return;
        }

        var data = DataManager.Instance.GetUnitData(10001001);

        if (data != null)
        {
            unitSpawner.Spawn(10001001);

            oneUnitCooltime = data.Cooltime;
        }
    }
}
