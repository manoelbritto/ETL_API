using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    /// <summary>
    /// This API allows you to retrieve the most recent data from Crimes that have happend
    /// in Toronto-Canada
    /// </summary>
    public class CrimesController : ApiController
    {

        //object created from Entity FrameWork class
        generalDBEntities contextDB = new generalDBEntities();
        /// <summary>
        /// Get API to return all crime data
        /// </summary>
        /// 
        /// <returns>returns all the data from crimes in Toronto</returns>
        // GET: api/Crimes
        public List<Homicide> Get()
        {
            List<Homicide> listValue = new List<Homicide>();

            var values = contextDB.spAllValue();


            foreach (var item in values)
            {
                listValue.Add(new Homicide
                {
                    City = item.City,
                    Country = item.Country,
                    Division = item.Division,
                    ID = item.ID,
                    Event_Unique_ID = item.Event_Unique_ID,
                    Homicide_Type = item.Homicide_Type,
                    Lat = item.Lat,
                    Long = item.Long,
                    Hood_ID = item.Hood_ID,
                    Neighbourhood = item.Neighbourhood,
                    Occurrence_Date = item.Occurrence_Date,
                    Occurrence_year = item.Occurrence_year
                });
            }
            return listValue;
        }
        /// <summary>
        /// Get API to return data base on the type(id) that you pass
        /// </summary>
        /// <param name="id">
        /// Shooting, Stabbing or Other
        /// </param>
        /// <returns>
        /// Returns just the value that you filtered out
        /// </returns>
        // GET: api/Crimes/id
        public List<Homicide> Get(string id)
        {
            List<Homicide> listValue = new List<Homicide>();

            var query = contextDB.spFilterValue(id); // procedure inside database
            //Linq sintax
            //var query = from c in contextDB.Homicides
            //            where c.Homicide_Type.Equals(type)
            //            orderby c.Homicide_Type descending
            //            select c;

            foreach (var item in query)
            {
                listValue.Add(new Homicide
                {
                    City = item.City,
                    Country = item.Country,
                    Division = item.Division,
                    ID = item.ID,
                    Event_Unique_ID = item.Event_Unique_ID,
                    Homicide_Type = item.Homicide_Type,
                    Lat = item.Lat,
                    Long = item.Long,
                    Hood_ID = item.Hood_ID,
                    Neighbourhood = item.Neighbourhood,
                    Occurrence_Date = item.Occurrence_Date,
                    Occurrence_year = item.Occurrence_year
                });
            }
            return listValue;
        }


    }
}
