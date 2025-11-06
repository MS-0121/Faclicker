using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour
{
    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石"})]
    Sprite[] VeinImage = new Sprite[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット" })]
    Sprite[] SmeltingFurnaceImage = new Sprite[4];
    private Image NowImage;
    // Start is called before the first frame update
    void Start()
    {
        NowImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VeinImageChange(int now){
        NowImage.sprite = VeinImage[now];
    }

    public void SmeltingFurnaceImageChange(int now){
        NowImage.sprite = SmeltingFurnaceImage[now];
    }
}
