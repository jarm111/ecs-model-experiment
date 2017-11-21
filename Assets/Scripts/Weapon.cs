using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float rateOfFire = 3;
    private Transform target;

    private void Start()
    {
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
            var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
            bulletInstance.GetComponent<Bullet>().Direction = target.position;
        }
    }
}
