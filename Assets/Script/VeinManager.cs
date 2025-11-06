using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeinManager : MonoBehaviour
{
    //鉱脈名は0から10までこの順番
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    bool[] VeinFlag = new bool[11]; //現在掘っている鉱脈

    /*[SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    public int[] Resource = new int[11]; //それぞれの資源の量*/
    [SerializeField] private TextManager TM;
    [SerializeField] private BackgroundChange BC;
    [SerializeField] private GameManager GM;
    int nowVein; //今掘ってる鉱脈を指定する変数
    int Vein = 11; //今の鉱脈資源の数
    void Start()
    {
        nowVein = 0;
        VeinFlag[nowVein] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ボタン用関数

    public void IronVein(){
        VeinReset();
        nowVein = 0;
        VeinSet(nowVein);
    }

    public void CopperVein(){
        VeinReset();
        nowVein = 1;
        VeinSet(nowVein);
    }

    public void TinVein(){
        VeinReset();
        nowVein = 2;
        VeinSet(nowVein);
    }

    public void CoalVein(){
        VeinReset();
        nowVein = 3;
        VeinSet(nowVein);
    }

    public void GoldVein(){
        VeinReset();
        nowVein = 4;
        VeinSet(nowVein);
    }

    public void SulferVein(){
        VeinReset();
        nowVein = 5;
        VeinSet(nowVein);
    }

    public void WaterVein(){
        VeinReset();
        nowVein = 6;
        VeinSet(nowVein);
    }

    public void ClayVein(){
        VeinReset();
        nowVein = 7;
        VeinSet(nowVein);
    }

    public void SandVein(){
        VeinReset();
        nowVein = 8;
        VeinSet(nowVein);
    }

    public void GypsumVein(){
        VeinReset();
        nowVein = 9;
        VeinSet(nowVein);
    }

    public void CalsiteVein(){
        VeinReset();
        nowVein = 10;
        VeinSet(nowVein);
    }

    public void VeinReset(){
        for(int i = 0;i < Vein;i++){
            VeinFlag[i] = false;
        }
    }

    public void VeinSet(int num){
        TM.VeinResourceChange(num);
        VeinFlag[num] = true;
        BC.VeinImageChange(num);
        GM.nowVeinChange(num);
        GM.VeinBool = true;
        GM.SmeltingFurnaceBool = false;
    }
}
