using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public float inicialTimeSpawn;
    public float timeSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= inicialTimeSpawn)
        {

            inicialTimeSpawn += timeSpawn;
        }
    }
}
