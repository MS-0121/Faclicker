using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundChange : MonoBehaviour
{
    [SerializeField] GameObject FrontImageObject;
    
    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石", "手前の柱"})]
    Sprite[] VeinImage = new Sprite[12];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄インゴット", "銅インゴット", "錫インゴット", "金インゴット", "製錬炉の手前の画像(未作成)" })]
    Sprite[] SmeltingFurnaceImage = new Sprite[5];
    private Image NowImage;
    private Image FrontImage;
    //private Color pillar;
    // Start is called before the first frame update
    void Start()
    {
        NowImage = GetComponent<Image>();
        FrontImage = FrontImageObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VeinImageChange(int now){
        FrontImage.sprite = VeinImage[VeinImage.Length-1];
        NowImage.sprite = VeinImage[now];
    }

    public void SmeltingFurnaceImageChange(int now){
        FrontImage.sprite = SmeltingFurnaceImage[4];
        NowImage.sprite = SmeltingFurnaceImage[now];
    }
}
