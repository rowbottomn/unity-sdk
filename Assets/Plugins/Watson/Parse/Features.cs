﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Features : QuestionComponentBase {
	private List<FeatureItem> FeatureItems = new List<FeatureItem>();
	private ObservedList<string> m_FeatureData = new ObservedList<string>();
	
	void Start()
	{
		base.Start ();
		m_FeatureData.Added += onAdd;
	}
	
	private void onAdd()
	{
		Debug.Log ("feature added");
		FeatureItem featureItem = new FeatureItem ();
		FeatureItems.Add (featureItem);
		featureItem.m_feature = m_FeatureData [m_FeatureData.Count];
	}
}