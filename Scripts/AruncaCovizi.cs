using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AruncaCovizi : MonoBehaviour
{
    public float initialTimeAcceleration;
    private float timeAcceleration;
    public float timeIncrease;
    public float initialMaximumTime;
    private float maximumTime;
    float randY;
    Vector2 whereToSpawn;

    //public Covid covid;
    //public Pilula pilula;
    //public Zinc zinc;
    //public Vaccin vaccin;

    public GameObject CovidPrefab;
    public GameObject PilulaPrefab;
    public GameObject ZincPrefab;
    public GameObject VaccinPrefab;

    public static float initialRate = 4f;
    public float spawnRateCovid = 4f;
    public float spawnRatePilula = 10f;
    public float spawnRateZinc = 14f;
    public float spawnRateVaccin = 21f;

    public float initialNextSpawnCovid = 0.0f;
    public float initialNextSpawnPilula = 5.0f;
    public float initialNextSpawnZinc = 10.0f;
    public float initialNextSpawnVaccin = 12.0f;

    public float nextSpawnCovid = 0.0f;
    public float nextSpawnPilula = 5.0f;
    public float nextSpawnZinc = 10.0f;
    public float nextSpawnVaccin = 10.0f;

    private void Start()
    {
        Time.timeScale = 1;
        spawnRateCovid = initialRate;
        timeAcceleration = Time.time + initialTimeAcceleration;
        maximumTime = Time.time + initialMaximumTime;
        nextSpawnCovid = Time.time + initialNextSpawnCovid;
        nextSpawnPilula = Time.time + initialNextSpawnPilula;
        nextSpawnZinc = Time.time + initialNextSpawnZinc;
        nextSpawnVaccin = Time.time + initialNextSpawnVaccin;
    }

    void Update()
    {
        if (ZincPrefab != null && Time.time > nextSpawnZinc)
        {
            nextSpawnZinc = Time.time + spawnRateZinc;
            randY = Random.Range(-4.5f, 4.5f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(ZincPrefab, whereToSpawn, Quaternion.identity);
        }

        if (PilulaPrefab != null && Time.time > nextSpawnPilula)
        {
            nextSpawnPilula = Time.time + spawnRatePilula;
            randY = Random.Range(-4.5f, 4.5f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(PilulaPrefab, whereToSpawn, Quaternion.identity);
        }

        if (CovidPrefab != null && Time.time > nextSpawnCovid)
        {
            nextSpawnCovid = Time.time + spawnRateCovid;
            randY = Random.Range(-4.5f, 4.5f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(CovidPrefab, whereToSpawn, Quaternion.identity);
        }

        if (VaccinPrefab != null && Time.time > nextSpawnVaccin)
        {
            nextSpawnVaccin = Time.time + spawnRateVaccin;
            randY = Random.Range(-4.5f, 4.5f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(VaccinPrefab, whereToSpawn, Quaternion.identity);
        }

        if (Time.time > timeAcceleration && timeAcceleration < maximumTime)
        {
            timeAcceleration += timeIncrease;
            spawnRateCovid = 0.9f * spawnRateCovid;
        }
    }

}
