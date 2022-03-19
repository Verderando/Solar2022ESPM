using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    public float rot;

    // Start is called before the first frame update
    void Start()
    {
        print("olá mundo");


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rot, 0);


    }
}
