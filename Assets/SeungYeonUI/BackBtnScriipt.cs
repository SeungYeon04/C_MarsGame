using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����ϼ��� �κ��丮 X ��ư�Դϴ� 

public class BackBtnScriipt : MonoBehaviour
{
    public GameObject BackB; 

    public void BackBtn() //X��ư�� ����
    {
        BackB.SetActive(false);
    }
}
