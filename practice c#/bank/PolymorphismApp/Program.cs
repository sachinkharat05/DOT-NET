using HR;

Employee emp= new Employee(5000,3000,300);
Manager mgr=new Manager(8000,5000, 1000,8000);
SalesManager salesmgr=new SalesManager(79999,5000,2300,8000,78000000,50000);

double empSal=emp.CalculateSalary();
double mgrSal=mgr.CalculateSalary();
double salesSal=salesmgr.CalculateSalary();


Employee superEmp=mgr;
superEmp.CalculateSalary();   //polymorphism



Console.WriteLine("Hello, World!");
