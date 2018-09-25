﻿namespace Milyli.ScriptRunner.Services.Interfaces.Models.Responses
{
	using System.Collections.Generic;

	public class ReadCaseScriptResponse
	{
		public int CaseId { get; set; }

		public string CaseName { get; set; }

		public List<ReadScriptResponse> CaseScripts { get; set; }
	}
}
