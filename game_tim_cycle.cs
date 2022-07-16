using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gametimecycle : MonoBehaviour
{

    public float cycle_lenght;
    public GameObject light;
    private float update_time;
    // Start is called before the first frame update
    void Start()
    {
        update_time = 360.0f / cycle_lenght;
    }

    // Update is called once per frame
    void Update()
    {
        light.transform.Rotate(update_time / (float)Application.targetFrameRate,0,0,Space.Self);
	light.transform.Rotate(update_time / (float)Application.targetFrameRate,0,0,Space.World);
    }
}
