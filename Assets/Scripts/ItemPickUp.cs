using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public bool RadiusA;
    public bool RadiusB;
    public bool RadiusC;
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    // Start is called before the first frame update
    void Start()
    {
        RadiusA = false;
        RadiusB = false;
        RadiusC = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (RadiusA == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChemicalA.SetActive(false);
                Debug.Log("Chemical A Collected");
            }
        }

        if (RadiusB == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChemicalB.SetActive(false);
                Debug.Log("Chemical B Collected");
            }
        }

        if (RadiusC == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ChemicalC.SetActive(false);
                Debug.Log("Chemical B Collected");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chemical A"))
        {
            RadiusA = true;
            Debug.Log("Enter RadiusA");
        }

        if (other.CompareTag("Chemical B"))
        {
            RadiusB = true;
            Debug.Log("Enter RadiusB");
        }

        if (other.CompareTag("Chemical C"))
        {
            RadiusC = true;
            Debug.Log("Enter RadiusC");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chemical A"))
        {
            RadiusA = false;
            Debug.Log("Exit RadiusA");
        }

        if (other.CompareTag("Chemical B"))
        {
            RadiusB = false;
            Debug.Log("Exit RadiusB");
        }

        if (other.CompareTag("Chemical C"))
        {
            RadiusC = false;
            Debug.Log("Exit RadiusC");
        }
    }











}
