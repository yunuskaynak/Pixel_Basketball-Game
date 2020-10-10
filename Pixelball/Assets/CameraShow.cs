using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShow : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraTrigger.ctrigger)
        {
            anim.SetBool("ctriggered", true);
            Time.timeScale = 0.7f;
        }
        else if (!CameraTrigger.ctrigger)
        {
            anim.SetBool("ctriggered", false);
            Time.timeScale = 1f;
        }
    }
}
