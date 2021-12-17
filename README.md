# Tactical RMM Client and Tools
Tactical RMM Chromium client using CefSharp and tools for easy access. Tool's include a single use agent for easy remote access paired with MeshCentral.

###### Please note Tactical RRM is NOT created by me. These are 3rd party apps used/created that are in no way linked and or supported by the Tactical RMM team. These tools are for simplicity and my way of using the RMM toolset efficiently and effectively without the need of having multiple browser tab’s open. If you have any questions and or issues, feel free to submit an issue within the repository. Please note this was created not with the intention of other individuals other than my own clientele. 

###### WhY ViSuAl BaSiC - Because I can. 

### The single use agent. 
The single use agent was created as a method of a user navigating to a webpage ex. https://example.com/remote then running the client with self-branded logo’s and usability/simplicity. The client itself is a stub and does not have any of MeshCentral’s code within the executable. The stub check’s for a 32bit and or 64bit machine then downloads the respective portable agent generated form MeshCentral. Please note if you compile, you will have to create your own agents and link them within the URL string on the main Form. Another reason this agent was created was the aspect of elevating permissions as needed, similar to ScreenConnect. Once compiled, click the “gear” Icon shown within the main UI and type administrative credentials to re-launch/elevate. 

### The RMM Client
The client was created to have your employees simply launch the “Application” and remain signed in/and having a visible System Tray icon with multiple tools and methods of switching back and forth to the MeshCentral client and Tactical RMM. Simply put, a cleaner and clutter free way of keeping the client open without having a browser tab utilized. 
