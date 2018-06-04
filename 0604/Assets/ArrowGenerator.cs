using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    float span = 1.0f;
    float delte = 0;

	
	
	// Update is called once per frame
	void Update () {
        this.delte += Time.deltaTime;
        if(this.delte > this.span)
        {
            this.delte = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

		
	}
}
