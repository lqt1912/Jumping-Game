using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCOntrol : MonoBehaviour {

    public int pointAdd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent <PLayerController>()==null)
            return;
        ScoreManager.addPoint(pointAdd);
       
        Destroy(gameObject);
    }
}
