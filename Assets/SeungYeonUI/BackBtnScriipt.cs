using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//참고하셔유 인벤토리 X 버튼입니다 

public class BackBtnScriipt : MonoBehaviour
{
    public GameObject BackB; 

    public void BackBtn() //X버튼에 연결
    {
        BackB.SetActive(false);
    }
}
