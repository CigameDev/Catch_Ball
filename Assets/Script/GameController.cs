using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;
    [SerializeField] int m_score=0;
    bool isGameover;

    UIManager m_ui;
    
    void Start()
    {
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score : "+m_score);
        m_spawnTime = 0;
    }

   
    void Update()
    {
        if(isGameover)
        {
            m_ui.ShowGameOverPanel(true);
        }    
        SpawnBall();
    }
    public void SetScore(int value)
    {
        m_score = value;
    }    
    public int GetScore()
    {
        return m_score;
    }    
    public void IncrementScore()
    {
        m_score++;
        
        m_ui.SetScoreText("Score: "+m_score);
    }    
    public void SetGameover(bool state)
    {
        isGameover = state;
    }   
    public bool GetGameover()
    {
        return isGameover;
    }    
    private void SpawnBall()
    {
        if (isGameover) return;//co the dua len lam update cung dc
        m_spawnTime-=Time.deltaTime;
        if (m_spawnTime > 0) return;
        m_spawnTime=spawnTime;
        Vector2 spawnPos = new Vector2(Random.Range(-8, 8), 6);
        Debug.Log(spawnPos.x);
        if(ball)
        {
            Instantiate(ball,spawnPos,Quaternion.identity);//khong cho xoay
        }    
    }    

    public void Replay()
    {
        m_score = 0;
        isGameover=false;
        m_ui.SetScoreText("Score : " + m_score);
        m_ui.ShowGameOverPanel(false);
        //ta da cho nhan nut o ngoai unity roi
        
    }    
}
