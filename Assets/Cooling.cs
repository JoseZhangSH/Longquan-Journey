using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooling : MonoBehaviour
{
    [SerializeField] private Material emissiveMaterial;
    [SerializeField] private Renderer objectToChange;

    public ParticleSystem steam;
    public GameObject StarWell;
    public GameObject sunSwordLake;
    public GameObject sunStarWell;

    private bool coolFlag = false;

    void Start()
    {
        //获取剑身的发光材质
        emissiveMaterial = objectToChange.GetComponent<Renderer>().material;
    }

    public void TurnEmissionOff()
    {
        emissiveMaterial.DisableKeyword("_EMISSION");
    }

    void OnTriggerEnter(Collider other)
    {
        //检测到剑身和水面的碰撞，开始淬火效果
        if (coolFlag == false)
        {
            StartCoroutine("Cool");
        }
        if (StarWell.activeSelf== false){
            StarWell.SetActive(true);
        }
        if (sunStarWell.activeSelf == false){
            sunStarWell.SetActive(true);
        }
        if (sunSwordLake.activeSelf == true){
            sunSwordLake.SetActive(false);
        }
    }

    IEnumerator Cool()
    {
        coolFlag = true;
        //播放水蒸气
        steam.Play(true);
        yield return new WaitForSeconds(10f);
        //关闭剑身的发光材质
        TurnEmissionOff();
        steam.Stop(true);
    }


}