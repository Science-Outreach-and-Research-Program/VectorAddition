using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private GameObject arrow1;
    [SerializeField] private GameObject arrow21;
    [SerializeField] private GameObject arrow22;
    [SerializeField] private GameObject arrow31;
    [SerializeField] private GameObject arrow32;
    [SerializeField] private GameObject arrow41;
    [SerializeField] private GameObject arrow42;
    [SerializeField] private GameObject arrowTotal;
    [SerializeField] private GameObject lengthFigure;
    [SerializeField] private GameObject drawButtonText;

    public void DrawNextArrow()
    {
        if (!arrow1.activeSelf)
        {
            arrow1.SetActive(true);
            arrow21.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Draw Vector 2";
        }
        else if (!arrow22.activeSelf)
        {
            arrow22.SetActive(true);
            arrow31.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Draw Vector 3";
        }
        else if (!arrow32.activeSelf)
        {
            arrow32.SetActive(true);
            arrow41.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Draw Vector 4";
        }
        else if (!arrow42.activeSelf)
        {
            arrow42.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Draw Total Displacement Vector";
        }
        else if (!arrowTotal.activeSelf)
        {
            arrowTotal.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Calculate Length";
        }
        else if (!lengthFigure.activeSelf)
        {
            lengthFigure.SetActive(true);
            drawButtonText.GetComponent<Text>().text = "Restart";
        }
        else
        {
            arrow1.SetActive(false);
            arrow21.SetActive(false);
            arrow22.SetActive(false);
            arrow31.SetActive(false);
            arrow32.SetActive(false);
            arrow41.SetActive(false);
            arrow42.SetActive(false);
            arrowTotal.SetActive(false);
            lengthFigure.SetActive(false);
            drawButtonText.GetComponent<Text>().text = "Draw Vector 1";
        }
    }

    void Start()
    {
        drawButtonText.GetComponent<Text>().text = "Draw Vector 1";
    }
}
