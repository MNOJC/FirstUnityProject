using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public Text textCoin;

    public static Inventory instance;

    private void Awake()
    {
        instance = this; //permet d'acceder au script depuis d'autre script sans avoir besoin de faire de reference
    }

    public void addCoins(int count)
    {
        coinsCount += count; //ajoute +1 piece
        textCoin.text = coinsCount.ToString();//affiche le nombre de pieces 
    }

    public void removeCoins(int count)
    {
        coinsCount -= count; 
        textCoin.text = coinsCount.ToString();
    }
}
