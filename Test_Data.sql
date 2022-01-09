
insert into admin_ID values('13142103',' ');


insert into administration values('1314210','admin');

insert into register values('Administration','1314210','Sam','su','sam@gmail.com','admin','admin');


insert into room values('1','QLD');
insert into room values('2','NWS');


insert into bed values('1','1','0083524','In Use');
insert into bed values('2','2','0083525','In Use');
insert into bed values('3','1',NULL,'Free');

insert into doctor values('123456','DR. Jones','Male','35','MBBS','406506000','Brisbane','1');


insert into patient values('0083524','John Doe','Male','42','Brisbane','406506000','123456',GETDATE(),'1','1');

insert into patient values('0083525','Lorna Smith','Male','27','Brisbane','406506000','123456',GETDATE(),'2','2');



insert into nurse values('123800','Mary P.','35','406506000','1');
insert into nurse values('123801','Kelly A.','38','406506000','2');

insert into treat values('0083524','123800','Nausea-Dizziness','BP checked',GETDATE());
insert into treat values('0083525','123801','Broken leg', 'Blood Sugar checked',GETDATE());





