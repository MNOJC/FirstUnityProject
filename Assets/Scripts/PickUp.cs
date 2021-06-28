using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            Inventory.instance.addCoins(1);
            CurrentLevelManager.instance.coinsPickCount++;
            Destroy(gameObject);
        }
    }
}
