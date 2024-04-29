using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeAnimation : MonoBehaviour
{
    public GameObject AnimationTrigger;
    Animator AnimationSafe;
    // Start is called before the first frame update
    void Start()
    {
       AnimationSafe = this.transform.parent.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationTrigger == true)
        {
            AnimationSafe.SetTrigger("Open Safe");
        }   
    }
}
