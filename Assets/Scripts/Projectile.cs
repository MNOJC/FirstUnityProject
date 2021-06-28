using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float projectileSpeed;

    private new Rigidbody2D rigidbody;

    public GameObject fireImpact;
    public AudioClip sound;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectileSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Props") || collision.CompareTag("Enemy"))
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            Instantiate(fireImpact, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
            
        }
    }

}
