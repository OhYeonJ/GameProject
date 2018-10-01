using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 컨트롤 스크립트. 물리 필요없음.

public class Player : MonoBehaviour {


    //---선언---

    //Inspector에서 조정하기 위한 속성
    public float speed = 10.0f; // 플레이어의 속도. 필요 없으면 지우기.
    public Sprite[] run; //플레이어의 달리기 스프라이트. 제작 완료.
    public Sprite[] jumpShort; //플레이어의 단일 노트 점프 스프라이트. 제작 해야함.
    public Sprite[] jumpLong; //플레이어의 롱 노트 점프 스프라이트. 제작 해야함.
    public Sprite[] attackShort; //플레이어의 단일 노트 공격 스프라이트. 제작 해야함.
    public Sprite[] attackLong; //플레이어의 롱 노트 공격 스프라이트. 제작 해야함.

    //내부에서 다룰 변수
    int animIndex; // 플레이어 캐릭터 애니메이션 재생 인덱스.
    //bool goalCheck; //골인 했는지 체크.


    // Use this for initialization
    //컴포넌트 시작
    void Start()
    {
        //초기화
        animIndex = 0;
        //goalCheck = false; //골에 들어가지 않은 상태.

    }


	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) //단일 노트.마우스 왼쪽 버튼을 눌렀을 때. 노트의 위치는 지면. 후에 아래 방향 버튼을 따로 만들어서 GetButtonDown으로 바꾸기.
        {
            //GetComponent<SpriteRenderer>().sprite = attackShort[0]; //공격 스프라이트 이미지로 전환. 공격 스프라이트 완성 후에 수정.
            Debug.Log("공격!");
        }
        else if (Input.GetMouseButtonDown(1)) //단일 노트.마우스 오른쪽 버튼을 눌렀을 때. 노트의 위치는 머리. 후에 위 방향 버튼을 만들어서 GetButtonDown으로 바꾸기. 
        {
            //GetComponent<SpriteRenderer>().sprite = jumpShort[0]; //점프 스프라이트 이미지로 전환. 점프 스프라이트 완성 후에 수정.
            Debug.Log("점프!");
        }

        
        else if (Input.GetMouseButton(0)) //롱 노트. 마우스 왼쪽.
        {
            //GetComponent<SpriteRenderer>().sprite = attackLong[0]; //공격 스프라이트 이미지로 전환. 공격 스프라이트 완성 후에 수정.
            Debug.Log("길게 공격!");
        }
        else if (Input.GetMouseButton(1)) //롱 노트. 마우스 오른쪽.
        {
            //GetComponent<SpriteRenderer>().sprite = jumpLong[0]; //점프 스프라이트 이미지로 전환. 점프 스프라이트 완성 후에 수정.
            Debug.Log("길게 점프!");
        }
      

        else
        {
            
            if (Input.GetMouseButtonUp(0))
            {
                animIndex++;
                if(animIndex >= run.Length)
                {
                    animIndex = 0;
                }
            }

            if (Input.GetMouseButtonUp(1))
            {
                animIndex++;
                if (animIndex >= run.Length)
                {
                    animIndex = 0;
                }
            }

            GetComponent<SpriteRenderer>().sprite = run[animIndex]; //달리기 스프라이트 이미지로 전환.
        }

        
    }

    void OnGUI()
    {
        //디버그 텍스트. 튜토리얼 용.
        GUI.TextField(new Rect(10,10,300,60),"마우스 왼쪽 버튼을 누르면 공격\n오른쪽 버튼을 누르면 점프");
    }
}
