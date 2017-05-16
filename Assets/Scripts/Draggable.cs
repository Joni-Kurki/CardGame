using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform originalParent = null;
	public Transform parentPlaceholder = null;
	public GameObject cardPlaceholder = null;
	Vector3 startDragPos;

	public void OnBeginDrag( PointerEventData eventData){
		//Debug.Log ("OnBeginDrag");

		startDragPos = Input.mousePosition;

		cardPlaceholder = new GameObject ();
		cardPlaceholder.transform.SetParent(this.transform.parent);
		LayoutElement le = cardPlaceholder.AddComponent<LayoutElement> ();
		le.preferredWidth = this.GetComponent<LayoutElement> ().preferredWidth;
		le.preferredHeight = this.GetComponent<LayoutElement> ().preferredHeight;
		le.flexibleWidth = 0;
		le.flexibleHeight = 0;

		cardPlaceholder.transform.SetSiblingIndex (this.transform.GetSiblingIndex());

		originalParent = this.transform.parent;
		parentPlaceholder = originalParent;
		this.transform.SetParent (this.transform.parent.parent);

		this.GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData){
		this.transform.position = eventData.position;
		int newSiblingIndex = parentPlaceholder.childCount;
		if (cardPlaceholder.transform.parent == parentPlaceholder)
			cardPlaceholder.transform.parent.SetParent (parentPlaceholder);
		for (int i=0; i < parentPlaceholder.childCount; i++) {
			if (this.transform.position.x < parentPlaceholder.GetChild (i).position.x) {

				newSiblingIndex = i;
				if (cardPlaceholder.transform.GetSiblingIndex () < newSiblingIndex)
					newSiblingIndex--;
				break;
			}
		}
		cardPlaceholder.transform.SetSiblingIndex (newSiblingIndex);

	}

	public void OnEndDrag(PointerEventData eventData){
		//Debug.Log ("OnEndDrag");
		this.transform.SetParent(originalParent);
		this.transform.SetSiblingIndex (cardPlaceholder.transform.GetSiblingIndex ());
		this.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		Destroy(cardPlaceholder);
	}
}
