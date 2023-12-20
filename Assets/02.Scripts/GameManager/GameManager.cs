using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rangeObject;
    BoxCollider rangeCollider;
    public GameObject Monster;
    public GameObject Bear;
    

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        StartCoroutine(RandomRespawn_Coroutione());
        
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;
        float range_X = rangeCollider.bounds.size.x;
        float range_Z = rangeCollider.bounds.size.z;

        range_X = Random.Range((range_X / 2) * -1, range_X / 2);
        range_Z = Random.Range((range_Z / 2) * -1, range_Z / 2);
        Vector3 RandomPosition = new Vector3(range_X, 0f, range_Z);

        Vector3 respawnPosition = originPosition + RandomPosition;
        return respawnPosition;
    }

    IEnumerator RandomRespawn_Coroutione()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            GameObject instantBear = Instantiate(Bear, Return_RandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(3f);
            GameObject instantMonster = Instantiate(Monster, Return_RandomPosition(), Quaternion.identity);
            Destroy(instantMonster, 10);
            Destroy(instantBear, 15);
        }

    }

    
}
