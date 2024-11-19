using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using Oculus.Interaction;

public class SharedDataManagement : MonoBehaviour
{
    public GameObject Dialog_Mawen;
    public GameObject Dialog_Mawu;
    public GameObject VoiceOver_Mawen;
    public GameObject VoiceOver_Mawu;
    private AudioTrigger audioTrigger;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Role: "+ SharedData.Instance.sharedParameter);
        if (SharedData.Instance.sharedParameter==1){
            Dialog_Mawen.SetActive(true);
            audioTrigger = VoiceOver_Mawen.GetComponent<AudioTrigger>();
            //VoiceOver_Mawen.GetComponent("AudioTrigger").PlayAudio();
        }else{
            Dialog_Mawu.SetActive(true);
            audioTrigger = VoiceOver_Mawu.GetComponent<AudioTrigger>();
            //VoiceOver_Mawu.GetComponent("AudioTrigger").PlayAudio();
        }
        audioTrigger.PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
