using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    // Start is called before the first frame update
    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            Instantiate(platform, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

