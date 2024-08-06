﻿using InternViewServer.Models.DAL;

namespace InternViewServer.Models
{
    public class Surgeries
    {
        public int Surgery_id { get; set; }

        public int Case_number { get; set; }

        public int Patient_age { get; set; }

        public DateTime Surgery_date { get; set; }
        public int Difficulty_level { get; set; }

        public string Hospital_name { get; set; }
        static public List<Dictionary<string, object>> GetAllSurgeriesWithProcedures()
        {
            DBservices dbs = new DBservices();
            return dbs.GetAllSurgeriesWithProcedures();
        }
        //static public List<Dictionary<string, object>> GetAllSurgeries()
        //{
        //    DBservices dbs = new DBservices();
        //    return dbs.GetAllSurgeries();
        //}
        static public List<Surgeries> GetSurgeriesByID(int surgeryID)
        {
            DBservices dbs = new DBservices();
            return dbs.GetSurgeriesByID(surgeryID);
        }

        //static public List<Dictionary<string, object>> GetFutureSurgeries()
        //{
        //    DBservices dbs = new DBservices();
        //    return dbs.GetFutureSurgeries();
        //}

        static public List<Dictionary<string, object>> GetSurgeryRoles(int surgery_id)
        {
            DBservices dbs = new DBservices();
            return dbs.GetSurgeryRoles(surgery_id);
        }

        //for algorithm
        static public List<Surgeries> GetSurgeriesByTime(string startDate, string endDate)
        {
            DBservices dbs = new DBservices();
            return dbs.GetSurgeriesByTime(startDate , endDate);
        }

        static public List<int> GetProceduresOfSurgery(int SurgeryId)
        {
            DBservices dbs = new DBservices();
            return dbs.GetProceduresOfSurgery(SurgeryId);
        }
        //for algorithm
    }
}
