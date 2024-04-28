using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveFurniture : MonoBehaviour
{
    Animator cupboardAnim;
    public TextMeshProUGUI cupboardText;
    public bool cupboardRadius;
    public AudioSource cupboardAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        cupboardRadius = false;
        cupboardText.enabled = false;
        cupboardAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cupboardRadius == true && Input.GetKeyDown(KeyCode.E))
        {
            CupboardPush();
            cupboardText.enabled = false;
            cupboardAudioSource.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        cupboardText.enabled = true;
        cupboardRadius = true;
    }

    void OnTriggerExit(Collider other)
    {
        cupboardText.enabled = false;
        cupboardRadius = false;
    }

    void CupboardPush()
    {
        cupboardAnim.SetTrigger("Push Cupboard");    
    }
}
