using UnityEngine;

public class ColorChangeListenerConsole : MonoBehaviour 
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
        print("new color = " + newColor); 
	}
}
