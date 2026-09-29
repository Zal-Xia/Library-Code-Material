using UnityEngine;

public class ContohPosisi : MonoBehaviour
{
    [SerializeField] private float kecepatan = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position = new Vector3(3f, 2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(kecepatan * Time.deltaTime, 0f, 0f);
    }
    
}
