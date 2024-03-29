using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    private bool ChemicalD;
    // Start is called before the first frame update
    void Start()
    {
        ChemicalD = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Corrosive()
    {
        //if (ChemicalA && ChemicalB && ChemicalC == null) 
        //{
        //    ChemicalD = true;
        //}
        ChemicalA = GameObject.Find("ChemicalA");
        if (ChemicalA == null)
        {
            Debug.Log("Corrosive Active");
        }
        else
        {
            Debug.Log("Not Corrosive");
        }
    }
}
