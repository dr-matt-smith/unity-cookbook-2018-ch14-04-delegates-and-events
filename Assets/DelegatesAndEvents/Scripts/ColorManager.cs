using UnityEngine;

public class ColorManager : MonoBehaviour 
{
    private ColorModel colorModel;

    public ColorModel GetColorModel()
    {
        return this.colorModel;
    }

    void Awake()
    {
        colorModel = new ColorModel();
    }

	public void BUTTON_ACTION_make_green(){
		colorModel.SetColor(Color.green);
	}

	public void BUTTON_ACTION_make_blue(){
		colorModel.SetColor(Color.blue);
	}

	public void BUTTON_ACTION_make_red(){
		colorModel.SetColor(Color.red);
	}
}