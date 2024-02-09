using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipeLinePrefab;
    [SerializeField] Transform spawnePoint;
    [SerializeField] float repeatTime;
    [SerializeField] float randomRage;

    private Coroutine coroutine;

    private void OnEnable()
    {
        coroutine = StartCoroutine(SpawnRoutine());
    }
    private void OnDisable()
    {
        StopCoroutine(coroutine);
    }
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(repeatTime);
            Vector3 random = Vector3.up * Random.Range(-randomRage, randomRage);
            Instantiate(pipeLinePrefab, spawnePoint.position+random, spawnePoint.rotation);
        }
    }
}
