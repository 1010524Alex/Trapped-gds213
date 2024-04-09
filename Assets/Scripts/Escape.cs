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
    [SerializeField] TextMeshProUGUI EscapeText;
    public GameObject CorrosiveText;
    // Start is called before the first frame update
    void Start()
    {
        ChemicalD = false;
        WindowRadius = false;
        EscapeText.enabled = false;
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
            }
       }

       if (ChemicalA == null && ChemicalB == null && ChemicalC == null)
       {
            ChemicalD = true;
            Debug.Log("Chemical D Acquired");
       }

       if (ChemicalD == true)
       {
            Corrosive();
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
        yield return new WaitForSeconds(2);
        CorrosiveText.SetActive(false);
    }

    void Corrosive()
    {
        CorrosiveText.SetActive(true);
        StartCoroutine(TextDisappear());
    }
    
}
