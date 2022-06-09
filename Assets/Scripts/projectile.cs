using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("crate"))
        {
            Destroy(collision.gameObject);
        }
    }
}