using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizLevel1 : MonoBehaviour
{
    private Button theButtonItself;
    private void Start()
    {
        theButtonItself = GetComponent<Button>();
        theButtonItself.onClick.AddListener(test);
    }

    private void test()
    {
        Debug.Log("FUCK");
    }
}
