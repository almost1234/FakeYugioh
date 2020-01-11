using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelector : MonoBehaviour
{
    public Transform enemyList;

    private void Start()
    {

    }
    public void ChooseEnemyType(int number)
    {
        List<string> enemyType = new List<string> { "Gate", "Normal" };
        foreach(Transform enemy in enemyList)
        {
            if (enemy.gameObject.tag == enemyType[number])
            {
                Debug.Log("Open: " + enemyType[number]);
                enemy.gameObject.SetActive(true);
            }

            else
            {
                enemy.gameObject.SetActive(false);
            }
        }
    }
}
