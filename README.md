To get the backend started for Console testing:
1) First select the LanternsApp in the 'Select Startup Item' or Build options tab. 
2) Click play on your selection or build the solution.

In order to get the front end of this project to work on your computer first clone or select the proper branch then...

1) Insure that Node.js is installed
2) Run "npm install" in the "ClientApp" directory (\LanternsApp\LanternsApp\ClientApp)
3) Run npm start from the "ClientApp" directory

Note on File Structure: 
	LanternsApp:
		ClientApp:		Contains the React components/elements.
		Controllers:	Controllers folder contains class files for the controllers. Controllers 
						handles users' request and returns a response. MVC requires the name of all controller 
						files to end with "Controller".  
		Pages:			Contains various error messages and a viewimports.cshtml file.
		Properties:		Empty
		Root of LaternsApp: Appsettings, .gitignore, program.cs and start-up.cs 

