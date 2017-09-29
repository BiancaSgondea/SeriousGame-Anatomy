using UnityEngine;

public class ParticleSystemLayerControl : MonoBehaviour 
{

    #region Variables
    public string sortingLayer;
    #endregion

    #region Unity Methods

    void Start()
    {
        //Change Foreground to the layer you want it to display on 
        //You could prob. make a public variable for this
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = sortingLayer;
    }
	#endregion
}
