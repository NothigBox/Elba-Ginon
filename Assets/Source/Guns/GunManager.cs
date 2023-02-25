using UnityEngine;

[RequireComponent(typeof(GunShot))]
public class GunManager : MonoBehaviour
{
    private GunShot shot;

    private void Awake()
    {
        shot = GetComponent<GunShot>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            print(CharacterAim._Direction.eulerAngles);
            shot.Trigger(CharacterAim._Direction.eulerAngles);
        }
    }
}
