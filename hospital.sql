create database emergency;


/* drop table admin_id*/

create table admin_ID
(
ID varchar(10) primary key,
password varchar(10)
);

/*insert into admin_ID values('13142103',' ');*/


/* drop table administration*/

create table administration
(
ID varchar(10) primary key,
password varchar(10)
);

/*insert into administration values('1314210','admin');*/


/* drop table register*/
create table register
(
	Category varchar(50) not null,
	Id varchar(10) not null,
	First_name varchar(50) not null,
	Last_name varchar(50) not null,
	Email varchar(50) not null,
	username varchar(50) Primary key,
	passward varchar(50) not null
);


/* drop table room*/
create table room
(
room_no numeric(5,0) not null primary key,
State varchar(10) not null
);

/*
insert into room values('1','QLD');
insert into room values('2','NWS');
*/


/* drop table bed*/
create table Bed
(
	bed_no numeric(5,0) not null Primary key,
	room_no numeric(5,0),
	p_id char(7) ,
	Status varchar(10) not null
);

/*
insert into bed values('1','1','0083524','In Use');
insert into bed values('2','2','0083525','In Use');
insert into bed values('3','1',NULL,'Free');
*/


/* drop table doctor*/
create table doctor(
d_id char(6) not null primary key,
d_name varchar(50) not null,
d_gender varchar(50) not null,
d_age varchar(50) not null,
qualification  varchar(50) not null,
d_mobile varchar(20)not null,
d_address varchar(100)not null,
room_no numeric(5,0) not null,
foreign key(room_no) references room
);


/* drop table patient*/
create table patient
 (
p_id char(7) not null primary key,
p_name varchar(50) not null,
p_gender varchar(50) not null,
p_age varchar(50) not null,
city  varchar(50) not null,
p_mobile varchar(20),
d_id char(6),
admit_date varchar(50) not null,
room_no numeric(5,0),
bed_no numeric(5,0),
foreign key (room_no) references room,
foreign key(d_id) references doctor,
foreign key (bed_no) references Bed
);

/*
insert into patient values('0083524','John Doe','Male','42','Brisbane','406506000','123456','December 12 2020','1','1');

insert into patient values('0083525','Lorna Smith','Male','27','Brisbane','406506000','123456','February 02 2020','2','2');
*/


/* drop table attendance*/
create table attendance
(
 category varchar(50) not null,
 ID varchar(20),
 LogInDate varchar(50),
 LogInTime varchar(20),
 LogOutTime varchar(20),
);


/*
insert into doctor values('123456','DR. Jones','Male','35','MBBS','406506000','Brisbane','1');
*/


/* drop table doctorCheckPatient*/
create table doctorCheckPatient
(
p_id char(7) primary key,
d_id char(6),
discharge_date varchar(50) DEFAULT GETDATE()
);


/* drop table nurse*/
create table nurse(

n_id char(6) not null primary key,
n_name varchar(50) not null,
n_age varchar(50) not null,
d_mobile varchar(20),
room_no numeric(5,0) not null,
foreign key(room_no) references room
);

/*
insert into nurse values('123800','Mary P.','35','406506000','1');
insert into nurse values('123801','Kelly A.','38','406506000','2');
*/


/*drop table treat*/

create table treat
(
p_id char(7) not null,
n_id char(6) not null,
issues varchar(2000) ,
last_comment varchar(100),
last_updated varchar(50) DEFAULT GETDATE(),
foreign key(p_id) references patient,
foreign key(n_id) references nurse
);

/*
insert into treat values('0083524','123800','Nausea-Dizziness','BP checked',GETDATE());
insert into treat values('0083525','123801','Broken leg', 'Blood Sugar checked',GETDATE());
*/

