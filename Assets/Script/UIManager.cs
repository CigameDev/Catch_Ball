using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    public Text scoreText;
    public GameObject gameoverPanel;
    public void SetScoreText(string txt)
    {
        if(scoreText)//tuong duong voi scoreText !=null
        {
            scoreText.text = txt;
        }    
    }
    
    public void ShowGameOverPanel(bool isShow)
    {
        gameoverPanel.SetActive(isShow);
    }    
}
