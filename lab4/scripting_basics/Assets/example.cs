using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    public float speed = 50.0f;
    public float distance = 100.0f;
    public float time = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = distance / time;
        if (speed > 70 || speed < 40)
        {
            print("You are breaking the law!!");
        }
        print("You are traveling at " + speed + "MPH");
    }

    // Update is called once per frame
    void Update()
    {

    }
}