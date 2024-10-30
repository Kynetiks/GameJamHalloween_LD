using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCompteur : MonoBehaviour

{

    public int _points;

    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _points = 0;

    }

    // Update is called once per frame
    
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            
            _points += other.gameObject.GetComponent<PointItem>().points;
            Debug.Log("J'ai: " + _points + " points.");

            Destroy(other.gameObject);
        }
    }
}
