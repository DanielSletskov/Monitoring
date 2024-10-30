### Goal for solution
Return text from azure database to the web application</br>
</br>
__Logging:__ </br> 
</br>
Logging is done using 
</br>
Using system and system.io </br>
</br>
__Tracing:__ </br>
Tracing is done using system diagnosticss
</br>
__Assignment goal__ </br>
I triec to replicate what i have used ment handeling logging.</br>
This is setup so all actions is writen af saved in a folder of text documents. 
</br>
For tracing I tried to implemnt it in a try catch setup. </br> 
So it writes when the application or funtion startes and when it ends.   
</br>
__Database setup__ </br>
Eventhoug I didnt get to the flow thor my applicaition i stil got a local database set up using docker. </br>
This was done by first pulling the artfact provided by microsoft with the command __docker pull mcr.microsoft.com/mssql/server:2019-latest__ docker pull mcr.microsoft.com/mssql/server:2019-latest </br>
And after that I ran the docker run command. </br> 
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 --name sqlserver --hostname sqlserver -d mcr.microsoft.com/mssql/server:2019-latest__  docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 --name sqlserver --hostname sqlserver -d mcr.microsoft.com/mssql/server:2019-latest </br>  </br>
Afterward I was able to access the local databaseenging using localhostas servername, sa as login and the string as yourStrong(!)Password </br>
