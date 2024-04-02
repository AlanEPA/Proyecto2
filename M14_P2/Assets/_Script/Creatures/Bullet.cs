using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float damage;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float proyectileLife;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        LaunchBullet();
        StartCoroutine(DestroyProyectile());
        
    }

    private void LaunchBullet()
    {
        rb.velocity = Vector3.right * bulletSpeed;
    }

    IEnumerator DestroyProyectile()
    {
        yield return new WaitForSeconds(proyectileLife);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster")
        {
           Destroy(gameObject); 
        }
        
    }


}
