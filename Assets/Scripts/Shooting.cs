using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootForce;
    public Transform muzzlePoint;
    public GameObject projectile;
    public float projectileLifetime = 5.0f;
    public float fireTime;
    float timeToFire;
    public GameObject[] bullets;
    public int curBullet = 0;
    public GameObject plat;
    public GameObject bounce;
    // Start is called before the first frame update
    void Start()
    {
        timeToFire = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            curBullet++;
            if (curBullet == bullets.Length)
            {
                curBullet = 0;
            }
        }
        timeToFire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeToFire <= 0f)
        {
            GameObject currProjectile = (GameObject)Instantiate(bullets[curBullet], muzzlePoint.position, muzzlePoint.rotation);
            currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.forward * shootForce);
            Destroy(currProjectile, projectileLifetime);
            timeToFire = fireTime;

        }


    }
}
