using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public GameObject projectile;
    public Transform muzzlePoint;
    public GameObject projectileParent;
    public float projectileLifespan = 5;
    public float projectileSpeed = 1000;
    public float waitTime = 2;
    float timer;
    private void Start()
    {
        timer = 2;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer -= Time.deltaTime;
            transform.LookAt(other.gameObject.transform);
        }
        if (timer <= 0 && other.gameObject.tag == "Player")
        {
            //instantiate our prefab projectile
            GameObject currProjectile = Instantiate(projectile, muzzlePoint.position, muzzlePoint.rotation);
            timer = waitTime;
            //set the parent of the projectile to a null object so it is not impaced by our character movement
            currProjectile.transform.SetParent(projectileParent.transform);
            //add force to the projectile
            currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.up * projectileSpeed);
            //destroy the projectile after time has passed
            Destroy(currProjectile, projectileLifespan);
        }
    }
}
