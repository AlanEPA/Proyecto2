using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassDamage : MonoBehaviour
{
    [Header("Class Type: Damage")]

    
    [SerializeField] private float range;

    [SerializeField] private float timeBetweenShoot;
    [SerializeField] private float timeDelayShoot;
    private float lastTimeShoot;
    [SerializeField] private LayerMask monstersMask;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPositionShoot;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(bulletPositionShoot.transform.position, bulletPositionShoot.transform.right);
        Debug.DrawRay(ray.origin, ray.direction * range, Color.red);

        if (Physics.Raycast(ray, out hit, range, monstersMask))
        {
            Debug.Log("Shoot");
            Debug.DrawRay(ray.origin, ray.direction * range, Color.green);
            if (Time.time > lastTimeShoot + timeBetweenShoot)
            {
                StartCoroutine(ShootProyectile());
                lastTimeShoot = Time.time;
            }
        }
    }

    IEnumerator ShootProyectile()
    {
            yield return new WaitForSeconds(timeDelayShoot);
            Instantiate(bulletPrefab, bulletPositionShoot.transform.position, Quaternion.identity);  
    }

  
}
