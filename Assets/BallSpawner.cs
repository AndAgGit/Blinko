using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnTransform;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(Input.GetKey(KeyCode.Space) && timer <= 0){
            Instantiate(ballPrefab, randPosition(), Quaternion.identity);

            timer = 0.1f;
        }
    }

    Vector3 randPosition(){
        float max = 3.5f;
        float min = -9.5f;

        float x = Random.Range(min,max);
        return new Vector3(x,2,0);
    }
}
