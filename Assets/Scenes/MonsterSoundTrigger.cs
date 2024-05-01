using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSoundTrigger : MonoBehaviour
{
    public AudioSource monsterAudio;
    public AudioSource doorBangAudio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartAudio");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartAudio()
    {
        yield return new WaitForSeconds(2);
        monsterAudio.Play();
    }
}
