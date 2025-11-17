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
    int nowAlloySmelter = 0;
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};
    string[] SmeltingFurnaceName = { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット"};
    string[] AlloySmelterName = { "ブロンズインゴット"};

    [SerializeField]
    [NamedArrayAttribute(new string[] { "アイテムの詳細", "クリックでの生産量", "自動生産量"})]
    private TextMeshProUGUI[] MachineMenuText = new TextMeshProUGUI[3];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    private TextMeshProUGUI[] VeinButtonText = new TextMeshProUGUI[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット"})]
    private TextMeshProUGUI[] SmeltingFurnaceText = new TextMeshProUGUI[4];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "ブロンズインゴット"})]
    private TextMeshProUGUI[] AlloySmelterText = new TextMeshProUGUI[1];



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
        SmeltingFurnaceNameChange();
        AlloySmelterNameChange();
    }

    public void VeinResourceChange(int a){
        //GameManagerで使う
        nowVein = a;
    }

    public void SmeltingFurnaceResourceChange(int a){
        nowSmeltingFurnace = a;
    }

    public void AlloySmelterResourceChange(int a){
        nowAlloySmelter = a;
    }

    public void ResourcenameChange(){
        if(GM.VeinBool){
            ResourceName.text = VeinName[nowVein]+"："+GM.VeinResource[nowVein];
        }else if(GM.SmeltingFurnaceBool){
            ResourceName.text = SmeltingFurnaceName[nowSmeltingFurnace]+"："+GM.SmeltingFurnaceResource[nowSmeltingFurnace];
        }else if(GM.AlloySmelterBool){
            ResourceName.text = AlloySmelterName[nowAlloySmelter]+"："+GM.AlloySmelterResource[nowAlloySmelter];
        }
    }

    public void MachineMenuChange(string Material1, string Materia2, int Req1, int Req2){
        MachineMenuText[0].text = "必要素材\n"+Material1+"　"+Req1+"/"+ResourceName.text+"\n";
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

    public void AlloySmelterNameChange(){
        for(int i = 0;i < AlloySmelterName.Length;i++){
            AlloySmelterText[i].text = AlloySmelterName[i]+"：１/Click　生産量：１/s";
        }
    }
}
