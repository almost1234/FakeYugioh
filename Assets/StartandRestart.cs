using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartandRestart : MonoBehaviour
{
    public Animator animator;
    private RectTransform move;
    void Start()
    {
        move = GetComponent<RectTransform>();
        animator.SetBool("StartUp", true);
        gameObject.SetActive(true);
        move.anchoredPosition = new Vector2(Random.Range(-40.0f,35.0f), Random.Range(-50.0f, 37.0f));
        new WaitForSeconds(1.0f);
        animator.SetBool("StartUp", false);

    }

    public void Restart()
    {
        gameObject.SetActive(false);
        new WaitForSeconds(1.0f);
        animator.SetBool("StartUp", true);
        gameObject.SetActive(true);
        move.anchoredPosition = new Vector2(Random.Range(-40.0f, 35.0f), Random.Range(-50.0f, 37.0f));
        animator.SetBool("StartUp", false);
    }
}
