using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    public GameObject Window;
    public bool ChemicalD;
    public bool WindowAccess;
    public bool WindowRadius;
    // Start is called before the first frame update
    void Start()
    {
        ChemicalD = false;
        WindowAccess = false;
        WindowRadius = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChemicalA && ChemicalB && ChemicalC == null)
        {
            ChemicalD = true;
            Debug.Log("Chemical D Acquired");
        }

        if (ChemicalD == true)
        {
            WindowAccess = true;
        }

        if (WindowAccess && WindowRadius == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(2);
            }
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
            Debug.Log("Exit Window");
        }
    }
}
