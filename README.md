To get the backend started for Console testing:
1) Make sure you open the Visual studio LaternApp solution, not the folder. 
2) Select the LanternsApp in the 'Select Startup Item' or Build options tab.
3) Click play on your selection or build the solution.


In order to get the front end of this project to work on your computer first clone or select the proper branch then...

1) Insure that Node.js is installed
2) Run "npm install" in the "ClientApp" directory (\LanternsApp\LanternsApp\ClientApp)
3) Run npm start from the "ClientApp" directory


Using JsonConvert.SerializeObject(object) requires Newtonsoft.json.


Note on File Structure: 
		LanternsApp:
		ClientApp:		Contains the React components/elements.
		Controllers:		Controllers folder contains class files for the controllers. Controllers 
					handles users' request and returns a response. MVC requires the name of all controller 
					files to end with "Controller".  
		GameData:		36 Lake Tile descriptions.
		Models:			Classes, interfaces, services and utilities. 
		Pages:			Contains various error messages and a viewimports.cshtml file.
		Properties:		Empty
		Root of LaternsApp: Appsettings, .gitignore, program.cs and start-up.cs 

