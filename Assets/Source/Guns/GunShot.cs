using UnityEngine;

public class GunShot : MonoBehaviour
{
    public void Trigger(Vector3 direction) 
    {
        Debug.DrawRay(transform.position, direction, Color.red, 1f);
    }
}
