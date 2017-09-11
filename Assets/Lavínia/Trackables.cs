using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class Trackables : MonoBehaviour {
	private string mylog;
	// Update is called once per frame
	void Update () {
		// Get the StateManager
		StateManager sm = TrackerManager.Instance.GetStateManager ();

		// Query the StateManager to retrieve the list of
		// currently 'active' trackables 
		//(i.e. the ones currently being tracked by Vuforia)
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

		// Iterate through the list of active trackables
		//Debug.Log ("List of trackables currently active (tracked): ");
		//int numFrameMarkers = 0;
		//int numImageTargets = 0;
		//int numMultiTargets = 0;
		//int numObjectTargets = 0;
		//foreach (TrackableBehaviour tb in activeTrackables) {
		//Debug.Log("Trackable: " + tb.TrackableName);

		//if (tb is MarkerBehaviour)
		//numFrameMarkers++;
		//else if (tb is ImageTargetBehaviour)
		//numImageTargets++;
		//else if (tb is MultiTargetBehaviour)
		//numMultiTargets++;
		//else if (tb is ObjectTargetBehaviour)
		//numObjectTargets++;
		//}

		//Debug.Log ("Found " + numFrameMarkers + " frame markers in curent frame");

		bool framemarker1 = false;
		bool framemarker0 = false;
		bool framemarker2 = false;
		bool framemarker3 = false;
		bool framemarker4 = false;
		bool framemarker5 = false;
		bool framemarker6 = false;
		bool framemarker7 = false;
		foreach (TrackableBehaviour tb in activeTrackables) {
			if (tb.TrackableName.Equals ("FrameMarker1"))
				framemarker1 = true;
			else if (tb.TrackableName.Equals ("FrameMarker0"))
				framemarker0 = true;
			else if (tb.TrackableName.Equals ("FrameMarker2"))
				framemarker2 = true;
			else if (tb.TrackableName.Equals ("FrameMarker3"))
				framemarker3 = true;
			else if (tb.TrackableName.Equals ("FrameMarker4"))
				framemarker4 = true;
			else if (tb.TrackableName.Equals ("FrameMarker5"))
				framemarker5 = true;
			else if (tb.TrackableName.Equals ("FrameMarker6"))
				framemarker6 = true;
			else if (tb.TrackableName.Equals ("FrameMarker7"))
				framemarker7 = true;
		}

		if (framemarker1 && framemarker0) {
			Debug.Log ("Par numero 1 foi achado");
			mylog = "Par numero 1 foi achado";
		}
		if (framemarker2 && framemarker3) {
			Debug.Log ("Par numero 2 foi achado");
			mylog = "Par numero 2 foi achado";
		}
		if (framemarker4 && framemarker5) {
			Debug.Log ("Par numero 3 foi achado");
			mylog = "Par numero 3 foi achado";
		}
		if (framemarker6 && framemarker7) {
			Debug.Log ("Par numero 4 foi achado");
			mylog = "Par numero 4 foi achado";
		}
		if (framemarker1 && framemarker0 && framemarker2 && framemarker3 && framemarker4 && framemarker5 && framemarker6 && framemarker7) {
			Debug.Log ("Todos os pares foram encontrados");
			mylog = "Todos os pares foram encontrados";
		}
		}

	void OnGUI()
	{
		//if (!Application.isEditor) //Do not display in editor ( or you can use the UNITY_EDITOR macro to also disable the rest)
		{
			mylog = GUI.TextArea(new Rect(10, 10, Screen.width - 500, Screen.height - 500), mylog);
		}
	}
}