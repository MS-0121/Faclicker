using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//コミット

public class GameManager : MonoBehaviour
{
    //鉱脈名は0から10までこの順番
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    bool[] VeinFlag = new bool[11]; //現在掘っている鉱脈

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    public int[] Resource = new int[11]; //それぞれの資源の量
    int nowVein; //今掘ってる鉱脈を指定する変数
    int Vein = 11; //今の鉱脈資源の数

    [SerializeField] private TextManager TM;
    void Start()
    {
        nowVein = 0;
        VeinFlag[nowVein] = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Resource[nowVein]++;
        }
    }

    

    //ボタン用関数

    public void IronVein(){
        VeinReset();
        nowVein = 0;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void CopperVein(){
        VeinReset();
        nowVein = 1;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void TinVein(){
        VeinReset();
        nowVein = 2;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void CoalVein(){
        VeinReset();
        nowVein = 3;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void GoldVein(){
        VeinReset();
        nowVein = 4;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void SulferVein(){
        VeinReset();
        nowVein = 5;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void WaterVein(){
        VeinReset();
        nowVein = 6;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void ClayVein(){
        VeinReset();
        nowVein = 7;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void SandVein(){
        VeinReset();
        nowVein = 8;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void GypsumVein(){
        VeinReset();
        nowVein = 9;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void CalsiteVein(){
        VeinReset();
        nowVein = 10;
        TM.ResourceChange(nowVein);
        VeinFlag[nowVein] = true;
    }

    public void VeinReset(){
        for(int i = 0;i < Vein;i++){
            VeinFlag[i] = false;
        }
    }
}
