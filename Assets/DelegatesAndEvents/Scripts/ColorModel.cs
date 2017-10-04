using UnityEngine;

public class ColorModel
{
    private Color color;

	public void SetColor(Color newColor)
	{
		this.color = newColor;
        PublishColorEvent();
	}

	public Color GetColor()
	{
        return this.color;
	}


	public delegate void ColorChangeHandler();
	public static event ColorChangeHandler onChangeColor;


	private void PublishColorEvent(){
		// if there is at least one listener to this delegate
		if( onChangeColor != null){
			// broadcast change colour event 
			onChangeColor();
		}
	}
}