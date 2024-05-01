using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadNote : MonoBehaviour
{
    public GameObject noteObject;
    public bool isNoteRadius;
    public TextMeshProUGUI NoteText;
    public bool isNoteActive;
    // Start is called before the first frame update
    void Start()
    {
        noteObject.SetActive(false);
        isNoteRadius = false;
        NoteText.enabled = false;
        isNoteActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isNoteRadius == true && Input.GetKey(KeyCode.E))
        {
            isNoteActive = true;
            Debug.Log("the note is now active");
            noteObject.SetActive(true);
        }
        else if (isNoteRadius == false)
        {
            Debug.Log("we walked away this should disappear if we walk away");
            noteObject.SetActive(false);
        }

        //if (NoteRadius == true && Input.GetKeyDown(KeyCode.E))
        //{
        //    NoteOnScreen();
        //}





    }


        private void OnTriggerEnter(Collider other)
        {
            isNoteRadius = true;
            NoteText.enabled = true;
        }

        private void OnTriggerExit(Collider other)
        {
            isNoteRadius = false;
            NoteText.enabled = false;
        }

        void NoteOnScreen()
        {
            noteObject.SetActive(true);
            NoteText.enabled = false;
            isNoteActive = true;
        }


    }
