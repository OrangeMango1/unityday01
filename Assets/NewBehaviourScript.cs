using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    Button mBtnTest01, mBtnTest02;


    // Start is called before the first frame update
    void Start()
    {
        mBtnTest01.onClick.AddListener( () => { Debug.Log("Test2"); });
        mBtnTest02.onClick.AddListener( () => { Debug.Log("Test1"); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
