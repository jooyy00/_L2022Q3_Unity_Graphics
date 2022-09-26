using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController_Start : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()//시작할 때 한번만 
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0.0f;
    }

    // Update is called once per frame
    void Update()//반복해서 실행을 원하는 것
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Anim.speed = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Anim.speed = 0;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Anim.speed = 2.0f;
        }
    }
}//이 스크립트가 작동하기 위해서는 game object 에 컴포넌트로 추가를 해줘야 함
