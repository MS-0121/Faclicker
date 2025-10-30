using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ResourceName; 
    [SerializeField] private GameManager GM;
    int nowVein = 0;
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    private TextMeshProUGUI[] VeinButtonText = new TextMeshProUGUI[11];
    // Start is called before the first frame update
    void Start()
    {
        ResourcenameChange();
        VeinNameChange();
    }

    // Update is called once per frame
    void Update()
    {
        ResourcenameChange();
        VeinNameChange();
    }

    public void ResourceChange(int a){
        //GameManagerで使う
        nowVein = a;
    }

    public void ResourcenameChange(){
        ResourceName.text = VeinName[nowVein]+"："+GM.Resource[nowVein];
    }

    public void VeinNameChange(){
        for(int i = 0;i < 11;i++){
            VeinButtonText[i].text = VeinName[i]+"：１/Click　生産量：１/s";
        }
    }
}
