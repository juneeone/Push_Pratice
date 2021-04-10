using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;                                                          //오브젝트 지정 항목

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(-5f, 5f);  //-5부터 5까지 범위내에서 랜덤으로 지정

        //transform.Translate(0.01f, 0.0f, 0.0f);           //초당 이동 속도
        //transform.localScale = transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);      //초당 부피 증가

        if (Input.GetKeyDown(KeyCode.A)==true)
        {
            Instantiate(obj, new Vector3(randomX, 5, 0), Quaternion.identity); //특정 오브젝트 생성, randomX=X좌표 내에서 무작위로 생성
            }
    
        }
}
