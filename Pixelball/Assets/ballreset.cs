using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballreset : MonoBehaviour
{
    public GameObject ball;
    int valuecheck = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NetTrigger.score != valuecheck)
        {
            StartCoroutine(BallReset());
        }
        valuecheck = NetTrigger.score;
    }

    IEnumerator BallReset()
    {
        yield return new WaitForSeconds(2);
        Vector3 newPos = new Vector3(-1f, -3.6f, 0f);
        ball.transform.position = newPos;
    }
}
