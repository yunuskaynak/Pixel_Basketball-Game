using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NetTrigger : MonoBehaviour
{
    public static int score,getscore;
    public Text scoretext;
    bool netriggerr;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            AudioManager.PlaySound("net");
            score++;
            netriggerr = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        netriggerr = false;

    }
    private void Update()
    {
        scoretext.text = "Score: " + score;
    }
}
