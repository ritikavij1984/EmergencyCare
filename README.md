Installation Steps:
-	Download and extract the file
-	Open the .sln file
-	Go to sql database
-	Create a database name ‘emergency’
-	Run the hospital.sql script
-   Run the Test_data.sql script
-	Run the application from Visual Studio

Post configuration steps:
username and password for admin login
User Category: Administration
username - admin
password - admin

Assumptions:
- Admin role will have all the rights.
- Testing will be done by Nunit or manual testing using the test data provided.

Decription of the solution:
1. The solution has a login page with User Category to have different roles and rights.
2. After a user logins to the application he/she will be able to see 2 screens.
	- Bed Status to show the status of In use and Free beds.
	- Patient summary page
		2.1 On the left hand side of the page user can add information for a new patient and click register button to add pateint in database.
		
		2.2 Right hand side will show the Grid summary of all the patients, nurse, treatement, admit date and bed status details.
		
		2.3 At the bottom we have 4 buttons
		
		2.3.1 Home to go to the main page.
		2.3.2 Register to register a new patient based on data entered on the left section.
		2.3.3 Refresh button.
		2.3.4 Discharge button to discharge a patient and mark the bed status to free.
		
		2.4 On the top we have button click to diplay.
		2.4.1 Bed status and Count of patients admitted today, e.g if today is 10/Jan/2022 and 4 pairnts have been admitted on the same date it will show 4.
		  
