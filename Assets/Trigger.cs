using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int slotNumber;
    public int pointValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log($"{other.name} entered slot {slotNumber} worth {pointValue} points");
        Destroy(other.gameObject);
    }
}
