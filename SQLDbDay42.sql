create database Studentdb
use Studentdb
create table StudentTable
(Id int primary key,
SName nvarchar(50) not null,
Age datetime not null,
Course nvarchar(50),
Email nvarchar(200) not null,
Contact varchar(10))
insert into StudentTable values (1,'sam','12/10/1999','dotnet','sam@gmail.com','2345678912'),
(2,'eisha','11/10/1998','dotnet','eisha@gmail.com','2345678563'),
(3,'harish','12/01/2002','java','hr@gmail.com','2563456771'),
(4,'fawad','12/10/2004','Mvc','fawad@gmail.com','2345678890')
select * from StudentTable
