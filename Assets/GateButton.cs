using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateButton : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPage;
    [SerializeField]
    private EnemySelector chooseEnemy;
    [SerializeField]
    private PlayerData data;
    [SerializeField]
    private UIUpdater uiUpdate;
    private Button theGateButton;
    private int enemyType;
    
    void Start()
    {
        enemyType = 0;
        //selecting the enemy group
        theGateButton = GetComponent<Button>();
        theGateButton.onClick.AddListener(enableEnemyPage);
        // why cant I add parameter to the called function?
        // when using addlistener, it will call a function. Can enemyPage.SetActive(true) be written for the call?
        // if not, why?
        
    }

    // Update is called once per frame
    void enableEnemyPage()
    {
        enemyPage.SetActive(true);
        chooseEnemy.ChooseEnemyType(enemyType);
        data.enemySelect = enemyType;
        uiUpdate.EnemyUIUpdate();
    }
}
