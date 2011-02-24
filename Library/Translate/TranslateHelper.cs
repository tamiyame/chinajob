using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace Com.Library.Translate
{
	public class TranslateHelper
	{
		public enum ContryCode
		{
			KR = 1,
			CN = 2
		}

		private TranslateHelper()
		{
		}

		static TranslateHelper()
		{
			Initialize();
		}

		private static bool isBeingInitialize = false;
		private static Dictionary<string, TranslateEntity> translateData = null;
		private static List<TranslateEntity> translateDataList = null;

		private static void Initialize()
		{
			if (!isBeingInitialize)
			{
				isBeingInitialize = true;

				List<TranslateEntity> initData = new List<TranslateEntity>();
				// 번역코드 추가
				initData.Add(new TranslateEntity("test", "테스트", "太水土"));

				// 딕셔너리에 저장
				translateData = new Dictionary<string, TranslateEntity>();
				translateDataList = new List<TranslateEntity>();

				foreach (TranslateEntity entity in initData)
				{
					if (!translateData.Keys.Contains(entity.TransCode))
					{
						translateData.Add(entity.TransCode, entity);
						translateDataList.Add(entity);
					}
					else
					{
						throw new Exception("TransCode is duplicate");
					}
				}

				isBeingInitialize = false;
			}
		}

		public static string GetText(ContryCode contryCode, string transCode)
		{
			TranslateEntity entity = null;
			
			if (!translateData.Keys.Contains(transCode))
			{
				throw new Exception("transCode not found");
			}

			entity = translateData[transCode];

			string retVal = string.Empty;

			switch (contryCode)
			{
				case ContryCode.KR :
					retVal = entity.KrText;
					break;
				case ContryCode.CN :
					retVal = entity.CnText;
					break;
				default :
					throw new Exception("contryCode not found");
			}

			return retVal;
		}

		public static List<TranslateEntity> GetList()
		{
			return translateDataList;
		}

	}
}
