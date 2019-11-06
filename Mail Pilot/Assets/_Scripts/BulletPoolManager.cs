using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    public int spawnCount;
    public Queue<GameObject> bulletList = new Queue<GameObject>();
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pools
     
        for (int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            bulletList.Enqueue(obj);
        }
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        GameObject objectToSpawn = bulletList.Dequeue();
        objectToSpawn.SetActive(true);
        bulletList.Enqueue(objectToSpawn);
        return objectToSpawn;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
    }
}

