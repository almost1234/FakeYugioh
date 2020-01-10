using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetGold : MonoBehaviour
{
    public RectTransform position;
    private int randomizer;
    private GameObject textGameObject, imageGameObject, image, text;
    Sprite goldImage, keyImage;
    Text contentText;
    Image contentImage;
    [SerializeField]
    private PlayerData data;

    private void Start()
    {
        position = GetComponent<RectTransform>();
        goldImage = Resources.Load<Sprite>("Sprites/gold");
        keyImage = Resources.Load<Sprite>("Sprites/key");
        // Load the pictures
        textGameObject = GameObject.FindGameObjectWithTag("TextContentText");
        contentText = textGameObject.GetComponent<Text>();
        imageGameObject = GameObject.FindGameObjectWithTag("TextContentImage");
        contentImage = imageGameObject.GetComponent<Image>();
        // Load the contentPage text and image GameObject
        // PlayerData function
        image = GameObject.FindGameObjectWithTag("Image");
        text = GameObject.FindGameObjectWithTag("Text");


    }
    public void ContentPanel()
    {
        randomizer = Random.Range(1, 3);
        Debug.Log("Status: " + randomizer.ToString());
        int number = Random.Range(100, 500);
        position.anchoredPosition = new Vector2Int(-5, -5);
        if (randomizer == 1)
        {
            image.SetActive(true);
            text.SetActive(false);
            contentText.text = "You get " + number.ToString() + " Keys!";
            contentImage.sprite = keyImage;
        }

        else
        {
            image.SetActive(true);
            text.SetActive(false);
            contentText.text = "You get " + number.ToString() + " Gold!";
            contentImage.sprite = goldImage;
        }
        data.OnPressCollectible(randomizer, number);
        
    }

    public void ClosePanel()
    {
        position.anchoredPosition = new Vector2Int(-5, -205);
    }
}
