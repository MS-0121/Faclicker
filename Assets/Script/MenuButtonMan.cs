using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonMan : MonoBehaviour
{
    Vector3 current;
    Vector3 target;
    bool MenuStates = false;
    // Start is called before the first frame update
    void Start()
    {
        current = transform.position;
        target = new Vector3(current.x, 50, current.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        if(!MenuStates) {
            transform.position = target;
            MenuStates = true;
            Debug.Log(MenuStates);
        }else{
            transform.position = current;
            MenuStates = false;
            Debug.Log(MenuStates);
        }
    }
}
