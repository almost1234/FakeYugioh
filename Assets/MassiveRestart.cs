using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassiveRestart : MonoBehaviour
{   public Transform group;
    public SlideBottomUI variableCheck;
    [SerializeField ]
    private PlayerData data;
    private int counter;

    private void Start()
    {
  
    }
    public void ResetAllCollectibles()
    {
        if (variableCheck.stageNumber != variableCheck.holder)
        {
            foreach (Transform gold in group)
            {
                if (counter < data.goldAvailable)
                {
                    counter = counter + 1;
                    StartandRestart something = gold.GetComponent<StartandRestart>();
                    something.Restart();
                }
                else
                {
                    gold.gameObject.SetActive(false);
                }
            }// need some better improvement on the selection
            counter = 0;
        }
        
    }
}
