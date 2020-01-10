using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int goldAvailable;
    public int gold;
    public int keys;
    [SerializeField]
    private UIUpdater uiUpdate;

    private void Start()
    {
        goldAvailable = 9;
        gold = 0;
        keys = 0;

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

}
