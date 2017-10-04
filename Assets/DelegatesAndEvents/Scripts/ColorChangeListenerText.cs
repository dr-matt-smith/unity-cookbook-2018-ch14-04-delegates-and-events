using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorChangeListenerText : MonoBehaviour 
{
    public ColorManager colorManager;

    private ColorModel colorModel;

    void Start()
    {
        colorModel = colorManager.GetColorModel();
    }

	void OnEnable() {
		ColorModel.onChangeColor += ChangeColorEvent;
	}
	
	private void OnDisable(){
		ColorModel.onChangeColor -= ChangeColorEvent;
	}

	void ChangeColorEvent(){
        Color newColor = colorModel.GetColor();
		GetComponent<Text>().color = newColor;
	}
}
