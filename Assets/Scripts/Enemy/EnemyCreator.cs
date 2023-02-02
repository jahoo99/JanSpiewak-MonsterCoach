using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    private Vector2 _screenBounds;
    private int _enemyNumber = 1000;
    [SerializeField] private ObjectPool _op;
    private void Start()
    {
        _screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        for (int i =0;i< _enemyNumber; i++)
        {
            _op.SpawnFromPool("Enemy", new Vector2(Random.Range(-_screenBounds.x/2, _screenBounds.x/2), Random.Range(-_screenBounds.y / 2, _screenBounds.y / 2)), Quaternion.identity);
        }
    }
}
