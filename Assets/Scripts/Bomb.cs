using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;
    void Start()
    {
        Invoke("Explode", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Explode() 
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity); //1
        GetComponent<MeshRenderer>().enabled = false; //2
        transform.Find("Collider").gameObject.SetActive(false); //3
        Destroy(gameObject, .3f); //4
    }  

}
