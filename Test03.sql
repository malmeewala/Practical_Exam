if not exists (select * from sysobjects where name='Person' and xtype='U')
CREATE TABLE  [dbo].[Person]([last] [varchar](50) ,	[first] [varchar](50) ,	[gender] [varchar](6) ,	[DoB] [datetime] NULL ) ON [PRIMARY]

INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Bandara','Kmal','Female','1/15/1980')
INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Rathnayahe','Amal','Male','6/4/1978')
INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Ekanayake','Ravindi','Female','12/12/1989')
INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Herath','Tharanga','Male','7/19/1984')
INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Wijethunga','Kumari','Female','9/22/1986')
INSERT INTO Interview.dbo.Person (last,first,gender,DoB) VALUES ('Rajapaksha','Mahinda','Male','4/4/1949')

Select * from Interview.dbo.Person order by dob
Select * from Interview.dbo.Person where gender='Male' or dob >= '1984-07-19'

update Interview.dbo.Person set last='Ranathunga',first='Sajitha',gender='Femail',DoB='1984-08-18' where 
last='Rathnayahe' and first='Amal' and gender='Male' and DoB='1978-06-04'
update Interview.dbo.Person set last='Samarasekara',first='Bhathiya',gender='Male',DoB='1985-11-10' where 
last='Wijethunga' and first='Kumari' and gender='Female' and DoB='1986-09-22'
