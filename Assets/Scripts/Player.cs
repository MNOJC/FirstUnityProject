using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    enum eType { Ally, Enemy, Neutral };

    public interface IDamageable
    {
        void Damage(int pDamage);
    }

    public interface IHealable
    {
        void Heal(int pHeal);
    }

    
   
        [SerializeField]
        private int _gems;
        private int _orbs;

        [SerializeField]
        private int _symbols;

        [SerializeField]
        private int _level;

        [SerializeField]
        private string _name;
        private float _experiences;
        private float _maxExperiences;

        [SerializeField]
        private Role _role;
        private AdvancedCharacter _advancedCharacter;


    
    
}
