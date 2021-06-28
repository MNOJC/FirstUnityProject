using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public SpriteRenderer graphics;

    private Transform target;
    private int destPoint = 0;

    public GameObject deathEffect;

    public AudioClip sound;


    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(speed * Time.deltaTime * dir.normalized, Space.World); 

        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];

            graphics.flipX = !graphics.flipX;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player")) // detecte collision avec le player
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>(); // si il detecte il prend des degats
            playerHealth.TakeDamage(20);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
