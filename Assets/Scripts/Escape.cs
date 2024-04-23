using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Escape : MonoBehaviour
{
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    public bool ChemicalD;
    public bool WindowRadius;
    bool hasSetSafe = false;

    [SerializeField] TextMeshProUGUI EscapeText;
    [SerializeField] TextMeshProUGUI Introtext;
    public GameObject CorrosiveText;
    // Start is called before the first frame update
    void Start()
    {
        ChemicalD = false;
        WindowRadius = false;
        EscapeText.enabled = false;
        Introtext.enabled = true;
        CorrosiveText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (WindowRadius && ChemicalD == true)
       {
            EscapeText.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(2);
                Cursor.lockState = CursorLockMode.None;
            }
       }

       if (ChemicalA == null && ChemicalB == null && ChemicalC == null)
       {
            Corrosive();
            Debug.Log("Chemical D Acquired");
       }

       if (Introtext.enabled == true)
       {
            StartCoroutine(DeleteIntroText());
       }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Window"))
        {
            WindowRadius = true;
            Debug.Log("Enter Window");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Window"))
        {
            WindowRadius = false;
            EscapeText.enabled = false;
            Debug.Log("Exit Window");
        }
    }

    IEnumerator TextDisappear()
    {
        CorrosiveText.SetActive(true);
        yield return new WaitForSeconds(3);
        CorrosiveText.SetActive(false);
        Debug.Log("Text Disappears now");
        yield break;
    }

    IEnumerator DeleteIntroText()
    {
        yield return new WaitForSeconds(4);
        Introtext.enabled = false;
        yield break;
    }

    void Corrosive()
    {
        ChemicalD = true;
        if (!hasSetSafe)
        {
            hasSetSafe = true;
            StartCoroutine(TextDisappear());
            Debug.Log("How many times does text run");
        }
        Debug.Log("lol why no work??");
    }
    
}
