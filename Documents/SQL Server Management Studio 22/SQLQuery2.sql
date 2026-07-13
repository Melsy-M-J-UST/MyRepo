create database employeedb;
use employeedb
select name from sys.database

create table employees (
id int primary key identity,
name nvarchar(80) not null,
gender varchar(30) check(gender in('Male','Female','male','female')),
age int check(age between 18 and 60),
salary decimal);

insert into employees values('Marks', 'Male', 44, 23450);
insert into employees values('Abcd', 'Female', 23, 20045);
insert into employees values('Mia', 'female', 32, 2009800);
insert into employees values('Spark', 'female', 29, 203450);
insert into employees values('Crack', 'male', 34, 26780);
insert into employees values('Markss', 'female', 48, 65490);

select * from employees where gender='Male';
select * from employees where salary>=200;
update employees set salary=50000, age=34 where id=5;
update employees set salary=salary+3000;
delete employees where id=6;
delete from employees where id=4;
select * from employees where name like 'M%';
select * from employees where name like '_a%';
alter table employees add Department varchar(30);
select * from employees;
update employees set Department='IT' where id=1 or 8;
update employees set Department='IT' where id in (1,8);
select * from employees where Department is null;
select * from employees where Department is not null;
alter table employees drop column department;
exec sp_help employees;
drop table employees;


create table Department( id int primary key identity, department_name nvarchar(50));
insert into Department values('HR');
insert into Department values('Finance');
insert into Department values('Production');
insert into Department values('Store');
insert into Department values('Canteen');
insert into Department values('Hi');
insert into Department values('Fine');

create table employee( id int primary key identity, name nvarchar(50), gender nvarchar(50), age int, salary decimal, doj date, dept_id int references department(id));
constraint fk_department
insert into employee values('Anu','female',35,23450,'2026-03-03', 6);
insert into employee values('Anusree','female',32,56750,'2026-03-03', 5);
insert into employee values('Anu','female',23,36660,'2026-03-03', 3);
insert into employee values('Anunandha','female',23,7877650,'2026-03-03', 3);
insert into employee values('Anupriya','female',33,2340,'2026-03-03', 1);
insert into employee values('Anupama','female',44,237550,'2026-03-03', 1);
insert into employee values('Anuradha','female',55,5660,'2026-03-03', 1);


select name, salary, department_name from employee e join Department d on e.dept_id=d.id;
inner join == join
left join returns all from left
right join returns all from right
full join returns left +right

left/ left outer join for the above 3


Aggregate functions
select Max(Salary) from employee
Min
Avg
Sum
Count

select Department.id, sum(salary) from employee;
group by department.id having sum(salary)>=7000;
where restricting rows
having restricts groups

select * from employee where salary=(select Max(salary) from employee);
select * from  employee order by salary desc;
select * from  employee order by name , salary desc;

begin transaction

delete from employee;
rollback transaction

commit transaction

sqlcmd -S localhost -U ___ -P   ___

truncate table employee

start transaction in cmd

create procedure Greet as begin

Print 'Hello'



end;


execute Greet;
exec Greet;
alter procedure Greet as begin

Print 'Hello World'



end;


execute Gret;
exec Greet;
create procedure
Empl as begin
select stmts
end;
exec Empl


create procedure sp_GetEmplBYID @id int
as
begin
	select * from employee where id=@id

end;

exec sp_GetEmplBYID 1;
exec sp_GetEmplBYID









sp_help employee;
alter table employee drop column dept_id













create procedure addEmployee
@Name nvarchar(50), gender nvarchar(10). @age int 
@salary decimal(10,2), @deptId int 

as begin
insert into employee values(@Name,@___,@____);
select * from employee;
exec AdddEmployee('Anu','Female',25000,32);
if order changed should specify the variableswith@


create procedure UpdateEmployee @Id int, Salary decimal, @empId int as begin

update employee set salary=@salary, dept_id=@id where id=@empId;
end;


exec UpdateEmployee 1,75677,2;

select * from employees;

,

create procedure GetSalaryById @Id int , @salary decimal output
as
begin
select @salary=salary from employees where Id=@id;
end;
declare @sal decimal;
exec GetSalaryById 1,@sal output;
print 'Salary is '+cast(@sal as varchar);
@sal=exec GetSalaryById 

create procedure DeleteEmployee @id int
as
begin
if not exists (select 1 from Employee where id=@id)
begin
Raiserror ('Employee with id %d does not exist.', 16,1,@Id)
--Raiserror('display statement',1-25 severity,status 1-5, )
end
else
begin
	delete from employee where id=@id
	print 'Employee eith id'+ cast(@Id as varchar) + 'has been deleted'
	end
	end;

	select * from employees

	exec DeleteEmployee @Id =11
	exec DeleteEmployee @Id =7


	begin try
		exec DeleteEmployee @Id =23
	end try
	begin catch
	print 'Error:'+error_message()
	print 'error State: ' + cast(error_state() as varchar)
	print 'error severity '+ cast(error_severity() as varchar)
	end catch



create procedure PrintNtimes @N int
as
begin
	declare @counter int =0;
	while @counter<@N
	begin
	print 'Hello World!!';
	set @counter=@counter+1;
	end 
end;

exec PrintNtimes 3;



select * into employeebackup from employee where 1=2; --1==2 will always be false thus only structure will be created


create trigger employeebackuptrigger
on employee
after insert as
begin
	select * into employeebackup from inserted
	-- inserted and deleted are magic tables in trigger and it works only after successful insertions
	--only applicable inside the trigger and updations happen like inserted after deleted
	print'data inserted';

end;

alter trigger employeebackuptrigger
on employee
after insert as
begin
	select * into employeebackup values(@inserted.id, @inserted.name, @inserted.gender, @inserted.salary, @inserted.DEpt_id)
	
	-- inserted and deleted are magic tables in trigger and it works only after successful insertions
	--only applicable inside the trigger and updations happen like inserted after deleted
	print'data inserted';

end;

alter trigger employeebackuptrigger
on employee
after insert as
begin
	select * into employeebackup from inserted
	
	-- inserted and deleted are magic tables in trigger and it works only after successful insertions
	--only applicable inside the trigger and updations happen like inserted after deleted
	print'data inserted';

end;

sp_help employee;
insert into employee values(12,'Chaaru','Female', 50000,2);


--view virtual table
select * from employee


create view employeeView as 
select id, name, gender, dept_id from employee;
select * from employeeView;

insert into employeeView values('Suma', 'Female',1);
select * from employee;
-- columns in the table that are not in the view must be nullable

-- to perform ddl, dml stmts, the view must be created from 1 table only




alter view employeeView as 
select id, name, gender, dept_id from employee where gender='Male' with check option;
select * from employeeView;
insert into employeeView values('Anna','Female',2);
insert into employeeView values('Anna','Male',2);