using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 불러오기.

public class GaugeDirector : MonoBehaviour {

    GameObject hpGauge;
    

    // Use this for initialization
    void Start () {

        this.hpGauge = GameObject.Find("HpGauge");
	}
	
	public void DescreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.3f;

    }
}
