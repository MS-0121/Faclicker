using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmeltingFurnaceManager : MonoBehaviour
{
    //製錬炉レシピの数は0から3までこの順番
    string[] SmeltingFurnaceName = { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット" };

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット" })]
    bool[] SmeltingFurnaceFlag = new bool[4]; //現在掘っている鉱脈
    [SerializeField] private TextManager TM;
    [SerializeField] private BackgroundChange BC;
    [SerializeField] private GameManager GM;
    int nowSmeltingFurnace; //今掘ってる鉱脈を指定する変数
    int SmeltingFurnace = 4; //今の鉱脈資源の数
    void Start()
    {
        nowSmeltingFurnace = 0;
        //SmeltingFurnaceFlag[nowSmeltingFurnace] = false;
    }

    public void SmeltingFurnaceButton(int now){
        //ボタン用関数
        Reset();
        nowSmeltingFurnace = now;
        Set(nowSmeltingFurnace);
    }

    public void Reset(){
        for(int i = 0;i < SmeltingFurnace;i++){
            SmeltingFurnaceFlag[i] = false;
        }
    }

    public void Set(int num){
        TM.SmeltingFurnaceResourceChange(num);
        SmeltingFurnaceFlag[num] = true;
        BC.SmeltingFurnaceImageChange(num);
        GM.nowSmeltingFurnaceChange(num);
        GM.VeinBool = false;
        GM.SmeltingFurnaceBool = true;
    }
    
    /*ボタン用関数
    public void IronIngot(){
        Reset();
        nowSmeltingFurnace = 0;
        Set(nowSmeltingFurnace);
    }

    public void CopperIngot(){
        Reset();
        nowSmeltingFurnace = 1;
        Set(nowSmeltingFurnace);
    }

    public void TinIngot(){
        Reset();
        nowSmeltingFurnace = 2;
        Set(nowSmeltingFurnace);
    }

    public void GoldIngot(){
        Reset();
        nowSmeltingFurnace = 3;
        Set(nowSmeltingFurnace);
    }
    */
}
