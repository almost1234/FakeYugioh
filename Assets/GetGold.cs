using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGold : MonoBehaviour
{
    private GameObject image;
    private GameObject text;
    public RectTransform position;
    private int counter;
    private void Start()
    {
        position = GetComponent<RectTransform>();
        image = GameObject.FindGameObjectWithTag("Image");
        text = GameObject.FindGameObjectWithTag("Text");

    }
    public void ContentPanel(int number)
    {
        if (number == 1)
        {
            Debug.Log("Activate Image");
            image.SetActive(true);
            text.SetActive(false);
        }

        else
        {
            Debug.Log("Activate Text");
            image.SetActive(false);
            text.SetActive(true);
        }

            position.anchoredPosition = new Vector2Int(-5, -5);
    }

    public void ClosePanel()
    {
        position.anchoredPosition = new Vector2Int(-5, -205);
    }
}
