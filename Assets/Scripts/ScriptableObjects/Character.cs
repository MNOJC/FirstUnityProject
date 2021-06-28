using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Unity/Characters")]
public class Character : ScriptableObject
{
    [SerializeField]
    private int _life;

    [SerializeField]
    private int _maxLife;
    private bool _isInDanger;

   

}
