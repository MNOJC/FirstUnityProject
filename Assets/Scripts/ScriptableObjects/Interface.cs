using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{

    public interface ICharacter
    {
        public void Die();
        public bool IsAlive();
    }

    public interface IAdvancedCharacter : ICharacter
    {
        public IEnumerator RegenLife();
        public IEnumerator RegenStamina();
    }
}
