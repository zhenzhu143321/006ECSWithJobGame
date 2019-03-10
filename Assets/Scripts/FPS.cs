using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    //public Text countText;
    public Text fpsText;

	float deltaTime;
	
	void Update ()
	{
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        fpsText.text = string.Format("FPS: {0:00.} ({1:00.0} ms)", fps, msec);
    }

    public void SetElementCount(int count)
    {
        //countText.text = "物体数量: " + count.ToString();
    }

}
