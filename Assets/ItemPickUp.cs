using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public bool Radius;
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    // Start is called before the first frame update
    void Start()
    {
        Radius = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Radius == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChemicalA.SetActive(false);
                Debug.Log("Chemical Collected");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chemical"))
        {
            Radius = true;
            Debug.Log("Enter Radius");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chemical"))
        {
            Radius = false;
            Debug.Log("Exit Radius");

        }
    }









}
