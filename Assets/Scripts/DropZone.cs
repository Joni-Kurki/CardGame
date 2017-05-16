using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	public void OnPointerEnter(PointerEventData eventData){
		if (eventData.pointerDrag == null)
			return;

		Draggable drag = eventData.pointerDrag.GetComponent<Draggable> ();

		if (drag != null) {
			drag.parentPlaceholder = this.transform;
		}
	}
	public void OnPointerExit(PointerEventData eventData){
		if (eventData.pointerDrag == null)
			return;
		
		Draggable drag = eventData.pointerDrag.GetComponent<Draggable> ();
		if (drag != null && drag.parentPlaceholder == this.transform) {
			drag.parentPlaceholder = drag.originalParent;
		}
	}
	public void OnDrop(PointerEventData eventData){
		//Debug.Log (eventData.pointerDrag.name +" was dropped to "+gameObject.name);

		Draggable drag = eventData.pointerDrag.GetComponent<Draggable> ();
		if (drag != null) {
			drag.originalParent = this.transform;
		}
	}
}
