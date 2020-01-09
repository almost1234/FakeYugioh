using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIUpdater : MonoBehaviour
{
    public Text goldAvailable;
    public Text gold;
    public PlayerData data;
    
    public void ChangeNumber()
    {
        goldAvailable.text = data.goldAvailable.ToString();
        gold.text = data.gold.ToString();
    }
}
