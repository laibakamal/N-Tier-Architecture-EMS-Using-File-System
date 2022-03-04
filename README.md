EAD Lecture 1
N tier architecture 

Main --> Presentation Layer --> Business Logic Layer --> Data Access Layer


Employee info is saved to the file. And is read from the file. Json serialization is used.

Main:
    1- In main project, we create an object of "employee view" of presentation layer and call its function input data.
    
In Presentation Layer, 
    1- created Employeeview (user view). 
    2- In EmployeeView, asked the user to input employee info. 
    3- Then, created a business object to communicate between the layers. 
    4- Then, created an object of EmployeeManager of Business Logic Layer. It is further upto business logic layer to          save the info to the file. (called the function of employee manager)
    5- Finally, used the function of EmployeeManager to print the info of all employees.
    
In Business Logic Layer,
    1- There is a function which takes a business object (employee) as input, calculates tax for that employee and            then stores that employee in file USING AN OBJECT OF FILE HANDLING CLASS OF DATA ACCESS LAYER.
    2- There is another function, which uses a file handling object and calls a function of file handling class which           returns a list of employees read from the file. Then we iterate this list to print all employees.
   
In Data Access Layer,
    1- There is a function save employee which takes a business object (employee) as input and saves it to the file             using json serialization.
    2- There is another function "Read all employees from file" which uses json serialization to read employees from            file and add them to the list. finally, this function returns the list.

Business Object: 
    1- Employee business object class created.
    2- properties of employee created.
    3- there is a function which prints the employee info of its calling object.
    
    
    
