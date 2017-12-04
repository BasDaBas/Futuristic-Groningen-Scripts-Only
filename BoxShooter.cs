using UnityEngine;
using System.Collections;

public class BoxShooter : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 1000f;

    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Fire();
        }

        

    }

    void Fire()
    {
        Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
        shot.AddForce(shotPos.up * shotForce);        
    }
}

