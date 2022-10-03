using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameController m_gc;
    public AudioSource aus;
    public AudioClip catchBall;
    public AudioClip die;
    private void Start()
    {
        m_gc =FindObjectOfType<GameController>();//tim GameController
        aus= FindObjectOfType<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Line"))
        {
            m_gc.IncrementScore();
            if (aus)
            {
                aus.PlayOneShot(catchBall);
            }
            Destroy(gameObject);
        }    
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Deathzone"))
        {
            m_gc.SetGameover(true);
            if (aus)
            {
                aus.PlayOneShot(die);
            }
            Destroy(gameObject);
        }
    }
}
//them linh tinh 1 cai gi do
