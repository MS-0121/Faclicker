using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemExpGenerator : MonoBehaviour
{
    //[SerializeField] VeinExpManager VEM;
    [SerializeField]
    [NamedArrayAttribute(new string[] { "アイテム名", "カテゴリー", "説明" })]
    TextMeshProUGUI[] Exp = new TextMeshProUGUI[3];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetExp(VeinVar ExpData){
        Exp[0].text = ExpData.ItemName;
        Exp[1].text = ExpData.ItemCategory;
        Exp[2].text = ExpData.ItemExp;
    }

    public void Del(){
        Destroy(this.gameObject);
    }
}
