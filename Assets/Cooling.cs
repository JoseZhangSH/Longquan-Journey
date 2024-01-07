using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooling : MonoBehaviour
{

    [SerializeField] private Material emissiveMaterial;
    [SerializeField] private Renderer objectToChange;

    // Start is called before the first frame update
    public ParticleSystem steam;

    private bool coolFlag = false;

    void Start()
    {

        // anvilStrikeFX.SetActive(false);
        emissiveMaterial = objectToChange.GetComponent<Renderer>().material;


    }

    public void TurnEmissionOff()
    {
        emissiveMaterial.DisableKeyword("_EMISSION");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (coolFlag == false)
        {
            StartCoroutine("Cool");
        }
        // if (collision.gameObject.CompareTag("Hammer"))
        // {
        //     // Trigger sparks VFX
        //     if (strikeFlag == false)
        //         {
        //             StartCoroutine("Strike");
        //         }
        // }
    }

    IEnumerator Cool()
    {
 
        coolFlag = true;

        steam.Play(true);
        yield return new WaitForSeconds(10f);
        TurnEmissionOff();
        steam.Stop(true);

        // coolFlag = false;

    }


}