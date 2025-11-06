using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//コミット

public class GameManager : MonoBehaviour
{
    //鉱脈名は0から10までこの順番
    string[] VeinName = { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"};
    //製錬炉のレシピは0から3までこの順番
    string[] SmeltingFurnaceName = { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット" };

    //資源量の変数

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    public int[] VeinResource = new int[11]; //それぞれの資源の量

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット"})]
    public int[] SmeltingFurnaceResource = new int[4]; //それぞれの部品の量

    //クリックの有効変数
    int nowVein; //今掘ってる鉱脈を指定する変数
    int nowSmeltingFurnace; //今生産している機械の変数
    
    //その他
    int Vein = 11; //今の鉱脈資源の数
    int SmeltingFurnace = 4; //今の製錬炉レシピの数

    //今使用している施設
    public bool VeinBool = true;
    public bool SmeltingFurnaceBool = false;
    [SerializeField] private TextManager TM;
    [SerializeField] private BackgroundChange BC;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void click(){
        if(VeinBool){
            VeinResource[nowVein]++;
        }else if(SmeltingFurnaceBool){
            SmeltingFurnaceResource[nowSmeltingFurnace]++;
        }
    }

    public void nowVeinChange(int num){
        nowVein = num;
    }

    public void nowSmeltingFurnaceChange(int num){
        nowSmeltingFurnace = num;
    }
}
