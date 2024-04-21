# MongoDB_First_Steps
A Repository of all scripts i'm using to learn MongoDB

![mongo](https://github.com/KevinFGR/MongoDB_First_Steps/assets/109561598/3768dbac-c5fb-43ea-a4e5-2d94648e1e36)

## What operations you can run?
<ul>
  <li>CRUD</li>
  <ul>
    <li>Create</li>
    <li>Read</li>
    <li>Update</li>
    <li>Delete</li>
  </ul>
  <li>Aggregations</li>
  <ul>
    <li>Match</li>
    <li>Group</li>
    <li>Sort</li>
    <li>Projection</li>
  </ul>
</ul>

## How can I run the code?
<ul>
  <li>instal .NET 7</li>
  <li>Create an <a href="https://account.mongodb.com/account/login">Atlas</a> Cluster, Project and a Collection. 
      <p>Atlas is a Cloud DBMS for MongoDB</p>
  </li>
  
  <li>Certify your network accesss and connection string at Atlas.</li>
  
  <li>Fork this repositóry
  

      git clone https://github.com/KevinFGR/MongoDB_First_Steps.git

  </li>
    
  <li>Change the db_name tha is passed as the parameter of connectDb method in the contructor at the Connection/Connection.cs </li>
  
  <li>Also change the connection string and the collectionDB name at Connection.cs to your currently DB</li>
  
  <li>Check the Program.cs and uncoment what operations you want to run</li>
  
  <li>Open your command line at the same directory that Program.cs is and type

      dotnet run
  </li>
</ul>

## Possible Exceptions
<ul>
  <li>bad Auth: It means there's something wrong with your connection string, verify you you inserted your nickName and Password correctly.</li>
  <li>Check if you inserted your network IP at Atlas network access, otherwise Atlas won't let your computer access the DB by code.</li>
</ul>
