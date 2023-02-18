using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PruebaCodigo : MonoBehaviour
{
    UnityEngine.Camera camera;
    public TMP_Text texto;
    Texture2D texture;
    /*****GET PIXEL******/
    /* public Texture2D heightmap;
     public Vector3 size = new Vector3(100, 10, 100);*/

    void Start()
    {
        camera = GetComponent<UnityEngine.Camera>();
    }

    void Update()
    {
        //transform.position = camera.ScreenToViewportPoint(Input.mousePosition); //Mueve la cámara a donde se encuentre el mouse
        Color color;

        /*int x = Mathf.FloorToInt(transform.position.x / size.x * heightmap.width);
        int z = Mathf.FloorToInt(transform.position.z / size.z * heightmap.height);
        Vector3 pos = transform.position;
        texto.text = camera.backgroundColor.ToString();
        pos.y = camera.GetPixel(x, z).grayscale * size.y;
        transform.position = pos;*/
    }


    /* void Update()
     {
         Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit))
         {
             texto.text = "veo el cubo";
         }
         else
         {
             texto.text = "No veo el cubo";
         }
     }*/
}
