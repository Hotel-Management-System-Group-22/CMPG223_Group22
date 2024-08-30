CREATE TABLE Job (
    Job_ID      	int             IDENTITY(1, 1) PRIMARY KEY,
    Job_Title  	varchar(50),
    Job_Rate    smallmoney          
);

CREATE TABLE Employee (
    Employee_ID		int	IDENTITY(1, 1) PRIMARY KEY, 
    Job_ID	int		FOREIGN KEY REFERENCES JOB(Job_ID),
    Employee_FName	varchar(30),
    Employee_LName	varchar(30),
    Employee_Username	varchar(30),
    Employee_Password	varchar(12),
    Is_Admin_YN		bit,
    Is_Clerk_YN		bit
);

CREATE TABLE ROOM(
  Room_ID 		int 	IDENTITY(1,1) PRIMARY KEY,
  Employee_ID 	int 	FOREIGN KEY REFERENCES EMPLOYEE(Employee_ID ) ,
  Room_Status 	bit ,
  ) ;


CREATE TABLE Guest (
    Guest_ID                           int            IDENTITY(1, 1) PRIMARY KEY, 
    Guest_FName                   varchar(30) ,
    Guest_LName                   varchar(30) ,
    Guest_ContactNo              varchar(10),
    Guest_Email                      varchar(50)
);

CREATE TABLE Booking (
    Booking_ID           	int              IDENTITY(1, 1) PRIMARY KEY,
    Guest_ID              	int             FOREIGN KEY REFERENCES Guest (Guest_ID),
    Room_ID              	int             FOREIGN KEY REFERENCES Room (Room_ID),
    Guest_Arrival        	date ,
    Guest_Departure 	date      
);

