using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CameraTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject board;
    public static bool ctrigger;
    int valuecheck = 0;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ctrigger = true;
        AudioManager.PlaySound("board");
        anim.SetBool("btriggered", true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ctrigger = false;
        anim.SetBool("btriggered", false);
    }
    private void Update()
    {

        if (NetTrigger.score != valuecheck)
        {
            StartCoroutine(ChangeBoardPosition());
        }
        valuecheck = NetTrigger.score;
    }
    IEnumerator ChangeBoardPosition()
    {
        float randompos = Random.Range(-1f, 4f);
        yield return new WaitForSeconds(3);
        Vector3 newPos = new Vector3(1.2f,randompos,0f);
        board.transform.position = newPos;
    }
}
