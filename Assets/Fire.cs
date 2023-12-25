using System;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float Speed = 50f;
    public float SlideKickSpeed = 6f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public GameObject slide;

    public static event Action pistolFire;
    
    public void FireGun()
    {
        GetComponent<AudioSource>().Play();

        var createBullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation) as GameObject;

        var bullet = createBullet.GetComponent<Rigidbody>();
        slide.GetComponent<Rigidbody>().velocity = slide.transform.forward * SlideKickSpeed;
        createBullet.GetComponent<Rigidbody>().velocity = Speed * bulletSpawn.up;
        Destroy(createBullet, 2f);
        pistolFire.Invoke();
    }
}
