using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject anvilStrikeFX;
    public GameObject swordLake;
    public GameObject sunSwordLake;
    public GameObject sunBlackSmith;

    private bool strikeFlag = false;

    void Start()
    {
        anvilStrikeFX.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        //检测到锤子和剑身的碰撞时，触发火光和音效
        if (strikeFlag == false)
        {
            StartCoroutine("Strike");
        }
        if (swordLake.activeSelf== false){
            swordLake.SetActive(true);
        }
        if (sunSwordLake.activeSelf == false){
            sunSwordLake.SetActive(true);
        }
        if (sunBlackSmith.activeSelf == true){
            sunBlackSmith.SetActive(false);
        }
    }

    //锤炼剑身的火光和音效
    IEnumerator Strike()
    {
        strikeFlag = true;
        anvilStrikeFX.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        anvilStrikeFX.SetActive(false);
        strikeFlag = false;
    }


}