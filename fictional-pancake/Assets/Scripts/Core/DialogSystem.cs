using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogSystem : MonoBehaviour
{
    public DialogContainer dialogContainer = new DialogContainer(); 

    public static DialogSystem instance;

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
            DestroyImmediate(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
