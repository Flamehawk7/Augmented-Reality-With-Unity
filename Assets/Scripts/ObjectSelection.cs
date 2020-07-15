using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelection : MonoBehaviour
{
    public GameObject Tree1, Tree2, Grass, Flower, Rock1, Rock2;
    public Image Tree1_Button, Tree2_Button, Grass_Button, Flower_Button, Rock1_Button, Rock2_Button;

    public void Tree1Button(int i)
    {
        switch (i)
        {
            case 0:
                GetComponent<TapToPlaceObject>().objectToPlace = Tree1;
                Tree1_Button.color = new Color32(107, 255, 102, 255);
                Tree2_Button.color = new Color32(255, 255, 255, 255);
                Grass_Button.color = new Color32(255, 255, 255, 255);
                Flower_Button.color = new Color32(255, 255, 255, 255);
                Rock1_Button.color = new Color32(255, 255, 255, 255);
                Rock2_Button.color = new Color32(255, 255, 255, 255);
                break;
            case 1:
                GetComponent<TapToPlaceObject>().objectToPlace = Tree2;
                Tree1_Button.color = new Color32(255, 255, 255, 255);
                Tree2_Button.color = new Color32(107, 255, 102, 255);
                Grass_Button.color = new Color32(255, 255, 255, 255);
                Flower_Button.color = new Color32(255, 255, 255, 255);
                Rock1_Button.color = new Color32(255, 255, 255, 255);
                Rock2_Button.color = new Color32(255, 255, 255, 255);
                break;
            case 2:
                GetComponent<TapToPlaceObject>().objectToPlace = Grass;
                Tree1_Button.color = new Color32(255, 255, 255, 255);
                Tree2_Button.color = new Color32(255, 255, 255, 255);
                Grass_Button.color = new Color32(107, 255, 102, 255);
                Flower_Button.color = new Color32(255, 255, 255, 255);
                Rock1_Button.color = new Color32(255, 255, 255, 255);
                Rock2_Button.color = new Color32(255, 255, 255, 255);
                break;
            case 3:
                GetComponent<TapToPlaceObject>().objectToPlace = Flower;
                Tree1_Button.color = new Color32(255, 255, 255, 255);
                Tree2_Button.color = new Color32(255, 255, 255, 255);
                Grass_Button.color = new Color32(255, 255, 255, 255);
                Flower_Button.color = new Color32(107, 255, 102, 255);
                Rock1_Button.color = new Color32(255, 255, 255, 255);
                Rock2_Button.color = new Color32(255, 255, 255, 255);
                break;
            case 4:
                GetComponent<TapToPlaceObject>().objectToPlace = Rock1;
                Tree1_Button.color = new Color32(255, 255, 255, 255);
                Tree2_Button.color = new Color32(255, 255, 255, 255);
                Grass_Button.color = new Color32(255, 255, 255, 255);
                Flower_Button.color = new Color32(255, 255, 255, 255);
                Rock1_Button.color = new Color32(107, 255, 102, 255);
                Rock2_Button.color = new Color32(255, 255, 255, 255);
                break;
            case 5:
                GetComponent<TapToPlaceObject>().objectToPlace = Rock2;
                Tree1_Button.color = new Color32(255, 255, 255, 255);
                Tree2_Button.color = new Color32(255, 255, 255, 255);
                Grass_Button.color = new Color32(255, 255, 255, 255);
                Flower_Button.color = new Color32(255, 255, 255, 255);
                Rock1_Button.color = new Color32(255, 255, 255, 255);
                Rock2_Button.color = new Color32(107, 255, 102, 255);
                break;
            default:
                break;
        }
    }
}
