using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - startTime >= 2)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            startTime = Time.time;
        }
     
    }
   

}
