using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_FactoryClinet : MonoBehaviour
{
    public C_NPCSpawner m_SpawnerNPC;
    public static int count = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
            count++;
        }

    }
}
