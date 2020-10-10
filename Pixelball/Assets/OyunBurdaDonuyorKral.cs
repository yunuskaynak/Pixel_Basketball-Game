using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunBurdaDonuyorKral : MonoBehaviour
{
    public GameObject altengel,ball;
    private void Update()
    {
        if (CameraTrigger.ctrigger)
        {
            altengel.SetActive(false);
            StartCoroutine(EngelAc());
        }
    }
    IEnumerator EngelAc()
    {
        yield return new WaitForSeconds(5);
        altengel.SetActive(true);
    }

    public void ResetMyBall()
    {
        Vector3 newPos = new Vector3(-1f, -3.6f, 0f);
        ball.transform.position = newPos;
    }
}
