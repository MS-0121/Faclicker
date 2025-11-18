using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffectManager : MonoBehaviour
{
    [SerializeField] ParticleSystem ClickEffect;
    [SerializeField] Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){   
            Debug.Log("う");     
            var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
            ClickEffect.transform.position = pos;
            ClickEffect.Emit(1);
        }
    }

    public void ClickEffectFun(){
        // マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する

    }
}
