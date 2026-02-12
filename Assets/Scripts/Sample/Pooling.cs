using UnityEngine;
using System.Collections.Generic;

public class Pooling : MonoBehaviour
{
    public List<GameObject> createdObjects;
    public GameObject prefabToCreate;

    void Start()
    {
        createdObjects = new List<GameObject> ();
    }

    public void CreateObject(Transform _transform)
    {
        GameObject pivotObject;
        for (int i = 0; i < createdObjects.Count; i++)
        {
            pivotObject = createdObjects [i];
            if (!pivotObject.activeInHierarchy)
            {
                pivotObject.SetActive (true);
                pivotObject.transform.position = _transform.position;
                return;
            }
        }

        createdObjects.Add(Instantiate(prefabToCreate,
            _transform.position,
            Quaternion.identity));
    }
}
