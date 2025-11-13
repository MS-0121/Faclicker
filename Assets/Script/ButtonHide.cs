using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//コミット

public class ButtonHide : MonoBehaviour
{
    [SerializeField] 
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    GameObject[] VeinButton = new GameObject[11];

    [SerializeField] 
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット" })]
    GameObject[] SmeltingFurnaceButton = new GameObject[4];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "ブロンズインゴット"})]
    GameObject[] AlloySmelterButton = new GameObject[1]; 
    // Start is called before the first frame update
    void Start()
    {
        VeinHide();
        SmeltingFurnaceHide();
        AlloySmelterHide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){

    }

    public void VeinHide(){
        for(int i = 0;i < VeinButton.Length;i++){
            if(VeinButton[i].activeSelf) {
                VeinButton[i].SetActive(false);
            }else{
                VeinButton[i].SetActive(true);
            }
        }
    }

    public void SmeltingFurnaceHide(){
        for(int i = 0;i < SmeltingFurnaceButton.Length;i++){
            if(SmeltingFurnaceButton[i].activeSelf){
                SmeltingFurnaceButton[i].SetActive(false);
            }else{
                SmeltingFurnaceButton[i].SetActive(true);
            }
        }
    }

    public void AlloySmelterHide(){
        for(int i = 0;i < AlloySmelterButton.Length;i++){
            if(AlloySmelterButton[i].activeSelf) {
                AlloySmelterButton[i].SetActive(false);
            }else{
                AlloySmelterButton[i].SetActive(true);
            }
        }
    }
}
