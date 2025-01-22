using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSpawner : MonoBehaviour
{
    public GameObject gasPrefab;
    public RoadPositionSO roadPosition;
    void Start()
    {
        StartCoroutine(SpawnGas());
    }

    private IEnumerator SpawnGas()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int idx = Random.Range(0, 2);
            Vector3 gasPos = new Vector3(roadPosition.positions[idx], transform.position.y, transform.position.z);
            Instantiate(gasPrefab, gasPos, Quaternion.identity);
        }
    }
}
