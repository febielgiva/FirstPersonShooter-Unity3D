using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
    private GameObject[] _enemy ;
    public static int count =1;

    void Start()
    {
        float angle;
             _enemy = new GameObject[10];
            _enemy[0] = Instantiate(enemyPrefab) as GameObject;
            _enemy[0].transform.position = new Vector3(50.3329f, 2.973698f, 29.30381f);
            angle = Random.Range(0, 360);
            _enemy[0].transform.Rotate(0, angle, 0);
        
    }
 
void Update() {
        float angle;
   
        if (count > getEnemyCount(_enemy))
        {
            for (int i = 0; i < count; i++)
            {
                if (_enemy[i] == null) { 
                    //respawn that enemy
                    _enemy[i] = Instantiate(enemyPrefab) as GameObject;
                    //_enemy[i].name = "enemy_" + i;
                    _enemy[i].transform.position = new Vector3(50.3329f , 2.973698f, 29.30381f);
                    angle = Random.Range(0, 360);
                    _enemy[i].transform.Rotate(0, angle, 0);

                    //add extra enemy
                    int n = Random.Range(0, 3);
                    if ((n + getEnemyCount(_enemy)) <= 10)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            _enemy[count] = Instantiate(enemyPrefab) as GameObject;
                            //_enemy[count].name = "Enemy" + count;
                             _enemy[count].transform.position = new Vector3(53.3329f, 2.973698f, 29.30381f);
                            angle = Random.Range(0, 360);
                            _enemy[count].transform.Rotate(0, angle, 0);
                            count++;
                        }
                    }

                }
            }
        }
        }
int getEnemyCount(GameObject[] enemies)
{
    int countLocal = 0;
    foreach (GameObject eachenemy in enemies)
    {
        if (eachenemy != null)
        {
            countLocal = countLocal + 1;
        }
    }
    return countLocal;
}
}

