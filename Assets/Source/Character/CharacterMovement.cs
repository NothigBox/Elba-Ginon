using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float walkForce;

    new private Rigidbody2D rigidbody;
    public bool canJump;

    void Awake()
    {
        canJump = true;

        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Terrain"))
        {
            canJump = true;
        }
    }

    public void MoveHorizontal(float x) 
    {
        rigidbody.AddForce(new Vector2(x * walkForce, 0f), ForceMode2D.Force);
        transform.localScale = new Vector3(x * -1, 1, 1);
    }

    public void MoveVertical(float y)
    {
        if (canJump) 
        {
            canJump = false;
            rigidbody.AddForce(new Vector2(0f, y * jumpForce), ForceMode2D.Impulse);
        }
    }
}
