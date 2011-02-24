using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Library.Translate
{
	public class TranslateEntity
	{
		public TranslateEntity(string transCode, string krText, string cnText)
		{
			TransCode = transCode;
			KrText = krText;
			CnText = cnText;
		}

		public string TransCode { get; set; }
		public string KrText { get; set; }
		public string CnText { get; set; }
	}
}
