using UnityEngine;
using System.Collections;

public class VerhicleController : MonoBehaviour {

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    public float shotForce = 1000f;


    public GameObject projectile;
    public GameObject clone;


    public Transform shotPos;
    public Transform miniPosition;

    public static int bulletIdentity;
    public int maxObjects = 5;



    bool firstPersonLook = true;

    void Start()
    {
        CreateClone();
    }
    void Update()
    {
        //left can be changed into any button that is left on the joystick it is to change the object that the player can then shoot by pressing the fire button
        if (Input.GetButtonDown("left"))
        {
            Debug.Log("Left");
            if (bulletIdentity != 0)
            {
                bulletIdentity--;
				CreateClone();
                Debug.Log(bulletIdentity);
            }
        }
        else if (Input.GetButtonDown("right"))
        {
            if (bulletIdentity != PrefabStorage.prefabCount)
            {
                bulletIdentity++;
				CreateClone();
                Debug.Log(bulletIdentity);
            }
        }

        if (firstPersonLook == true && Input.GetButtonDown("B Button"))
        {
            firstPersonLook = false;
            Debug.Log("firstpersonlook = false");
        }
        else if (firstPersonLook == false && Input.GetButtonDown("B Button"))
        {
            firstPersonLook = true;
            Debug.Log("firstpersonlook = true");
        }
        if (firstPersonLook == true)
        {
            float translationRight = Input.GetAxis("Vertical") * speed;
            float translationLeft = Input.GetAxis("Vertical") * speed;

            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            translationRight *= Time.deltaTime;
            translationLeft *= Time.deltaTime;
            rotation *= Time.deltaTime;
            transform.Translate(0, 0, translationRight);//transform forward
            transform.Translate(0, 0, -translationLeft);//transform backward
            transform.Rotate(0, rotation, 0);

            if (Input.GetButtonUp("Fire1"))
            {
                Fire();
            }
        }
    }

    void Fire()
    {
        GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
        shot.GetComponent<Rigidbody>().AddForce(shotPos.up * shotForce);
    }

    void CreateClone()
    {
        Destroy(clone);
        GameObject prefab = GameObject.Find("prefabStorage");
        PrefabStorage prefabStorage = prefab.GetComponent<PrefabStorage>();
        clone = Instantiate(prefabStorage.miniPrefabs[bulletIdentity], miniPosition.position, Quaternion.identity) as GameObject;
        clone.transform.parent = transform;
    }
}
