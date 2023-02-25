using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    private static Quaternion _direction;

    public static Quaternion _Direction => _direction;

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);
        _direction = transform.rotation;
    }
}
