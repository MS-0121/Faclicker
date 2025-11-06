using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//コミット

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ResourceName; 
    [SerializeField] private GameManager GM;
    int nowVein = 0;
    int nowSmeltingFurnace = 0;
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};
    string[] SmeltingFurnaceName = { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット"};

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    private TextMeshProUGUI[] VeinButtonText = new TextMeshProUGUI[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット"})]
    private TextMeshProUGUI[] SmeltingFurnaceText = new TextMeshProUGUI[4];
    // Start is called before the first frame update
    void Start()
    {
        ResourcenameChange();
        VeinNameChange();
        SmeltingFurnaceNameChange();
    }

    // Update is called once per frame
    void Update()
    {
        ResourcenameChange();
        VeinNameChange();
    }

    public void VeinResourceChange(int a){
        //GameManagerで使う
        nowVein = a;
    }

    public void SmeltingFurnaceResourceChange(int a){
        nowSmeltingFurnace = a;
    }

    public void ResourcenameChange(){
        if(GM.VeinBool){
            ResourceName.text = VeinName[nowVein]+"："+GM.VeinResource[nowVein];
        }else if(GM.SmeltingFurnaceBool){
            ResourceName.text = SmeltingFurnaceName[nowSmeltingFurnace]+"："+GM.SmeltingFurnaceResource[nowSmeltingFurnace];
        }

    }

    public void VeinNameChange(){
        for(int i = 0;i < 11;i++){
            VeinButtonText[i].text = VeinName[i]+"：１/Click　生産量：１/s";
        }
    }

    public void SmeltingFurnaceNameChange(){
        for(int i = 0;i < 4;i++){
            SmeltingFurnaceText[i].text = SmeltingFurnaceName[i]+"：１/Click　生産量：１/s";
        }
    }
}
