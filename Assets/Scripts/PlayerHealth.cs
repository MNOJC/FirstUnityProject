using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public bool isDamageable = true;

    public float delayFlash = 0.20f;

    public SpriteRenderer Sprite;
    public HealthBar healthBar;

    public GameObject deathEffect;

    public static PlayerHealth instance;

    public AudioClip sound;
    public AudioClip sound1;


    private int i = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); //met la vie au max au commencement
    }

   
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (isDamageable) //si il peut prendre des degats
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            currentHealth -= damage;  //on lui retire de la vie
            healthBar.SetHealth(currentHealth);  //on l'affiche

            if(currentHealth <= 0)
            {
                Death();
                return;
            }

            isDamageable = false;               //il ne peut plus prendre de degats
            StartCoroutine(DamageableFlash());  //on fait l'effet de clignotement
            StartCoroutine(DamageableDelay());  //au bout de 2s il peut reprendre des degats
        }
    }

    public IEnumerator DamageableFlash()
    {
        while (!isDamageable)
        {
            Sprite.color = new Color(1f, 1f, 1f, 0f);
            yield return new WaitForSeconds(delayFlash);
            Sprite.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(delayFlash);
        }
    }

    public IEnumerator DamageableDelay()
    {
        yield return new WaitForSeconds(2f);
        isDamageable = true;
    }

    public void HealPlayer(int quantity)
    {
        currentHealth += quantity;
        healthBar.SetHealth(currentHealth);
    }

    public IEnumerator HealingZone()
    {
        while ((i != 20) && (currentHealth != maxHealth))
        {
            i++;
            HealPlayer(2);
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void TakeHeal()
    {
        StartCoroutine(HealingZone());
    }

    public void Death()
    {
        AudioManager.instance.PlaySoundAt(sound, transform.position);
        MovementController.instance.enabled = false;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Sprite.enabled = false;
        GameOver.instance.WhenPlayerDeath();
    }

    public void Respawn()
    {
        MovementController.instance.enabled = true;
        
        Sprite.enabled = true;
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }
}
