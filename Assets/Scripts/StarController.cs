using UnityEngine;
using UnityEngine.UI;

public class StarController : MonoBehaviour
{

	public Image[] starImages;
	public Color defaultColor;
	public Color highlightColor;

	void Awake ()
	{
		starImages = GetComponentsInChildren<Image> ();
	}

	void Update ()
	{
		for (int i = 0; i < 6; i++) {
			if (i < GameManager.Instance.degree) {
				starImages [5 - i].color = highlightColor;
			} else {
				starImages [5 - i].color = defaultColor;
			}
		}
	}

}