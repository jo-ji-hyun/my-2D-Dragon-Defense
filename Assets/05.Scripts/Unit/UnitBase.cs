using UnityEngine;

public class UnitBase : MonoBehaviour
{
    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float move_Speed = 2.0f;

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(move_Speed, rigidbody2D.velocity.y);
    }
}
