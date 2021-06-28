using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Transform firePosition;
    public GameObject projectile;
    public AudioClip sound;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.instance.PlaySoundAt(sound, transform.position);
            Instantiate(projectile, firePosition.position, firePosition.rotation);
        }
        
    }


}
