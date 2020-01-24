using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_NPCFactory : MonoBehaviour
{
    public Drone m_drone;
    private Enemy m_spawn;
    public EnemySpawner spawner;
    public Enemy getNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                m_spawn = spawner.SpawnEnemy(m_drone);
                return m_spawn;
                //INPC beggar = new Beggar();
                //return beggar;
            case NPCType.Farmer:
                Gamer gamer = new Gamer();
                return gamer;
                //INPC farmer = new Farmer();
                //return farmer;
            case NPCType.Shopowner:
                Sniper sniper = new Sniper();
                return sniper;
                //INPC shopowner = new ShopOwner();
                //return shopowner;
            case NPCType.QuestGiver:
                return null;
                //INPC questgiver = new QuestGiver();
                //return questgiver;
        }
        return null;
    }
}
