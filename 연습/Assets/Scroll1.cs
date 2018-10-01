using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll1 : MonoBehaviour {

    public const float scrollSpeed = 1.2f;
    //스크롤 속도 상수 지정

    private Material thisMaterial;
    //Quad의 Material 데이터를 받아올 객체 선언

    void Start()
    {
        thisMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        // 새롭게 지정해줄 OffSet 객체 선언
        newOffset.Set(0, newOffset.x + (scrollSpeed * Time.deltaTime));
        // X부분에 현재 x값의 속도에 프레임 보정을 해서 플러스.
        thisMaterial.mainTextureOffset = newOffset;
        //최종적으로 Offset값 지정.
    }
}
