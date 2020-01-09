using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int goldAvailable;
    public int gold;

    public delegate void OnCollectibles();
    public event OnCollectibles UpdateUI;

    private void Start()
    {
        goldAvailable = 9;
        gold = 0;
    }

    public void OnPressCollectible(int number)
    {
        gold = gold + number;
        goldAvailable = goldAvailable - 1;
    }

}
