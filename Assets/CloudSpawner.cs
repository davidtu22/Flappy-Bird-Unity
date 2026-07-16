using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 3f;
    private float timer = 0f;

    public float heightOffset = 4f;
    public float minScale = 0.5f;
    public float maxScale = 1.5f;
    public float minSpeed = 1f;
    public float maxSpeed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0f;
        }
    }

    void SpawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        GameObject newCloud = Instantiate(cloudPrefab, spawnPosition, transform.rotation);

        float randomScale = Random.Range(minScale, maxScale);
        newCloud.transform.localScale = new Vector3(randomScale, randomScale, 1);

        CloudMover mover = newCloud.GetComponent<CloudMover>();
        if (mover != null)
        {
            mover.moveSpeed = Random.Range(minSpeed, maxSpeed);
        }
    }
}
