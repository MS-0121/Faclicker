using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHide : MonoBehaviour
{
    [SerializeField] 
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    GameObject[] VeinButton = new GameObject[5];
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        Hide();
    }

    public void Hide(){
        for(int i = 0;i < VeinButton.Length;i++){
            if(VeinButton[i].activeSelf) {
                VeinButton[i].SetActive(false);
            }else{
                VeinButton[i].SetActive(true);
            }
        }
    }
}
