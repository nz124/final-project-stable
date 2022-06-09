using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public float shootForce;
    public Transform muzzlePoint;
    public GameObject projectile;
    public float projectileLifetime = 5.0f;
    public float fireTime;
    public float changeTime;
    float timeToFire;
    float TimeToChange;
    public GameObject[] bullets;
    public int curBullet = 0;
    public GameObject plat;
    public GameObject bounce;
    public int GreenAmmo = 5;
    public int PinkAmmo = 0;
    public int BlueAmmo = 0;
    public Text GreenAmmoCount;
    public Text BlueAmmoCount;
    public Text PinkAmmoCount;
    public GameObject GreenCanvas;
    public GameObject BlueCanvas;
    public GameObject PinkCanvas;

    // Start is called before the first frame update
    void Start()
    {
        timeToFire = 0f;
        TimeToChange = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GreenAmmoCount.text = " " + GreenAmmo;
        BlueAmmoCount.text = " " + BlueAmmo;
        PinkAmmoCount.text = " " + PinkAmmo;
        timeToFire -= Time.deltaTime;
        TimeToChange -= Time.deltaTime;
        if (curBullet == 1)
        {
            GreenCanvas.SetActive(false);
            BlueCanvas.SetActive(true);
            PinkCanvas.SetActive(false);
            if (Input.GetKey(KeyCode.Tab) && TimeToChange <= 0f)
            {
                curBullet = 2;
                TimeToChange = changeTime;
            }
            if (Input.GetMouseButton(0) && timeToFire <= 0f && BlueAmmo > 0)
            {
                BlueAmmo = BlueAmmo - 1;
                GameObject currProjectile = (GameObject)Instantiate(bullets[curBullet], muzzlePoint.position, muzzlePoint.rotation);
                currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.up * shootForce);
                Destroy(currProjectile, projectileLifetime);
                timeToFire = fireTime;
            }
        }
        if (curBullet == 2)
        {
            GreenCanvas.SetActive(false);
            BlueCanvas.SetActive(false);
            PinkCanvas.SetActive(true);
            if (Input.GetKey(KeyCode.Tab) && TimeToChange <= 0f)
            {
                curBullet = 0;
                TimeToChange = changeTime;
            }
            if (Input.GetMouseButton(0) && timeToFire <= 0f && PinkAmmo > 0)
            {
                PinkAmmo = PinkAmmo - 1;
                GameObject currProjectile = (GameObject)Instantiate(bullets[curBullet], muzzlePoint.position, muzzlePoint.rotation);
                currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.up * shootForce);
                Destroy(currProjectile, projectileLifetime);
                timeToFire = fireTime;
            }
        }
        if (curBullet == 0)
        {
            GreenCanvas.SetActive(true);
            BlueCanvas.SetActive(false);
            PinkCanvas.SetActive(false);
            if (Input.GetKey(KeyCode.Tab) && TimeToChange <= 0f)
            {
                curBullet = 1;
                TimeToChange = changeTime;
            }
            if (Input.GetMouseButton(0) && timeToFire <= 0f && GreenAmmo > 0)
            {
                GreenAmmo = GreenAmmo - 1;
                GameObject currProjectile = (GameObject)Instantiate(bullets[curBullet], muzzlePoint.position, muzzlePoint.rotation);
                currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.up * shootForce);
                Destroy(currProjectile, projectileLifetime);
                timeToFire = fireTime;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green Ammo")
        {
            GreenAmmo = GreenAmmo + 1;
            Destroy(other.gameObject);
            Debug.Log(GreenAmmo);
        }
        if (other.gameObject.tag == "Pink Ammo")
        {
            PinkAmmo = PinkAmmo + 1;
            Destroy(other.gameObject);
            Debug.Log(GreenAmmo);
        }
        if (other.gameObject.tag == "Blue Ammo")
        {
            BlueAmmo = BlueAmmo + 1;
            Destroy(other.gameObject);
            Debug.Log(GreenAmmo);
        }
    }
}
