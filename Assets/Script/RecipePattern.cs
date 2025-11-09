using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipePattern : MonoBehaviour
{
    string[] RecipeName;
    int nowRecipe; //今掘ってる鉱脈を指定する変数
    int RecipeNumber; //今の鉱脈資源の数

    [SerializeField]
    [NamedArrayAttribute(new string[] {"上のrecipeNameの中身を貼り付ける"})]
    bool[] RecipeFlag;
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

        //TM.SmeltingFurnaceResourceChange(num);
        //TM.RecipeResourceChange(now);

        //BC.SmeltingFurnaceImageChange(num);
        //BC.RecipeImageChange(now);

        //GM.nowSmeltingFurnaceChange(num);
        //GM.nowRecipeChange(now);

        //GM.VeinBool = false;
        //GM.RecipeBool = false;

        //GM.SmeltingFurnaceBool = true;
        //GM.RecipeBool = true;
    }
}
