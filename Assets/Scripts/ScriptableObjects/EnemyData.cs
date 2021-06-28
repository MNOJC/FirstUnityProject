using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "Unity/Enemys")]
public class Enemy : ScriptableObject
{ 
    [SerializeField]
    private int Health;

    [SerializeField]
    private int Damage;
}
