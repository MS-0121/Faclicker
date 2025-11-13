using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlloySmelterManager : MonoBehaviour
{
    string[] RecipeName = { "ブロンズインゴット"};
    int nowRecipe; //今掘ってる鉱脈を指定する変数
    int RecipeNumber = 1; //今の鉱脈資源の数

    [SerializeField]
    [NamedArrayAttribute(new string[] {"ブロンズインゴット"})]
    bool[] RecipeFlag = new bool[1]
    ;
    [SerializeField] private TextManager TM;
    [SerializeField] private BackgroundChange BC;
    [SerializeField] private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void RecipeButton(int now){
        Reset();
        nowRecipe = now;
        Set(nowRecipe);
    }

    public virtual void Reset(){
        for(int i = 0;i < RecipeNumber;i++){
            RecipeFlag[i] = false;
        }
    }

    public virtual void Set(int now){
        //SmeltingFurnaceFlag[num] = true;
        RecipeFlag[now] = true;

        //例：TM.SmeltingFurnaceResourceChange(num);
        TM.AlloySmelterResourceChange(now);

        //BC.SmeltingFurnaceImageChange(num);
        BC.AlloySmelterImageChange(now);

        //GM.nowSmeltingFurnaceChange(num);
        GM.nowAlloySmelterChange(now);

        //GM.VeinBool = false;
        GM.AlloySmelterBool = false;

        //GM.SmeltingFurnaceBool = true;
        GM.AlloySmelterBool = true;
    }
}
