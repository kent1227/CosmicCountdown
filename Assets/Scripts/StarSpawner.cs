using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class StarSpawner : MonoBehaviour
{

    [SerializeField] private Star[] _starPrefabs;
    [SerializeField] private int _spawnAmount;

    private ObjectPool<Star> _starPool;


    // Start is called before the first frame update
    void Start()
    {

        _starPool = new ObjectPool<Star>(() =>
        {
            int i;
            float random = Random.value;
            if (random < 0.4)
            {
                i = 0;
            }
            else if (random < 0.7)
            {
                i = 1;
            }
            else if (random < 0.9)
            {
                i = 2;
            }
            else
            {
                i = 3;
            }
            return Instantiate(_starPrefabs[i]);
        }, star =>
        {
            star.gameObject.SetActive(true);
        }, star =>
        {
            star.gameObject.SetActive(false);
        }, star =>
        {
            
        }, false, 25, 50);


        InvokeRepeating(nameof(Spawn), 0.5f, 0.5f);

    }

    private void Spawn()
    {
        for (var i=0; i<_spawnAmount; i++)
        {
            var star = _starPool.Get();
            float randomY = Random.Range(-5f, 5f);
            star.transform.position = new Vector2(10, randomY);
            star.Init(KillStar);
        }
    }


    private void KillStar(Star star)
    {
        _starPool.Release(star);
    }
}
