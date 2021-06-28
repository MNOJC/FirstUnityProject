using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevelManager : MonoBehaviour
{
    public static CurrentLevelManager instance;

    public int coinsPickCount;

    public bool isPlayerInLevel = false;

    private void Awake()
    {
        instance = this;
    }
}
