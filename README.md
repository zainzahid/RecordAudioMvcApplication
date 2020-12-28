# RecordAudioMvcApplication Instructions
- All the code for recording screen including javasscript is in the Formation View, inside (Views/Formation/index.cshtml)
- When click on the Save from Formation view it will send the POST request to send the file which will be recieved in (Controller/FormationController.cs) Save() Action under Request.Files
- CDN scripts for JS Libraries that are required for recording are defined in Shared/_Layout.cshtml
