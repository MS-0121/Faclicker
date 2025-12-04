using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System;

public class VeinVar{
    public string ItemName;
    public string ItemExp;
    public string ItemCategory;
    //public string ItemComment;

    public VeinVar(string t1, string t2, string t3){
        ItemName = t1;
        ItemCategory = t2;
        ItemExp = t3;
    }
}

public class VeinExpManager : MonoBehaviour    
//資源ノードの説明欄の生成のみ行う。名前は後で変える
{
    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石" })]
    string[] VeinName = new string[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石" })]
    string[] VeinExp = new string[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石" })]
    string[] VeinComment = new string[11];

    [SerializeField]
    [NamedArrayAttribute(new string[] { "鉄", "銅", "錫", "石炭", "金", "硫黄", "水", "粘土", "砂", "石膏", "方解石" })]
    string[] VeinCategory = new string[11];

    // Start is called before the first frame update
    void Start()
    {
        string DataPath = "Assets/csv/Faclicker_VeinList.csv"; //csvファイルのパス
        FileStream DataFile = new FileStream(DataPath, FileMode.Open, FileAccess.Read); //ファイルを開く
        StreamReader DataReader = new StreamReader(DataFile);
        DataReader.ReadLine(); //一行目は項目名なので読み捨てる
        int ix = 0;
        //Peekメソッドは読み取る文字が無い場合に「-1」を返す。「-1」ではない場合は繰り返す。
        while(DataReader.Peek() != -1){
            string LineData = DataReader.ReadLine();
            string[] LineSplit = LineData.Split(',');

            VeinName[ix] = LineSplit[0];
            VeinCategory[ix] = LineSplit[1];
            VeinExp[ix] = LineSplit[2];
            VeinComment[ix] = LineSplit[3];
            ix++;	
        }
        DataReader.Close();
        //テスト
        /*
        for(int i = 0;i < VeinName.Length;i++){ 
            Debug.Log(VeinName[i]);
            Debug.Log(VeinCategory[i]);
            Debug.Log(VeinExp[i]);
            Debug.Log(VeinComment[i]);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public VeinVar Exp(int num){
        //VeinVar test3 = new VeinVar(VeinName[1], VeinExpp[1]);
        return new VeinVar(VeinName[num], VeinCategory[num], VeinExp[num]);
        //return VeinName[num];VeinExp[num];VeinComment[num];
    }
}
