using UnityEngine;
using System.Collections;
public class ModelSwapper : MonoBehaviour {
  public TrackableBehaviour theTrackable;

  private string modelName = "Regular", paintName = "Red", wheelsName = "Silver", interiorName="Tan";
  private bool swapModel, swapPaint, swapWheels, swapInterior = false;

  // Use this for initialization
  void Start () {
    if (theTrackable == null)
    {
      Debug.Log ("Warning: Trackable not set!!");
    }
  }

  // Update is called once per frame
  void Update () {
		//Changes car features if a button was pressed
		if (swapModel || swapPaint || swapWheels || swapInterior) {
			if (swapModel) {
				if (modelName == "Regular") {
					modelName = "Spyder";
				} else if (modelName == "Spyder") {
					modelName = "Regular";
				}
			}

			else if (swapPaint) {
				if (paintName == "Red") {
					paintName = "Yellow";
				} else if (paintName == "Yellow") {
					paintName = "Red";
				}
			}

			else if (swapWheels) {
				if (wheelsName == "Silver") {
					wheelsName = "Black";
				} else if (wheelsName == "Black") {
					wheelsName = "Silver";
				}
			}

			else if (swapInterior) {
				if (interiorName == "Tan") {
					interiorName = "Red";
				} else if (interiorName == "Red") {
					interiorName = "Tan";
				}
			}

			SwapFeatures();
			swapModel = swapPaint = swapWheels = swapInterior = false;
	    }
  }

  void OnGUI() {
		//A button press will result in the corresponding car feature to show
		if (GUI.Button (new Rect(0,30,35,40), "Model")) {
		  swapModel = true;
		}

		if (GUI.Button (new Rect(50,30,35,40), "Paint")) {
		  swapPaint = true;
		}

		if (GUI.Button (new Rect(100,30,35,40), "Wheels")) {
		  swapWheels = true;
		}

		if (GUI.Button (new Rect(150,30,35,40), "Interior")) {
		  swapInterior = true;
		}

		modelName = GUI.TextField (new Rect (0, 80, 35, 20), modelName, 25);
		paintName = GUI.TextField (new Rect (50, 80, 35, 20), paintName, 25);
		wheelsName = GUI.TextField (new Rect (100, 80, 35, 20), wheelsName, 25);
		interiorName = GUI.TextField (new Rect (150, 80, 35, 20), interiorName, 25);
	}
  
	private void SwapFeatures() {
	    GameObject trackableGameObject = theTrackable.gameObject;
	    
		//disable any pre-existing augmentation
	    for (int i = 0; i < trackableGameObject.transform.GetChildCount(); i++)
	    {
	      Transform child = trackableGameObject.transform.GetChild(i);
	      child.gameObject.active = false;
	    }
		
	    // Creates the new car object
		if(modelName = "Regular" && paintName == "Red" && wheelsName == "Silver" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Red" && wheelsName == "Silver" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Red" && wheelsName == "Black" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Red" && wheelsName == "Black" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Yellow" && wheelsName == "Silver" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Yellow" && wheelsName == "Silver" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Yellow" && wheelsName == "Black" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Regular" && paintName == "Yellow" && wheelsName == "Black" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Red" && wheelsName == "Silver" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Red" && wheelsName == "Silver" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Red" && wheelsName == "Black" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Red" && wheelsName == "Black" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Yellow" && wheelsName == "Silver" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Yellow" && wheelsName == "Silver" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Yellow" && wheelsName == "Black" && interiorName == "Tan"){
			GameObject newGameObject = GameObject.
		}
		else if(modelName = "Spyder" && paintName == "Yellow" && wheelsName == "Black" && interiorName == "Red"){
			GameObject newGameObject = GameObject.
		}
		else{
			Debug.Log("Menu Error!")
		}

		// Re-parent the cube as child of the trackable gameObject
	    newGameObject.transform.parent = theTrackable.transform;
	    // Adjust the position and scale
	    // so that it fits nicely on the target
	    newGameObject.transform.localPosition = new Vector3(0,0.2f,0);
	    newGameObject.transform.localRotation = Quaternion.identity;
	    newGameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
	    // Make sure it is active
		newGameObject.active = true;
	  }
}
