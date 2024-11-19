using UnityEngine;

public class SharedData : MonoBehaviour
{
    public static SharedData Instance;

    public int sharedParameter;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSharedParameter(int parameter){
        sharedParameter = parameter;
    }

}