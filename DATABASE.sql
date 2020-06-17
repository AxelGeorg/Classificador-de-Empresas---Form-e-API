create database if not exists empresas;
use empresas;

create table if not exists empresas(
	emp_id int(32) primary key auto_increment,
    emp_nome varchar(32) not null,
    emp_indice int(32) not null,
    emp_qntdNotas int(32) not null,
    emp_qntdDebitos int(32) not null
);

select * from empresas;
