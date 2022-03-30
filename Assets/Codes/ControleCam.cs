using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCam : MonoBehaviour
{   

    public GameObject Mercurio;
    public GameObject Venus;
    public GameObject Terra;
    public GameObject Marte;
    public GameObject Jupiter;
    public GameObject Saturno;
    public GameObject Urano;
    public GameObject Netuno;
    public GameObject Plutao;

    public int indice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(indice==0)
        {transform.position=Mercurio.transform.position;}

        if(indice==1)
        {transform.position=Venus.transform.position;}

        if(indice==2)
        {transform.position=Terra.transform.position;}

        if(indice==3)
        {transform.position=Marte.transform.position;}

        if(indice==4)
        {transform.position=Jupiter.transform.position;}

        if(indice==5)
        {transform.position=Saturno.transform.position;}

        if(indice==6)
        {transform.position=Urano.transform.position;}

        if(indice==7)
        {transform.position=Netuno.transform.position;}

        if(indice==8)
        {transform.position=Plutao.transform.position;}


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            indice = indice-1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            indice = indice+1;}

    }
}
