using UnityEngine;

public class Poists : MonoBehaviour
{
    public GameObject points;

    public float yt;
    public float spid;
    

    // Start is called before the first frame update
    void Start()
    {
        points = GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        yt = points.transform.rotation.y;
        yt += Time.deltaTime * spid;
        
        
        points.transform.Rotate(new Vector3(0, yt, 0));  

    }
}
