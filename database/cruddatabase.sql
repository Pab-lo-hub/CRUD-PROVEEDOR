create database proveduria;
create table proveedores (
id int auto_increment not null primary key,
RazonSocial varchar(50),
Cuit varchar(50)
);proveedores
insert into proveedores values (null,"Rayo Veloz","20353407490");
insert into proveedores values (null,"Amortigua Todo","27584262580");
insert into proveedores values (null,"Cristales SRL","21369852151");

select * from proveedores 