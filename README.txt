**********************************
***     DAB - Assignment 2     ***
***       EfCore Group 6       ***
**********************************
*** Online Help Request System ***
**********************************

Group-members:
- Mikkel Kousgaard Rasmussen 	(au610713)
- Jeppe Dybdal Larsen 		(au616966)

*********************************
******* HOW TO USE THE APP ******
*********************************

** 1. Set up database **
1.1 Open Solution "Assignment2-Group6.sln"
1.2 Set StartUp-project to "Assignment2-ASP_NET"
1.3 Open 'Package Manager Console' and set Default Project to "Assignment2-ASP_NET.Database"
1.4 Run Command "Update-Database" (This will update/create the local-database with the newest migration)
	- The connectionstring can be found in the file appsettings.json under "LocalDbConnection".
	- The string is: "Server=(localdb)\\mssqllocaldb;Database=HelpRequestDb;Trusted_Connection=True;MultipleActiveResultSets=true"

** 2. Run/Use the App **
2.1 Press "Ctrl F5" to run the app - the app will start on your localhost and redirect to the HomePage.
2.2 The HomePage presents to options:
	option-1: Populate database 	: This button seeds the database (Recommended option)
	option-2: Clear database	: This button clears/unseeds the database
2.3 Now you are free to use the app as you wish:
	- create entities (via "Create Entities")
	- browse the different views (via "Browse Views")

** Note **
- When browsing the Help Requests for (Teacher, Course), if no help requests is shown, 
its because the specific teacher doesnt have any help requests for the specified course.
Therefore try different combinations.

Also the dropdown-lists only shows the au-ids, therefore the teacher-name for each Id is specified here
Also there is given some examples of which course they have help-requests for.

* TEACHERS: *				* COURSES: *
****************************************************
- au000001 (Henrik Bitsch Kirk)		: DAB, GUI
- au000002 (Jung Min Kim)		: SWT
- au000003 (Lene Häuser Petersen)	: 
- au000004 (Poul Ejnar Rovsing)		: GUI, NGK
- au000005 (Michael Alrøe)		: NGK
- au000006 (Frank Bodholdt Jakobsen)	: SWT
- au000007 (Michael Sørensen Loft)	: GFV, SWD
- au000008 (Peter Høgh Mikkelsen)	: HAL, DOA
- au000009 (Jesper Rosholm Tørresø)	: DOA
- au000010 (Lars G. Johansen)		: DSB
- au000011 (Arne Justesen)		: GFV
- au000012 (Martin Ansbjerg Kjær)	: 
- au000013 (Per Lysgaard)		: 
- au000014 (Søren Hansen)		: ISU
- au000015 (Søren H. Nielsen)		: ISU



