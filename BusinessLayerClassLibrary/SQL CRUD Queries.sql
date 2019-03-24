SELECT TOP (1000) [EmpID]
      ,[EmpName]
      ,[EmpAge]
  FROM [chandu].[dbo].[EmployeeList]
  insert into [dbo].[EmployeeList] (EmpID,EmpName,EmpAge)
  values (2,'Teja',21)
  select *from [dbo].[EmployeeList]
  update [dbo].[EmployeeList]
  set EmpID=1 where EmpID=2;
  delete from [dbo].[EmployeeList] where EmpID=1