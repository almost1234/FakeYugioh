using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIUpdater : MonoBehaviour
{
    public Text goldAvailable;
    public Text gold;
    public PlayerData data;
    public List<string> enemyData;
    public Image enemyPicture;
    public Text enemyDeckName;
    public Text keyValue;
    public Button fightGateButton;


    private void Start()
    {
        
    }
    public void ChangeNumber()
    {
        goldAvailable.text = data.goldAvailable.ToString();
        gold.text = data.gold.ToString();
    }

    public void EnemyUIUpdate()
    {
        enemyData = new List<string>() { "Deck: One", "Deck: Two", "Deck: Three", "Deck: Four" };
        enemyDeckName.text = enemyData[data.enemyChoose];
        keyValue.text = data.keys.ToString() + "/50";

        if (data.keys > 50)
        {
            fightGateButton.interactable = true;
        }

        else
        {
            fightGateButton.interactable = false;
        }
    }
}
