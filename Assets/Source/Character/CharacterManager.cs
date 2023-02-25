using UnityEngine;

[RequireComponent(typeof(CharacterMovement))]
public class CharacterManager : MonoBehaviour
{
    CharacterMovement movement;

    void Awake()
    {
        movement = GetComponent<CharacterMovement>();
    }

    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        if (x != 0)
        {
            movement.MoveHorizontal(x);
        }

        if (y > 0)
        {
            movement.MoveVertical(y);
        }
    }
}
