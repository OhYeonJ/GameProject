using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    /*
    public bool inputAttack = false; //어택 버튼 누르지 않은 상태
    public bool inputJump = false; //점프 버튼 누르지 않은 상태
    */

    //public Text gameOverText; //게임 오버 텍스트.
    //private bool isGameOver = false; //게임 오버 여부.

    GameObject player;

    // Use this for initialization
    void Start()
    {

        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-3.0f * Time.deltaTime, 0.0f, 0.0f));
        if (transform.position.x < -0.3f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position; //노트 중심 좌표.
        Vector2 p2 = this.player.transform.position; //플레이어 중심 좌표.
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //노트 반경.
        float r2 = 1.0f; //플레이어 반경.

        if (d < r1 + r2)
        {
            //감독 스크립트에  플레이어와 노트가 충돌했다고 표시.
            GameObject director = GameObject.Find("UIDirector");
            director.GetComponent<GaugeDirector>().DescreaseHp();
            print("충돌!");

            //충돌하면 노트 소멸.
            Destroy(gameObject);
        }
        
    }
}

