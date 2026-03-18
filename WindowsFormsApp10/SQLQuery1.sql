create database aptech;


create table students(
id int primary key identity(1,1),
name varchar(50),
timing varchar(50),
course varchar(50),
days varchar(50)
);


select * from students;