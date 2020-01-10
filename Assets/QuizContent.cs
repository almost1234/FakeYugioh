using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizContent : MonoBehaviour
{
    public GameObject preFabButton;
    [SerializeField]
    private Transform ContentQuiz;
    private bool created;

    void Start()
    {
        

    }

    public void ContentStart()
    {   if (created == false) 
        {
            List<string> tested = new List<string> { "Puzzle Easy", "Puzzle Medium", "Puzzle Hard" };
            foreach (string name in tested)
            {
                GameObject button = Instantiate(preFabButton);
                Text buttonText = button.GetComponentInChildren<Text>();
                buttonText.text = name;
                button.gameObject.AddComponent<QuizLevel1>();
                button.transform.SetParent(ContentQuiz);
            }
        }
        created = true;

    }
}
