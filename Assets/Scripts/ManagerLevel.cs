using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLevel : MonoBehaviour {

    // Use this for initialization
    public GameObject currCheckPoint;
    public PLayerController player;
    public GameObject deadEffect;
    public GameObject liveEffect;
    public float Delay;
    public int  subScore=50;
	void Start () {
        player = FindObjectOfType<PLayerController>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void Crash()
    {
        StartCoroutine("DelayLive");
    }
    public IEnumerator DelayLive()
    {
        Instantiate(deadEffect, player.transform.position, player.transform.rotation);
        yield return new WaitForSeconds(Delay);
        player.transform.position = currCheckPoint.transform.position;
        ScoreManager.addPoint(-subScore);
        Instantiate(liveEffect, player.transform.position, currCheckPoint.transform.rotation);
        //Debug.Log("Crash! at "+transform.position);
    }
}
