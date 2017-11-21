using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float rateOfFire = 3;
    private Transform target;
    private Transform bulletSpawnPoint;

    private void Start()
    {
        bulletSpawnPoint = gameObject.transform.Find("BulletSpawnPoint");
        StartCoroutine(TimeToShoot(rateOfFire));
    }

    IEnumerator TimeToShoot(float time)
    {
        FindTarget();
        Shoot();
        yield return new WaitForSeconds(time);
        StartCoroutine(TimeToShoot(rateOfFire));
    }

    private void FindTarget()
    {
        var targets = GameObject.FindGameObjectsWithTag("Alien");
        if (targets.Length != 0)
        {
            target = targets[Random.Range(0, targets.Length)].transform;
        }
    }

    private void Shoot()
    {
        if (target != null)
        {
            var bulletInstance = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            bulletInstance.GetComponent<Bullet>().Direction = target.position;
        }
    }
}
