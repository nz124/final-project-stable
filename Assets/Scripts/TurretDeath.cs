using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDeath : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
        }
    }
}
