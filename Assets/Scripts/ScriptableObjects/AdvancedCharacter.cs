using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Unity/AdvancedCharacters")]
public class AdvancedCharacter : Character
{

    [SerializeField]
    private float _stamina;

    [SerializeField]
    private float _maxStamina;

    [SerializeField]
    private int _regenLife;

    [SerializeField]
    private int _regenStamina;

    [SerializeField]
    private float _timeBeforeRegenLife;

    [SerializeField]
    private float _timeBeforeRegenStamina;

    

    
}
