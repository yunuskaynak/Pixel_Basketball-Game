using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip bounce, board, net;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        bounce = Resources.Load<AudioClip>("bounce");
        board = Resources.Load<AudioClip>("board");
        net = Resources.Load<AudioClip>("net");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "bounce":
                audioSrc.PlayOneShot(bounce);
                break;
            case "net":
                audioSrc.PlayOneShot(net);
                break;
            case "board":
                audioSrc.PlayOneShot(board);
                break;
        }
    }
}
