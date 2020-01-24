using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_NPCSpawner : MonoBehaviour
{
    public C_NPCFactory m_Factory;

    private Enemy m_Farmer;
    private Enemy m_Beggar;
    private Enemy m_ShopOwner;
    private Enemy m_QuestGiver;
    public EnemySpawner spawner;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.getNPC(NPCType.Beggar);
    }
}
