using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SafeCombination : MonoBehaviour
{
    public TextMeshProUGUI InteractText;
    public TextMeshProUGUI SafeLockedText;
    public TextMeshProUGUI CollectCombinationText;
    public bool SafeRadius;
    public bool HasCombination;
    public bool CombinationRadius;
    public GameObject CombinationObject;
    public GameObject ChemicalInSafe;
    public GameObject AnimationTrigger;
    // Start is called before the first frame update
    void Start()
    {
        InteractText.enabled = false;
        SafeLockedText.enabled = false;
        CollectCombinationText.enabled = false;
        SafeRadius = false;
        CombinationRadius = false;
        HasCombination = false;
        CombinationObject.SetActive(true);
        ChemicalInSafe.SetActive(false);
        AnimationTrigger.SetActive(false); 

    }

    // Update is called once per frame
    void Update()
    {
        if (SafeRadius == true && HasCombination == false && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine("LockedTextIndicator");
        }

        

        if (CombinationRadius == true && Input.GetKeyDown(KeyCode.E))
        {
            CollectCombination();
        }

        if (SafeRadius == true && HasCombination == true && Input.GetKeyDown(KeyCode.E))
        {
            ChemicalInSafe.SetActive(true);
            AnimationTrigger.SetActive(true);
            InteractText.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Safe"))
        {
            InteractText.enabled = true;
            SafeRadius = true;
        }

        if (other.CompareTag("Combination"))
        {
            CollectCombinationText.enabled = true;
            CombinationRadius = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Safe"))
        {
            InteractText.enabled = false;
            SafeRadius = false;
        }

        if (other.CompareTag("Combination"))
        {
            CollectCombinationText.enabled = false;
            CombinationRadius = false;
        }
    }

    void CollectCombination()
    {
        CombinationObject.SetActive(false);
        HasCombination = true;
        CollectCombinationText.enabled = false;
    }

    IEnumerator LockedTextIndicator()
    {
        SafeLockedText.enabled = true;
        yield return new WaitForSeconds(2);
        SafeLockedText.enabled = false;
    }

    public void PlaySafeAnimation()
    {
        if (SafeRadius == true && HasCombination == true && Input.GetKeyDown(KeyCode.E))
        {
            ChemicalInSafe.SetActive(true);
        }
    }
}
