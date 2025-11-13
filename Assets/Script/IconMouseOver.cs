using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMouseOver : MonoBehaviour
{
    [SerializeField] GameObject test;
    [SerializeField] Transform parents;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitEventTest(){
        Debug.Log("離れた");
    }

    public void EnterEventTest(){
        Debug.Log("重なった");
    }

    public void eventtest(){
        GameObject Exp = Instantiate(test, parents);
        Exp.transform.position = this.transform.position;
    }
}
