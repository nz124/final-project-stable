using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncycrate : MonoBehaviour
{
    public int quantity = 1;
    public Transform spot1;
    public Transform spot2;
    public Transform spot3;
    public Transform spot4;
    public Transform spot5;
    public GameObject ammo;
    // Start is called before the first frame update

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        quantity = Random.Range(1, 5);
        if (collision.gameObject.tag == "Projectile")
        {
            if (quantity == 1)
            {
                Instantiate(ammo, spot1.position, Quaternion.identity);
            }
            if (quantity == 2)
            {
                Instantiate(ammo, spot1.position, Quaternion.identity);
                Instantiate(ammo, spot2.position, Quaternion.identity);
            }
            if (quantity == 3)
            {
                Instantiate(ammo, spot1.position, Quaternion.identity);
                Instantiate(ammo, spot2.position, Quaternion.identity);
                Instantiate(ammo, spot3.position, Quaternion.identity);
            }
            if (quantity == 4)
            {
                Instantiate(ammo, spot1.position, Quaternion.identity);
                Instantiate(ammo, spot2.position, Quaternion.identity);
                Instantiate(ammo, spot3.position, Quaternion.identity);
                Instantiate(ammo, spot4.position, Quaternion.identity);
            }
            if (quantity == 5)
            {
                Instantiate(ammo, spot1.position, Quaternion.identity);
                Instantiate(ammo, spot2.position, Quaternion.identity);
                Instantiate(ammo, spot3.position, Quaternion.identity);
                Instantiate(ammo, spot4.position, Quaternion.identity);
                Instantiate(ammo, spot5.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}

