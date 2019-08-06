# Project: Track crimes in Toronto-CA
This Project combines ETL using SSIS to extract data from a CSV file. Also, a WEB API developed in .NET to expose the data in JSON format. Besides, with the JSON results is possible to create analysis or another sort of developments, for instance, a mobile app to track dangers areas based on GPS location.  
#Technology used in this project:
Microsoft Azure Cloud:
	SQL SERVER
	WEB APP
Local Machine:
ETL with SSIS integrated with SQL Server in the Cloud
Web app integrated with Azure Cloud
# Data Set
Data comes from the Toronto Police
https://data.torontopolice.on.ca/pages/homicide

# Workflow

 ![GitHub Logo](/Screenshots/workflow.png)

 
# ETL – SSIS (Sql Server Integration Service)	
> Control Flow


![GitHub Logo](/Screenshots/control_flow.png)


1. Execute SQL Task, it will execute my SQL command, in this case, a truncate table
2. ETL_CSV Import that runs a data flow below
3. In case of success, then File System Task will run. This task will move a .csv file to a different folder
4. In case of fail, then Send Mail Task with an error message

> Data Flow

![GitHub Logo](/Screenshots/data_flow.png)

1. Flat file Source will read the CSV file
2. Script Component will do some changes, in this case, it will fill in the columns City and Country because those columns don’t have inside the CSV file
3. ADO.NET Destination, it connects with SQL Server on the Cloud and integrates the content extracted from CSV file

> SQL Server results:

![GitHub Logo](/Screenshots/db_result.png)


> Web app front end:
https://manoelburgos.azurewebsites.net/
 
![GitHub Logo](/Screenshots/webapi_front.PNG)

> API page with features

![GitHub Logo](/Screenshots/doc_api.png)
 

## How to call a GET method:
> url/api/Crimes

> http://manoelburgos.azurewebsites.net/api/Crimes

> Postman results:

![GitHub Logo](/Screenshots/get_crimes.png)

url/api/Crimes/{id}

> http://manoelburgos.azurewebsites.net/api/Crimes/Other

> http://manoelburgos.azurewebsites.net/api/Crimes/Shooting

> http://manoelburgos.azurewebsites.net/api/Crimes/Stabbing

> Postman results:
![GitHub Logo](/Screenshots/get_crimes.png)

# Prerequisites 
This a list of application that you need to have in your machine:
Visual Studio 2017 Community or higher
Visual Studio 2017 SSDT or higher
SQL Server Management Studio 2017 or higher
Postman app to test the GET methods 
Also, you need to have a Microsoft Azure account. Then, on your Cloud environment, you can create SQL Server database and Web APP server



# Coding tips
In my WEB API development, I installed the Entity Framework package. And I created some procedures inside the database to be called inside the development

A class that react when you call a GET METHOD
```
// GET: api/Crimes
 public List<Homicide> Get()
        {
            List<Homicide> listValue = new List<Homicide>();
            //call a database procedure
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

```
## Features

1 . C# .NET
2. T-SQL
3. SSIS
4 . RESTFULL API

