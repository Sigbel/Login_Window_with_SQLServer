create database LoginWind

use LoginWind

create table Usuario
(
	ID INT IDENTITY PRIMARY KEY,
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
)

INSERT INTO Usuario (Username, Password) VALUES ('Adm', '123')

SELECT * FROM Usuario

UPDATE Usuario
SET Username='adm'
WHERE ID = 1