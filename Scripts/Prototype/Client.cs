using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Drone m_Drone;
    public Sniper m_Sniper;
    public Gamer m_Gamer;
    public EnemySpawner m_Spawner;

    //For profiler demo
    public GameObject sniperPrefab;
    public GameObject dronePrefab;
    private GameObject current;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementGamer = 0;

    void Start()
    {
        sniperPrefab = Resources.Load<GameObject>("SniperPrototype");
    }

    public void Update()
    {
        //For profiler demo, spawn these via Instantiate
        if (Input.GetKeyDown(KeyCode.D))
        {
            current = Instantiate(dronePrefab);
            current.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
            /* non-profiler code
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
            */
        }

        //For profiler demo, spawn these via Resource.Load
        if (Input.GetKeyDown(KeyCode.S))
        {
            current = Instantiate(Resources.Load<GameObject>("SniperPrototype"));
            current.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.5f);
            /* non-profiler code
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.5f);
            */
        }

        //Commented for simplicity of profiler demonstration
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    m_Spawn = m_Spawner.SpawnEnemy(m_Gamer);

        //    m_Spawn.name = "Gamer_Clone_" + ++m_IncrementGamer;
        //    m_Spawn.transform.Translate(Vector3.forward * m_IncrementGamer * 1.5f);
        //}
    }
}
