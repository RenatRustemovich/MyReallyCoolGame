using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node1 : MonoBehaviour {

    public NodeDialog1 NodeDialog1;
    public GameObject[] buildings;
    private GameObject own = null;

    private void OnMouseDown()
    {
        if(own == null) { NodeDialog1.Show(this); }
       
    }

    public void Build(string txt)
    {
        switch (txt)
        {
            case "lemonade": own = Instantiate(buildings[0], this.transform.position, Quaternion.identity); break;
            case "hotdogs": own = Instantiate(buildings[1], this.transform.position, Quaternion.identity); break;

        }
    }

}
