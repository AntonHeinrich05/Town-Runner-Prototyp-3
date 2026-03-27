using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int spawnPosxMin = 20;
    public int spawnPosxMax = 30;

    private float spawnDelay = 2f;
    public float repeateRate = 2f;

    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", spawnDelay, repeateRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            int spawnPosx = Random.Range(spawnPosxMin, spawnPosxMax);

            Instantiate(obstaclePrefab, new Vector3(spawnPosx, 0, 0), obstaclePrefab.transform.rotation);
        }
    }
}
