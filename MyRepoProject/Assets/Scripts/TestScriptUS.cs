using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptUS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLO FROM US!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(60,0,0)*Time.deltaTime, Space.Self);
    }
}
