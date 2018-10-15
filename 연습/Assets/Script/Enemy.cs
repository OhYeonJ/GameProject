using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    /*
    public bool inputAttack = false; //어택 버튼 누르지 않은 상태
    public bool inputJump = false; //점프 버튼 누르지 않은 상태
    */
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-5.0f * Time.deltaTime, 0.0f, 0.0f));
	}
    

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
