using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrilleGeneratior : MonoBehaviour {


    public int height;
    public int width;

    public GameObject[] caseTab;

	// Use this for initialization
	void Start () {
        if (height <= 0 || width <= 0)
            return;
        if (caseTab.Length <= 0)
            return;

        //Generation de la grille;
        for(int i = 0; i<height;i++)
        {
            for(int y=0;y<width;y++)
            {
                int r = Random.Range(0, caseTab.Length);
                GameObject newChild = GameObject.Instantiate(caseTab[r]);
                newChild.transform.position = new Vector3(i, y, 0);
            }
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
