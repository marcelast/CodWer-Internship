Create database UtmDb
go

use UtmDb

-- 1. Crearea tabelelor

create table Facultati(
idFacultate int identity(1,1) Primary key not null,
nume varchar(50) not null,
numeDecan varchar(50) not null,
nrStudenti int,
)
go

create table Specialitati(
idSpecialitate int identity(1,1) Primary Key not null,
nume varchar(50) not null,
telefonDepartament varchar(50) not null,
idFacultate int not null,
Foreign Key (idFacultate) References Facultati (idFacultate)
)

create table Profesori(
idProfesor int identity(1,1) Primary Key not null,
nume varchar(50) not null,
prenume varchar(50) not null,
email varchar(50) not null,
telefon varchar(50),
titluAcademic varchar(50) not null,
)

create table Cursuri(
idCurs int identity(1,1) Primary Key not null,
nume varchar(50) not null,
numarCredite int not null,
idSpecialitate int not null,
idProfesor int not null,
Foreign Key (idSpecialitate) References Specialitati (idSpecialitate),
Foreign Key (idProfesor) References Profesori (idProfesor)
)

create table Studenti(
idStudent int identity(1,1) Primary key not null,
nume varchar(20) not null,
prenume varchar(20) not null,
patronimic varchar(20),
dataNasterii datetime not null,
email varchar(50) not null,
telefon varchar(50),
idFacultate int not null, 
idSpecialitate int not null, 
anStudiu int not null,
Foreign Key (idFacultate) References Facultati (idFacultate),
Foreign Key (idSpecialitate) References Specialitati(idSpecialitate)
)

-- 3. Adaugarea coloane cu data modificarii si inregistrarii

alter table Facultati
add dataAdaugare datetime default getdate(),
    dataModificare datetime null;

alter table Studenti
add dataAdaugare datetime default getdate(),
    dataModificare datetime null;

	alter table Cursuri
add dataAdaugare datetime default getdate(),
    dataModificare datetime null;

	alter table Specialitati
add dataAdaugare datetime default getdate(),
    dataModificare datetime null;

	alter table Profesori
add dataAdaugare datetime default getdate(),
    dataModificare datetime null;


-- 4. Enunturi si probleme de interogare

-- *afisarea studentului, a facultatii si specialitatii din care face parte

Select s.nume + ' ' + s.prenume NumePrenume, sp.Nume Specialitate, f.Nume Facultate
from Studenti s
Join Specialitati sp on s.idSpecialitate = sp.idSpecialitate
Join Facultati f on s.idFacultate = f.idFacultate
Order by s.nume asc

-- *calcularea numarului de studenti per facultate si adaugarea rezultatului in tabel

UPDATE Facultati
SET nrStudenti = (
    SELECT COUNT(*)
    FROM Studenti
    WHERE Studenti.idFacultate= Facultati.idFacultate
);

-- *gruparea studentilor dupa facultati
SELECT
    f.nume NumeFacultate,
    COUNT(s.idStudent) NumarStudenti
FROM
    Facultati f
Left JOIN
    Studenti s ON f.idFacultate = s.idFacultate
GROUP BY
    f.nume;

-- *gruparea numarului de specialitati dupa facultati
select f.nume NumeFacultate, Count(idSpecialitate) NumarSpecialitati
from Facultati f
Left Join Specialitati s
on f.idFacultate = s.idFacultate
Group By f.nume
Order By NumarSpecialitati


-- *afisarea cursului si a profesorului

Select c.nume, p.Nume + ' ' + p.Prenume NumeProfesor, p.titluAcademic
from Cursuri c
Left Join Profesori p on c.idProfesor = p.idProfesor


-- afisarea studentilor de la o facultate anumita (FCIM)
Select s.nume + ' ' + s.prenume NumeStudent, f.nume NumeFacultate
from Studenti s
Join Facultati f 
on s.idFacultate = f.idFacultate
Where f.nume  = 'FCIM'

-- afisarea facultati cu mai mult de 5 studenti

SELECT
    f.nume NumeFacultate,
    COUNT(s.idStudent) NumarTotalStudenti
FROM
    Facultati f
LEFT JOIN
    Studenti s ON f.idFacultate = s.idFacultate
GROUP BY
    f.nume
HAVING
    COUNT(s.idStudent) > 2; 
