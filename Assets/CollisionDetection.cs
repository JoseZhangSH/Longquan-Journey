using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

        // “other” refers to the collider on the GameObject inside this trigger
    // void OnTriggerEnter (Collider other)
    // {
    //     Debug.Log ("A collider has entered the DoorObject trigger");
    // }

    // void OnTriggerStay (Collider other)
    // {
    //     Debug.Log ("A collider is inside the DoorObject trigger");
    // }
    
    // void OnTriggerExit (Collider other)
    // {
    //     Debug.Log ("A collider has exited the DoorObject trigger");
    // }

    // Start is called before the first frame update
    public GameObject anvilStrikeFX;

    private bool strikeFlag = false;

    void Start()
    {

        anvilStrikeFX.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (strikeFlag == false)
        {
            StartCoroutine("Strike");
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

    IEnumerator Strike()
    {
 
        strikeFlag = true;

        anvilStrikeFX.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        anvilStrikeFX.SetActive(false);

        strikeFlag = false;

    }


}