﻿using System;
using UnityEngine;

namespace ILib.GoogleApis
{
	[Serializable]
	public class ClearResponse
	{
		[SerializeField]
		string spreadsheetId;
		public string SpreadsheetId => spreadsheetId;

		[SerializeField]
		string clearedRange;
		public string ClearedRange => clearedRange;
	}
}