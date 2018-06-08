using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArmsScript : MonoBehaviour {


    public GameObject Arm1;
    bool spawnOnce = true;

    Vector3 spawnPos;
    // Update is called once per frame
    void Update () {

        SpawnArms();

    }

    private void SpawnArms()
    {
        spawnPos.x = -10;
        spawnPos.y = Random.Range(5f, 20f);
        spawnPos.z = -3.47f;
        if (spawnOnce == true)
        {
            Instantiate(Arm1, spawnPos, Quaternion.identity);
            spawnOnce = false;
        }
    }
}
