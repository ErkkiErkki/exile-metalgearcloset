﻿using UnityEngine;
using System.Collections;

public class PlayDialogueEvent : StoryEvent
{
	[SerializeField]
	private AudioClip dialogueClip;

	[SerializeField]
	private MovingVoice whoIsTalking;

	public override void Trigger()
	{
		Debug.Log("talk:"+ this.dialogueClip.name, this);
		SoundManager.Instance.PlaySound(dialogueClip, whoIsTalking.transform, true, HandleSoundFinished);
	}

	private void HandleSoundFinished()
	{
		Debug.Log("done talking:"+ this.dialogueClip.name, this);
		OnDone(this);
	}
}
