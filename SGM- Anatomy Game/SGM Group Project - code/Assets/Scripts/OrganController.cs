using UnityEngine;
using TouchScript;

public class OrganController : MonoBehaviour 
{

    #region Variables
	public string tag;
	#endregion

    #region Unity Methods

    private void OnEnable()
    {
        if (TouchManager.Instance != null)
        {
            TouchManager.Instance.TouchesMoved += touchesMovedHandler;
            TouchManager.Instance.TouchesBegan += Instance_TouchesBegan;
            TouchManager.Instance.TouchesEnded += Instance_TouchesEnded;
        }
    }



    void OnDisable()
    {
        if (TouchManager.Instance != null)
        {
            TouchManager.Instance.TouchesMoved -= touchesMovedHandler;
            TouchManager.Instance.TouchesBegan -= Instance_TouchesBegan;
            TouchManager.Instance.TouchesEnded -= Instance_TouchesEnded;
        }
    }

    private void touchesMovedHandler(object sender, TouchEventArgs e)
    {
		if (gameObject.GetComponent<LockOrgan> ().locked != true) 
		{
			int count = e.Touches.Count;
			for (int i = 0; i < count; i++) {
				TouchPoint touch = e.Touches [i];
				if (touch.Tags.HasTag (tag)) {
					float y = touch.Position.y;
					float x = touch.Position.x;

					transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 5));

					float f = (float)touch.Properties ["Angle"];
					transform.rotation = Quaternion.Euler (0, 0, (f / 6.25f) * 360f);
				}
			}
		}
    }

    private void Instance_TouchesBegan(object sender, TouchEventArgs e)
    {
		if (gameObject.GetComponent<LockOrgan> ().locked != true) 
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}

    private void Instance_TouchesEnded(object sender, TouchEventArgs e)
	{
		if (gameObject.GetComponent<LockOrgan> ().locked != true) 
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
	}
}

	#endregion
