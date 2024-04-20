using MongoDB_First_Steps.Services.CRUD;
using MongoDB_First_Steps.Services.Aggregation;
// First of all verify the Connection/Connection.cs file where the connection with database is created
// and make the correct changes for use your DB

// For run Create
Create create = new Create();
await create.createUser();
await create.createManyUsers();

// // For run Read 
// Read read = new Read();
// await read.readCollection(); 

// // For run Update
// // Certify the document already exists before try Update
// Update update = new Update();
// await update.updateDocument();
// await update.updateManyDocuments();

// // For run Delete
// // Certify the document already exists before try exclude
// Delete delete = new Delete();
// // Certify if you are deleting the correct Id
// await delete.deleteDocument();
// await delete.deleteManyDocuments();

// // For Match Agregation
// Match match = new Match();
// match.match_aggregation();

// // For Group Aggregation
// Group group = new Group();
// await group.group_aggregation();

// // For Sort Aggregation
// Sort sort = new Sort();
// await sort.DescendSort();

// // For Project Aggregation
// Project project = new Project();
// await project.projecting();