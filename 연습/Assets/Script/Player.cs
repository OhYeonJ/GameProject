using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//플레이어 컨트롤 스크립트. 물리 필요없음.

public class Player : MonoBehaviour
{


    //---선언---

    //public Text gameOverText;//게임 오버 텍스트.

    //Inspector에서 조정하기 위한 속성
    public float speed = 10.0f; // 플레이어의 속도. 필요 없으면 지우기.
    public Sprite[] run; //플레이어의 달리기 스프라이트. 제작 완료.
    //public Sprite[] jumpShort; //플레이어의 단일 노트 점프 스프라이트. 제작 해야함.
    //public Sprite[] jumpLong; //플레이어의 롱 노트 점프 스프라이트. 제작 해야함.
    //public Sprite[] attackShort; //플레이어의 단일 노트 공격 스프라이트. 제작 해야함.
    //public Sprite[] attackLong; //플레이어의 롱 노트 공격 스프라이트. 제작 해야함.

    

    //내부에서 다룰 변수
    //int animIndex; // 플레이어 캐릭터 애니메이션 재생 인덱스.
    //bool goalCheck; //골인 했는지 체크.


    // Use this for initialization
    //컴포넌트 시작
    void Start()
    {
        Awake();
        //초기화
        //animIndex = 0;
        //goalCheck = false; //골에 들어가지 않은 상태.
        //gameOverText.enabled = false; //게임오버 텍스트가 보이지 않게.

    }

    void Awake()
    {
        Screen.SetResolution(960, 540, true);
    }

    public void AttackDown() //어택 버튼 눌렀을 때.
    {
        //GetComponent<SpriteRenderer>().sprite = run[0]; //공격 스프라이트 이미지로 전환. 공격 스프라이트 완성 후에 수정.
        Debug.Log("공격!");
    }

    public void JumpDown() //점프 버튼 눌렀을 때.
    {
        //GetComponent<SpriteRenderer>().sprite = run[0]; //점프 스프라이트 이미지로 전환. 점프 스프라이트 완성 후에 수정.
        Debug.Log("점프!");
    }

    // Update is called once per frame
    void Update()
    {


        /*if (Input.GetMouseButtonUp(0))
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
    */
    }

    /*void IsGameOver() //게임 오버 판정 메서드.
    {
        if(GetComponent<Image>().fillAmount == 0.0f)
        {
            gameOverText.enabled = true;
        }
    }
    */

    /*
    void OnGUI()
    {
        //디버그 텍스트. 튜토리얼 용.
        GUI.TextField(new Rect(10, 10, 300, 60), "왼쪽 버튼을 누르면 공격\n오른쪽 버튼을 누르면 점프");
    }
    */
}

