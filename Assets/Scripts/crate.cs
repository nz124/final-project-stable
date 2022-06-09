using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    public GameObject ammo;
    public bool drops;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            if (drops == true)
            {
                Instantiate(ammo, collision.transform.position, collision.transform.rotation);
                Destroy(gameObject);
            }
            Destroy(collision.gameObject);
        }
    }
}