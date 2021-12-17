# Single Use Agent
##### The single use agent will disconnect from MeshCentral when closed and or denied. The app will determine if the machine is 32bit and or 64bit and run the proper portable MeshCentral Agent within the background. An elevation prompt as been added and will re-run the agent with specified credentials if administrator access is needed to interact with an administrative window. 
## Setup
1. Navigate to MeshCentral and create a new group for the single use agents. Set the permissions/Notifications you need and or want after creation. In this case, we went for the “ScreenConnect” method and enabled Consent to Control. Generate an invite URL (Interactive Only) and navigate to the URL on your host machine. Download both the 64bit and 32bit executables needed. Upload both EXE’s to a web server of choice and adjust the names to your liking. 


2. Within the form “Form1”, adjust the URL’s to your mesh agent file’s recently uploaded. Then compile and upload the stub somewhere where user’s can download and launch. That’s it! If you wish to adjust logo’s and other settings, feel free to do this before compiling the source. 


![](https://nabyte.com/imgs/2e5c030b6c8ae2a4bd8f50a31f49487a1be7af72Capture.png)
#### Main Menu
![](https://nabyte.com/imgs/ba75a9d9c8bd4bbbe8de1b2b4048b8904b92a1c91.png)
#### Clicking Accept
![](https://nabyte.com/imgs/8aef39de6a49901523f3227047007a5261b570c72.png)
#### Connected
![](https://nabyte.com/imgs/58f3296789f6e258bf463516f7c160dadd9ff7353.png)
#### Elevate Permissions 
![](https://nabyte.com/imgs/e484958a058c26de6a88267f1e6577f136c714134.png)
#### Removing from MeshCentral when closed
![](https://nabyte.com/imgs/cf26421927f644edc47c14be52672ccbc72faa129f8b563484ee9433728cf8fbed11be05.gif)
