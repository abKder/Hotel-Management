CREATE TABLE Client_table(
Client_Id INT IDENTITY(1,1),
Client_name VARCHAR(30),
Client_email VARCHAR(30),
Client_nid VARCHAR(20),
Client_phone VARCHAR(20),
Client_roomType VARCHAR(10),
Client_roomNo VARCHAR(10),
Client_in VARCHAR(10),
Client_out VARCHAR(10),
PRIMARY KEY(Client_Id)
);