using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public static AudioScript AudioInstance;


    private void Awake()
    {
        if(AudioInstance != null && AudioInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        AudioInstance = this;
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update

}
