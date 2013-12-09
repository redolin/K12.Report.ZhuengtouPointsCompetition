﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K12.Report.ZhuengtouPointsCompetition.ValueObj
{
    public class DemeritsVO
    {
        private Dictionary<SchoolYearSemester, List<Data.DemeritRecord>> DemeritsBySchoolYear = new Dictionary<SchoolYearSemester,List<Data.DemeritRecord>>();

        public void AddDemerit(Data.DemeritRecord rec)
        {
            ValueObj.SchoolYearSemester SchoolYearSemester = new ValueObj.SchoolYearSemester(rec.SchoolYear, rec.Semester);
            if (!DemeritsBySchoolYear.ContainsKey(SchoolYearSemester))
                DemeritsBySchoolYear.Add(SchoolYearSemester, new List<Data.DemeritRecord>());
            DemeritsBySchoolYear[SchoolYearSemester].Add(rec);
        }

        public List<Data.DemeritRecord> GetDemeritsBySchoolYear(SchoolYearSemester schoolYearSemester)
        {
            if (DemeritsBySchoolYear.ContainsKey(schoolYearSemester))
                return DemeritsBySchoolYear[schoolYearSemester];
            else
                return new List<Data.DemeritRecord>();
        }
    }
}
