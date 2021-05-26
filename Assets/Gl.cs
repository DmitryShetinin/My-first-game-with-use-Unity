using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gl : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startVertex;
    Vector3 mousePos;
    void Start()
    {
        startVertex = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        OnPostRender(); 
    }

    void OnPostRender()
    {
        mousePos = Input.mousePosition;
        GL.PushMatrix();
       
        GL.LoadOrtho();

        GL.Begin(GL.LINES);
        GL.Color(Color.red);
        GL.Vertex(startVertex);
        GL.Vertex(new Vector3(mousePos.x / Screen.width, mousePos.y / Screen.height, 0));
        GL.End();

        GL.PopMatrix();
    }
}
