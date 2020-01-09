using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideBottomUI : MonoBehaviour
{
    // Start is called before the first frame update
    public int stageNumber;
    private float stageNumberBefore;
    private float timer;
    public float holder;
    public GameObject Background;

    public RectTransform sliderComponent;
    void Start()
    {
        stageNumberBefore = 1.0f;
        stageNumber = 1;
        timer = 0.0f;
    }
    public void valueChanger(int value)
    {
        stageNumber = value;
    }
    public void ChangePosition()
    {
        holder = stageNumberBefore;
        float temporaryHolder = stageNumber - stageNumberBefore;
        //float divisionBetweenFrame = (31.3f * temporaryHolder) / 120.0f;
        //Debug.Log(temporaryHolder);
        if (temporaryHolder != 0 )
        {
            while (Mathf.Round(timer) != 2)
            {
                
                timer = timer + Time.deltaTime;
                sliderComponent.anchoredPosition = new Vector2(-47.0f + 31.3f*(stageNumber - 1) , 0.0f);
                //Should have seamless transition, will work it again
            }
            timer = 0.0f;
            stageNumberBefore = stageNumber;
            string tagCompare = "back" + stageNumber.ToString();
            Debug.Log(tagCompare);
            foreach(Transform back in Background.transform)
            {
                if (back.gameObject.tag == tagCompare)
                {
                    back.gameObject.SetActive(true);
                }
                else
                {
                    back.gameObject.SetActive(false);
                }
                
                                    
            }
        }
        else
        {
            Debug.Log("Same Number!");
        }
    }

}
