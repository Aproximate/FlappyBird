using System.Collections;
using UnityEngine;

public class TubesSpawner : ObjectPool
{
    [Min(0.5f)]
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private GameObject _tubePrefab;

    private bool _isSpawning;
    private Coroutine _startedSpawnCoroutine;

    private void Start()
    {
        Initialize(_tubePrefab);
    }

    public void TryStartSpawn()
    {
        if (_isSpawning == false)
        {
            _isSpawning = true;
            _startedSpawnCoroutine = StartCoroutine(Spawn());
        }
    }

    public void TryStopSpawn()
    {
        if (_startedSpawnCoroutine == null)
            return;

        StopCoroutine(_startedSpawnCoroutine);
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            if (TryGetObject(out GameObject tubes))
            {
                SetTube(tubes);
                yield return new WaitForSeconds(_secondBetweenSpawn);
            }
        }
    }

    private void SetTube(GameObject tubes)
    {
        tubes.SetActive(true);

        var position = tubes.transform.position;
        position.x = transform.position.x;
        tubes.transform.position = position;
    }
}
