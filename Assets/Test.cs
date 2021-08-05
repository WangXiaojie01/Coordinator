using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject TestCube;
    public GameObject TestSphere;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test world positionn si " + transform.position);
        Debug.Log("TestCube positionn si " + TestCube.transform.position);
        Debug.Log("TestSphere positionn si " + TestSphere.transform.position);
        Debug.Log("Test world localPosition si " + transform.localPosition);
        Debug.Log("TestCube localPosition si " + TestCube.transform.localPosition);
        Debug.Log("TestSphere localPosition si " + TestSphere.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log("Test world positionn si " + transform.position);
     //   Debug.Log("TestCube positionn si " + TestCube.transform.position);
     //   Debug.Log("TestSphere positionn si " + TestSphere.transform.position);
    }
}
