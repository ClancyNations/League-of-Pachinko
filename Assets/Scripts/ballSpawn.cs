using UnityEngine;

public class ballSpawn : MonoBehaviour
{

    public GameObject ball;
    public float ySpawnLocation;
    public float xSpawnMin;
    public float xSpawnMax;
    public float ballNum;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ballNum > 0)
        {
            float xSpawn = Random.Range(xSpawnMin, xSpawnMax);
            Vector2 spawnPos = new Vector2(xSpawn, ySpawnLocation);
            Instantiate(ball, spawnPos, Quaternion.identity);
            ballNum--;
        }
    }
}
