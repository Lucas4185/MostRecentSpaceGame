using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArmScript2 : MonoBehaviour
{

    public GameObject Arm2;
    bool spawnOnce = true;

    Vector3 spawnPos;

    void Update()
    {

        SpawnArms2();

    }

    // Update is called once per frame

    private void SpawnArms2()
    {
        spawnPos.x = 10;
        spawnPos.y = Random.Range(10f, 20f);
        spawnPos.z = -3.47f;
        if (spawnOnce == true)
        {
            Instantiate(Arm2, spawnPos, Quaternion.identity);
            spawnOnce = false;
        }
    }
}