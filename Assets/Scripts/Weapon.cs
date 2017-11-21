using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private float rateOfFire = 3;
    private Transform target;

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
        FindTarget();
        Shoot();
        yield return new WaitForSeconds(time);
        StartCoroutine(TimeToShoot(rateOfFire));
    }

    private void FindTarget()
    {
        //var targets = new List<GameObject>();
        //targets = GameObject.FindGameObjectsWithTag("Alien");
        var targets = GameObject.FindGameObjectsWithTag("Alien");
        target = targets[Random.Range(0, targets.Length)].transform;
        //target = GameObject.FindGameObjectWithTag("Alien").transform;
    }

    private void Shoot()
    {
        var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.GetComponent<Bullet>().Direction = target.position;
    }
}
