using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMouseOver : MonoBehaviour
{
    [SerializeField] GameObject Template;
    [SerializeField] Transform parents;
    [SerializeField] VeinExpManager VEM;
    [SerializeField] ItemExpGenerator IEG;
    private bool ButtonClick = false;
    string[] test4 = new string[2];
    GameObject Exp;
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

    public void ItemExpEvent(int num){
        Debug.Log(num);
        IEG.GetExp(VEM.Exp(num));
        float Template_y = this.transform.position.y + 37.5f;
        Exp = Instantiate(Template, parents);
        Exp.transform.position = new Vector3(this.transform.position.x, Template_y, this.transform.position.z);
    }
}
