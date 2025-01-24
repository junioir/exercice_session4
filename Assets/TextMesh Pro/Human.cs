
using UnityEngine;

public class Humane: MonoBehaviour
{
    [SerializeField] private Gun _equipedGun;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _equipedGun.Shoot();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            _equipedGun.Reload();
        }
    }
}
