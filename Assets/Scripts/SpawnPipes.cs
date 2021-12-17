using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipePrefab;
    public float pipeTime = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pipeSpawner());
    }
    
    private void spawnPipe() 
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = new Vector2(12, Random.Range(-3, 3));
    }
    // Update is called once per frame
    IEnumerator pipeSpawner() 
    {
            while (true) 
            {
                yield return new WaitForSeconds(pipeTime);
                spawnPipe();
            }
            
    }
    
     
}
