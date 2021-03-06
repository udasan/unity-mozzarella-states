﻿using UnityEngine;
using System.Collections;
using System.Linq; // for Concat()

public class GamePhaseEpilogueState : GamePhaseStateBase
{
	// add custom members
	
	protected override void Reset ()
	{
		base.Reset();
		
		// initialize base members
		stateName = "GamePhaseEpilogueState";
		exitByTime = new ExitByTime(0.0f, "");
		transitions = (new Transition[] {
			//new Transition("IsCommited", "NextStateName")
		}).Concat(transitions).ToArray();
		
		// initialize custom members
	}
	
	public override void OnStateUpdate ()
	{
		// someting to do before decision of doing transition or not
		
		base.OnStateUpdate();
	}
	
	public override void OnStateEnter ()
	{
		base.OnStateEnter();
		
		// something to do at entering this state
	}
	
	public override void OnStateExit ()
	{
		// something to do at exiting this state
		
		base.OnStateExit();
	}
	
	public override void OnStateStay ()
	{
		base.OnStateStay();
		
		// something to do while each Update()
	}
}
