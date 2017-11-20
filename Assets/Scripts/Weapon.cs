using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float rateOfFire = 3;
    [SerializeField]
    private Transform target;

    private void Shoot()
    {
        var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.GetComponent<Bullet>().Direction = target.position;
    }

    private void Start()
    {
        StartCoroutine(TimeToShoot(rateOfFire));
    }

    private void Update()
    {
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Shoot();
        //}
    }

    IEnumerator TimeToShoot(float time)
    {
        Shoot();
        yield return new WaitForSeconds(time);
        StartCoroutine(TimeToShoot(rateOfFire));
    }
}
