using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

    public Slider healthBarSlider; //슬라이더 레퍼런스
    public Text gameOverText;      //텍스트 레퍼런스
    private bool isGameOver = false; // 게임이 끝났음을 알림.

	// Use this for initialization
	void Start () {
        gameOverText.enabled = false; //게임오버 텍스트가 시작했을 때 보이지 않게 함.
	}

    void Update()
    {
        //확인용
        if (!isGameOver)
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10f, 0, 0); //get input
    }


    void OnTriggerStay(Collider other)
    {
        //적과 충돌했을 때 게이지가 떨어지게끔 한다.
        if(other.gameObject.tag == "Enemy" && healthBarSlider.value>0)
        {
            healthBarSlider.value -= 3.0f; //체력바 감소
        }

        else
        {
            isGameOver = true; //체력 게이지가 다 떨어져 게임 오버가 되었을 때.
            gameOverText.enabled = true; //게임오버 텍스트를 보이게 한다.
        }
    }
}
