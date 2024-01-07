using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmissiveControl : MonoBehaviour
{
    [SerializeField] private Material emissiveMaterial;
    [SerializeField] private Renderer objectToChange;
    // Start is called before the first frame update
    void Start()
    {
        emissiveMaterial = objectToChange.GetComponent<Renderer>().material;
    }

    public void TurnEmissionOff()
    {
        emissiveMaterial.DisableKeyword("_EMISSION");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
