// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
Console.WriteLine("Hello, World!");
UC1_EmployeeAttendance.EmployeeAttendance();
UC2_EmployeeWage.EmployeeWage();
UC3_PartTimeEmployeeWage.EmployeeWage();
UC4_EmpWageUsingSwitch.EmployeeWage();
UC5_EmpWageFor20WorkingDays.EmpWageFor20Days();
UC6_EmpWageForMax100Hrs.EmpWageForMax100Hrs();
UC7_EmpWageUsingClsasMethod.ComputeEmpwage();
UC8_EmpWageForMultipalCompany.ComputeEmpwage("DMart", 20, 2, 10);
UC9_EmpWageBuilderObject DMart = new UC9_EmpWageBuilderObject("DMart", 20, 2, 10);
UC9_EmpWageBuilderObject Reliance = new UC9_EmpWageBuilderObject("Reliance", 10, 4, 20);
DMart.ComputeEmpWage();
Console.WriteLine(DMart.toString());
Reliance.ComputeEmpWage();
Console.WriteLine(Reliance.toString());