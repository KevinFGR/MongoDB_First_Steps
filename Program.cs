﻿using MongoDB_First_Steps.Services;

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
