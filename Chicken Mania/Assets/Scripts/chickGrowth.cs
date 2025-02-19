using UnityEngine;

public class chickGrowth : MonoBehaviour
{
    public GameObject spawnChicken;

    public float timetoGrow, growCountdown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        growCountdown = timetoGrow;
    }

    // Update is called once per frame
    void Update()
    {
        growCountdown -= Time.deltaTime;

        if (growCountdown <= 0)
        {
            growCountdown = timetoGrow;
            Destroy(gameObject);
            Instantiate(spawnChicken, transform.position, transform.rotation);
        }
    }
}
