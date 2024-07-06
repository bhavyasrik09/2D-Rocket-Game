using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    private MeshRenderer mesh;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      Scroll();
    }
    public void Scroll()
    {
        speed+=0.001f * Time.deltaTime;
        Vector2 offset = new Vector2(speed * Time.time, 0);
        mesh.sharedMaterial.SetTextureOffset("_MainTex",offset);


    }
}
