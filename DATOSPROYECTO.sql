create Database DATOSPROYECTO;

use DATOSPROYECTO;

Create Table Tbl_UserList1(
Id int primary key identity,
NombreDonante varchar(50),
Direccion varchar(50),
Telefono int,
Edad int,
GrupoSanguineo varchar(50)

);

select * from Tbl_UserList1;
