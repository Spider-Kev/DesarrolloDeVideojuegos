using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    public string horizontalName = "Horizontal";
    public string verticalName = "Vertical";

    public ClassSample classObject;
    public StructSample structObject;

    public ClassSample classDuplicate;
    public StructSample structDuplicate;

    [ContextMenu("Simulate change")]
    public void ChangeInfo()
    {
        classDuplicate = classObject;
        classDuplicate.id = -1;
        classDuplicate.name = "Kev";

        structDuplicate = structObject;
        structDuplicate.id = -1;
        structDuplicate.name = "Kev";
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start ejecutandose");

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis(horizontalName);
        float vertical = Input.GetAxis(verticalName);

        transform.position += new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;

        GameObject newObject = new GameObject();
        Destroy( newObject );
    }
}

[System.Serializable]
public class ClassSample
{
    public int id;
    public string name;
}

[System.Serializable]
public struct StructSample
{
    public int id;
    public string name;
}

