using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CArrowLockAt : MonoBehaviour {
	public Transform target;
	public Transform self;

	public float direction;
	public Vector3 u;

	float devValue = 10f;
	float showWidth;
	float showHeight;

	Quaternion originRot;

	// Use this for initialization
	void Start () {
		originRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			GetComponent<CArrowLockAt> ().enabled = false;
			gameObject.SetActive(false);
		}

		showWidth = transform.parent.GetComponent<RectTransform> ().rect.width / 2 - devValue;
		showHeight =transform.parent.GetComponent<RectTransform> ().rect.height / 2 - devValue;
		Vector3 forVec = self.forward;
		Vector3 angVec = (target.position - self.position).normalized;
		Vector3 targetVec = Vector3.ProjectOnPlane (angVec - forVec, forVec).normalized;
		Vector3 originVec = self.up;
		direction = Vector3.Dot (originVec, targetVec);
		u = Vector3.Cross (originVec, targetVec);
		direction = Mathf.Acos (direction) * Mathf.Rad2Deg;
		u = self.InverseTransformDirection (u);
		transform.rotation = originRot * Quaternion.Euler(new Vector3(0f, 0f, direction * (u.z > 0 ? 1 : -1)));
			Vector2 screenPos = Camera.main.WorldToScreenPoint (target.position);
			if (screenPos.x < devValue || screenPos.x > Screen.width - devValue || screenPos.y < devValue || screenPos.y > Screen.height - devValue || Vector3.Dot (forVec, angVec) < 0) {
				Vector3 result = Vector3.zero;
				if (direction == 0) {
					result.y = showHeight;
				} else if (direction == 180) {
					result.y = -showHeight;
				} else {
					float direction_new = 90 - direction;
					float k = Mathf.Tan (Mathf.Deg2Rad * direction_new);
					result.x = showHeight / k;
					if ((result.x > (-showWidth)) && (result.x < showWidth)) {
						result.y = showHeight;
						if (direction > 90) {
							result.y = -showHeight;
							result.x = result.x * -1;
						}
					} else {
						result.y = showWidth * k;
						if ((result.y > -showHeight) && result.y < showHeight) {
							result.x = result.y / k;
						}
					}
					if (u.z > 0)
						result.x = -result.x;
				}
				transform.localPosition = result;
			} else {
				transform.position = screenPos;
			}
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			GetComponent<CArrowLockAt> ().enabled = false;
			gameObject.SetActive(false);
		}
		}
}
