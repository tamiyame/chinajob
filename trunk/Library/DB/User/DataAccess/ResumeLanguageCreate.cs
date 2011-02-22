using System;
using System.Data;
using System.Collections.Generic;

using Com.Framework.Data;
using Com.Library.DB;

namespace Com.Library.DB.User
{
    public class ResumeLanguageCreate : DBDataReader<DataEntity, DataEntity>
    {
        public ResumeLanguageCreate()
            : base(new ConnectionString(), "TSP_ResumeLanguageCreate")
        {
        }

        protected override void ParameterInitialize()
        {
            AddParameter("ResumeNo", SqlDbType.Int, 4, SqlDataInOut.Input);
            AddParameter("LanguageName", SqlDbType.NVarChar, 40, SqlDataInOut.Input);
            AddParameter("TestDesc", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("GradeDesc", SqlDbType.NVarChar, 200, SqlDataInOut.Input);
            AddParameter("ConversationLevel", SqlDbType.TinyInt, 1, SqlDataInOut.Input);

            AddParameter("ResumeLanguageNo", SqlDbType.Int, 4, SqlDataInOut.Output);
        }
    }
}