using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int goldAvailable;
    public int gold;
    public int keys;
    public int enemySelect;
    public int enemyChoose;
    [SerializeField]
    private UIUpdater uiUpdate;

    private void Start()
    {
        goldAvailable = 9;
        gold = 0;
        keys = 0;
        enemyChoose = 0;
    }

    public void OnPressCollectible(int state, int number)
    {
        if (state == 1)
        {
            keys = keys + number;
            goldAvailable = goldAvailable - 1;
            Debug.Log("Key: " + keys.ToString());
        }

        else
        {
            gold = gold + number;
            goldAvailable = goldAvailable - 1;
        }
        uiUpdate.ChangeNumber();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            if(Input.GetKeyDown("right"))
            {
                if (enemyChoose == 3)
                {
                    enemyChoose = 0;
                }

                else
                {
                    enemyChoose += 1;
                }
            }

            else if (Input.GetKeyDown("left"))
            {
                if (enemyChoose == 0)
                {
                    enemyChoose = 3;
                }

                else
                {
                    enemyChoose -= 1;
                }
            }

            Debug.Log("GateNumber: " + enemyChoose.ToString());
            uiUpdate.EnemyUIUpdate();
        
        }
    }

    public void keyReduce()
    {
        keys = keys - 50;
    }
}
