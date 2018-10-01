using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour
{

    public float scrollSpeed = 0.001f; //스크롤 스피드
    Material myMaterial;

    // Use this for initialization
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;//컴포넌트 가져오기
    }

    // Update is called once per frame
    void Update()
    {
        float newOffsetX = myMaterial.mainTextureOffset.x + scrollSpeed * Time.deltaTime; //오프셋 스피드= 마테리얼 * 스크롤 스피드 * 델타타임
        Vector2 newOffet = new Vector2(newOffsetX, 0);
        myMaterial.mainTextureOffset = newOffet;
    }
}