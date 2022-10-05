using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0;
    private float lastHit = 0;

    // Update is called once per frame
    void Update()
    {
        lastHit += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (lastHit >= Time.deltaTime * 100)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            lastHit = 0;
        }
    }
}
