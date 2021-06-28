using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealZone : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            playerHealth.TakeHeal();
            Destroy(gameObject);
        }
        

     
    }
    }
