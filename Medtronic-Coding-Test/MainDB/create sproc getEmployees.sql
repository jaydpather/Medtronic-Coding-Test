CREATE PROCEDURE [dbo].[getEmployees]
AS
	select e.EmployeeId, e.FirstName, e.LastName, m.EmployeeId as ManagerId, m.FirstName as ManagerFirstName, m.LastName as ManagerLastName
	from Employee e 
	left join Employee m on m.Id = e.ManagerId
	order by e.LastName, e.FirstName
RETURN 0