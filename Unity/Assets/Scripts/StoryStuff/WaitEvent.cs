﻿using UnityEngine;
using System.Collections;

public class WaitEvent : StoryEvent
{
	[SerializeField]
	private float waitingTime = 1;

	public override void Trigger()
	{
		StartCoroutine(Wait(waitingTime));
	}

	IEnumerator Wait(float t)
	{
		yield return new WaitForSeconds(t);
		IsDone = true;
	}
}