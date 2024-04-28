using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemPickUp : MonoBehaviour
{
    public bool RadiusA;
    public bool RadiusB;
    public bool RadiusC;
    public GameObject ChemicalA;
    public GameObject ChemicalB;
    public GameObject ChemicalC;
    [SerializeField] TextMeshProUGUI RadiusAText;
    [SerializeField] TextMeshProUGUI RadiusBText;
    [SerializeField] TextMeshProUGUI RadiusCText;
    public AudioSource itemPickUpSound;



    // Start is called before the first frame update
    void Start()
    {
        RadiusA = false;
        RadiusB = false;
        RadiusC = false;
        RadiusAText.enabled = false;
        RadiusBText.enabled = false;
        RadiusCText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    { 
        if (RadiusA == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //ChemicalA.SetActive(false);
                Destroy(GameObject.FindWithTag("Chemical A"));
                Debug.Log("Chemical A Collected");
                itemPickUpSound.Play();
            }
        }

        if (RadiusB == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //ChemicalB.SetActive(false);
                Destroy(GameObject.FindWithTag("Chemical B"));
                Debug.Log("Chemical B Collected");
                itemPickUpSound.Play();
            }
        }

        if (RadiusC == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //ChemicalC.SetActive(false);
                Destroy(GameObject.FindWithTag("Chemical C"));
                Debug.Log("Chemical C Collected");
                itemPickUpSound.Play();
            }
        }

        if (ChemicalA == null)
        {
            RadiusAText.enabled = false;
        }

        if (ChemicalB == null)
        {
            RadiusBText.enabled = false;
        }

        if (ChemicalC == null)
        {
            RadiusCText.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chemical A"))
        {
            RadiusA = true;
            RadiusAText.enabled = true;
            Debug.Log("Enter RadiusA");
        }

        if (other.CompareTag("Chemical B"))
        {
            RadiusB = true;
            RadiusBText.enabled = true;
            Debug.Log("Enter RadiusB");
        }

        if (other.CompareTag("Chemical C"))
        {
            RadiusC = true;
            RadiusCText.enabled = true;
            Debug.Log("Enter RadiusC");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Chemical A"))
        {
            RadiusA = false;
            RadiusAText.enabled = false;
            Debug.Log("Exit RadiusA");
        }

        if (other.CompareTag("Chemical B"))
        {
            RadiusB = false;
            RadiusBText.enabled = false;
            Debug.Log("Exit RadiusB");
        }

        if (other.CompareTag("Chemical C"))
        {
            RadiusC = false;
            RadiusCText.enabled = false;
            Debug.Log("Exit RadiusC");
        }
    }











}
