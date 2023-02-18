using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Camera : MonoBehaviour
{
    WebCamTexture cam_texture;
    public GameObject cubo;
    Color pixelColor;

    public TMP_Text texto;

    string strHexColor, strRGBColor, strHSVColor;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] cam_devices = WebCamTexture.devices;

        cam_texture = new WebCamTexture(cam_devices[0].name);
        GetComponent<Renderer>().material.mainTexture = cam_texture; // Este se puede borrar cuando no necesite proyectar la imagen dentro de unity

        if (cam_texture != null)
            cam_texture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        pixelColor = cam_texture.GetPixel(50,50);

        strHexColor = ColorUtility.ToHtmlStringRGB(pixelColor);
        strRGBColor = toStringRGB(pixelColor);
        strHSVColor = toStringHSV(pixelColor);
        
        texto.text =
            "Hex: " + strHexColor +
            "<br>RGB: " + strRGBColor + 
            "<br>HSV: " + strHSVColor;
        Debug.Log(
            "Hex: " + strHexColor + 
            " RGB: " + strRGBColor +
            " HSV: " + strHSVColor);

        cubo.GetComponent<Renderer>().material.color = pixelColor;
    }

    string toStringHSV(Color color) // Convert to extension function
    {
        int conversionFactH, conversionFactSV;
        int roundedH, roundedS, roundedV;

        conversionFactH = 359;
        conversionFactSV = 100;

        Color.RGBToHSV(color, out float H, out float S, out float V);

        roundedH = Mathf.RoundToInt(H * conversionFactH);
        roundedS = Mathf.RoundToInt(S * conversionFactSV);
        roundedV = Mathf.RoundToInt(V * conversionFactSV);

        return $"{roundedH}, {roundedS}, {roundedV}";
    }

    string toStringRGB(Color color)// convert to extension function
    {
        //Beacuse for the Color class the RGB color values are porcentages of themselves
        int conversionFactRGB = 255;
        return $"{color.r * conversionFactRGB}, {color.g * conversionFactRGB}, {color.b * conversionFactRGB}";
    }

    /*
     * The Todo List
     * 
     * will try to indentifier the center pixel of screen.
     * real color object reference.
     * reduce the fames that are analyzed.
     * show what is the area that is analyzing
     * funtionality of copy code.
     * select from a specific area to analyze.
     * App aesthetics - customizable for the user. The user can create some images to the aesthetics app.
     * object tracking
     * 
     */

}
