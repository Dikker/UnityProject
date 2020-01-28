using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Transform _firepoint;
    public GameObject bulletPrefab;
    public GameObject shooter;
    Script bulletComponent;

    private void Awake()
    {
        _firepoint = transform.Find("firepoint");

    }


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(bulletPrefab != null && _firepoint != null && shooter != null)
        {
            GameObject myBullet = Instantiate(bulletPrefab, _firepoint.position, Quaternion.identity) as GameObject;

            bulletComponent = myBullet.GetComponent<Script>();

            if (shooter.transform.localScale.x < 0)
            {
                //left
                bulletComponent.direction = Vector2.left; // new Vector2(-1f, 0f)
            }
            else
            {
                //right
                bulletComponent.direction = Vector2.right; //  new Vector2(1f, 0f)
            }
            
        }
    }
}
