using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab;
    [SerializeField] private float _timeToSpawn;
    [SerializeField] private float _minYPosition = -2;
    [SerializeField] private float _maxYPosition = 2;
    [SerializeField] private float _timer;
    [SerializeField] private int _maxPipes = 5;
    
    private List<GameObject> _pipes = new List<GameObject>();
    
    private void Update()
    {
        if (_timer <= 0)
        { 
            _timer = _timeToSpawn;
           SpawnPipe();
        }
        else
        {
            _timer -= Time.deltaTime;
        }
        DeletePipe();
    }

    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(_pipePrefab,transform.position,Quaternion.identity);
        float rand = Random.Range(_minYPosition,_maxYPosition);
        pipe.transform.position = new Vector3(pipe.transform.position.x, rand, 0);
        _pipes.Add(pipe);  
    }

    private void DeletePipe()
    {
        if (_pipes.Count >= _maxPipes)
        {
            var pipeForRemove = _pipes[0];
            _pipes.Remove(pipeForRemove);
            Destroy(pipeForRemove);
        }
    }
}
