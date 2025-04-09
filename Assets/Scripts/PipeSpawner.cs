using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private float _maxTime = 1.5f;

    [SerializeField]
    private float _highRange = 0.45f;

    [SerializeField]
    private GameObject _pipePrefab;

    private float timer;

    private void Start() => SpawnPipe();

    private void Update()
    {
        if (timer > _maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }


    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position
            + new Vector3(0, Random.Range(-_highRange, +_highRange));

        GameObject newPipe = Instantiate(_pipePrefab, spawnPos, Quaternion.identity);

        Destroy(newPipe, 10f);
    }
}
