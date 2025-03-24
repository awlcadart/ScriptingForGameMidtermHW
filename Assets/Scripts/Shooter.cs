using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce;
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce);
            //changed up to forward so player can shoot towards targets they are facing

            Destroy(bullet, .50f);
            // changed lifespan of bullet, original value felt too short.
        }

    }
}
