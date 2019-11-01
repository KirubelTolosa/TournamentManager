
create table team(
team_id nvarchar(5) not null primary key,
team_name nvarchar(20) unique,
active bit default(1)
)

create table member(
member_id nvarchar(5) not null primary key,
member_name nvarchar(20) ,
active bit default(1)
)

create table team_member(
member_id nvarchar(5),
team_id nvarchar(6),
active bit default(1),
FOREIGN KEY (team_id) 
      REFERENCES team (team_id) 
FOREIGN KEY (member_id) 
      REFERENCES member (member_id) 
PRIMARY KEY(team_id, member_id)
)      

delete from member

insert into team(team_id, team_name) values('1000', 'Manchester United')
insert into team(team_id, team_name) values('1001', 'Arsenal')
insert into team(team_id, team_name) values('1002', 'Chelsea')

begin transaction
insert into member(member_id, member_name) values('4000', 'Van Persie') --ars
insert into member(member_id, member_name) values('4001', 'Frank Lambard') --che
insert into member(member_id, member_name) values('4002', 'Van Persie') --ars
insert into member(member_id, member_name) values('4003', 'Mesut Ozil') --ars
insert into member(member_id, member_name) values('4004', 'Dani Ceballos') --ars
insert into member(member_id, member_name) values('4005', 'Nicholas Pepe') --ars
insert into member(member_id, member_name) values('4006', 'Gabirel Martinelli') --ars
insert into member(member_id, member_name) values('4007', 'Frank Lambard') --chel
insert into member(member_id, member_name) values('4008', 'Nocholas Cante') --che
insert into member(member_id, member_name) values('4009', 'Olivier Giroud')  --che
commit

--arsenal players
insert into team_member(member_id, team_id) values('4000','1001') 
insert into team_member(member_id, team_id) values('4003','1001')
insert into team_member(member_id, team_id) values('4004','1001')
insert into team_member(member_id, team_id) values('4005','1001')
insert into team_member(member_id, team_id) values('4006','1001')
insert into team_member(member_id, team_id) values('4002','1001')

--chelese players
insert into team_member(member_id, team_id) values('4007','1002')
insert into team_member(member_id, team_id) values('4008','1002')
insert into team_member(member_id, team_id) values('4009','1002')





