using EF_CodeFirst.Entities;
using Microsoft.Identity.Client;
using System;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                //var facultate = new Facultate { Name = "Facultatea de Informatică", Decan = "Viorel Bostan", nrStudents = 1000 };
                //var specialitate = new Specialitate { Name = "Informatică", Phone = "123-456-7890", Facultate = facultate };
                //var profesor = new Profesor { Name = "Mihail", Surname = "Perebinos", Email = "mihai@perebinos.com", Phone = "987-654-3210", AcademicTitle = "Profesor universitar" };
                //var curs = new Curs { Name = "Programare C#", nrCredite = 5, Specialitate = specialitate, Profesor = profesor };
                //var student = new Student { Name = "Marcela", Surname = "Stratan", Patronymic = "Mircea", Birthday = new DateTime(2001, 9, 4), Email = "marcella.stratan@gmail.com", Phone = "555-123-4567", Facultate = facultate, Specialitate = specialitate, anStudiu = 3 };

                //context.Facultati.Add(facultate);
                //context.Specialitati.Add(specialitate);
                //context.Profesori.Add(profesor);
                //context.Cursuri.Add(curs);
                //context.Students.Add(student);

                //context.SaveChanges();


                while (true)
                {
                    Console.WriteLine("Alege o entitat:");
                    Console.WriteLine("1. Curs");
                    Console.WriteLine("2. Facultate");
                    Console.WriteLine("3. Specialitate");
                    Console.WriteLine("4. Profeosr");
                    Console.WriteLine("5. Student");
                    Console.WriteLine("6. Iesire");

                    string input = Console.ReadLine();
                    Console.Clear();

                    switch (input)
                    {
                        case "1":
                            MeniuCurs(context);
                            break;
                        case "2":
                            MeniuFacultate(context);
                            break;
                        case "3":
                            MeniuSpecialitate(context);
                            break;
                        case "4":
                            MeniuProfesor(context);
                            break;
                        case "5":
                            MeniuStudent(context);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("OPtiune inexistenta.");
                            break;
                    }
                }


                //Meniu pentru Student

                static void MeniuStudent(Context context)
                {
                    while (true)
                    {
                        Console.WriteLine("Alege o optiune:");
                        Console.WriteLine("1. Create student");
                        Console.WriteLine("2. Read student");
                        Console.WriteLine("3. Update student");
                        Console.WriteLine("4. Delete student");
                        Console.WriteLine("5. Back");

                        int input = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (input)
                        {
                            case 1:
                                CreateStudent(context);
                                break;
                            case 2:
                                ReadStudent(context);
                                break;
                            case 3:
                                UpdateStudent(context);
                                break;
                            case 4:
                                DeleteStudent(context);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Optiune invalida.");
                                break;

                        }
                    }
                }

                //Meniu pentru Curs

                static void MeniuCurs(Context context)
                {
                    while (true)
                    {
                        Console.WriteLine("Alege o optiune:");
                        Console.WriteLine("1. Create curs");
                        Console.WriteLine("2. Read curs");
                        Console.WriteLine("3. Update curs");
                        Console.WriteLine("4. Delete curs");
                        Console.WriteLine("5. Back");

                        int input = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (input)
                        {
                            case 1:
                                CreateCurs(context);
                                break;
                            case 2:
                                ReadCurs(context);
                                break;
                            case 3:
                                UpdateCurs(context);
                                break;
                            case 4:
                                DeleteCurs(context);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Optiune invalida.");
                                break;

                        }
                    }
                }

                //Meniu pentru Facultate

                static void MeniuFacultate(Context context)
                {
                    while (true)
                    {
                        Console.WriteLine("Alege o optiune:");
                        Console.WriteLine("1. Create facultate");
                        Console.WriteLine("2. Read facultate");
                        Console.WriteLine("3. Update facultate");
                        Console.WriteLine("4. Delete facultate");
                        Console.WriteLine("5. Back");

                        int input = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (input)
                        {
                            case 1:
                                CreateFacultate(context);
                                break;
                            case 2:
                                ReadFacultate(context);
                                break;
                            case 3:
                                UpdateFacultate(context);
                                break;
                            case 4:
                                DeleteFacultate(context);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Optiune invalida.");
                                break;

                        }
                    }
                }

                //Meniu pentru Specialitate

                static void MeniuSpecialitate(Context context)
                {
                    while (true)
                    {
                        Console.WriteLine("Alege o optiune:");
                        Console.WriteLine("1. Create specialitate");
                        Console.WriteLine("2. Read specialitate");
                        Console.WriteLine("3. Update specialitate");
                        Console.WriteLine("4. Delete specialitate");
                        Console.WriteLine("5. Back");

                        int input = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (input)
                        {
                            case 1:
                                CreateSpecialitate(context);
                                break;
                            case 2:
                                ReadSpecialitate(context);
                                break;
                            case 3:
                                UpdateSpecialitate(context);
                                break;
                            case 4:
                                DeleteSpecialitate(context);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Optiune invalida.");
                                break;

                        }
                    }
                }

                //Meniu pentru Profesor

                static void MeniuProfesor(Context context)
                {
                    while (true)
                    {
                        Console.WriteLine("Alege o optiune:");
                        Console.WriteLine("1. Create profesor");
                        Console.WriteLine("2. Read profesor");
                        Console.WriteLine("3. Update profesor");
                        Console.WriteLine("4. Delete profesor");
                        Console.WriteLine("5. Back");

                        int input = int.Parse(Console.ReadLine());
                        Console.Clear();

                        switch (input)
                        {
                            case 1:
                                CreateProfesor(context);
                                break;
                            case 2:
                                ReadProfesor(context);
                                break;
                            case 3:
                                UpdateProfesor(context);
                                break;
                            case 4:
                                DeleteProfesor(context);
                                break;
                            case 5:
                                return;
                            default:
                                Console.WriteLine("Optiune invalida.");
                                break;

                        }
                    }
                }


                //Functiile meniului pentru curs

                static void CreateCurs(Context context)
                {
                    Console.WriteLine("Introdu numele cursului: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Introdu numarul de credite: ");
                    int credite = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introdu numele specialitatii: ");
                    string numeSpecialitate = Console.ReadLine();
                    Console.WriteLine("Introdu  prenumele profesorului: ");
                    string prenumeProfesor = Console.ReadLine();
                    Console.WriteLine("Introdu  numele profesorului: ");
                    string numeProfesor = Console.ReadLine();

                    Console.Clear();

                    var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == numeSpecialitate);
                    var profesor = context.Profesori.FirstOrDefault(p => p.Name == prenumeProfesor && p.Surname == numeProfesor);

                    if (specialitate == null || profesor == null)
                    {
                        Console.WriteLine("Specialitatea sau profesorul nu exista in baza de date.");
                    }
                    else
                    {
                        var curs = new Curs { Name = name, nrCredite = credite, Specialitate = specialitate, Profesor = profesor };
                        context.Cursuri.Add(curs);
                        context.SaveChanges();
                        Console.WriteLine("Cursul a fost adaugat cu succes");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                //Functia de afisare

                static void ReadCurs(Context context)
                {

                    var cursuri = context.Cursuri.ToList();

                    foreach (var c in cursuri)
                    {
                        Console.WriteLine($"ID: {c.Id}");
                        Console.WriteLine($"Nume: {c.Name}");
                        Console.WriteLine($"Numar de credite: {c.nrCredite}");
                        var numeSpecialitate = context.Specialitati.FirstOrDefault(s => s.Id == c.SpecialitateId)?.Name;
                        Console.WriteLine($"Specialitate: {numeSpecialitate}");
                        var numeProfesor = context.Profesori.FirstOrDefault(p => p.Id == c.ProfesorId)?.Name;
                        Console.WriteLine($"Profesor: {numeProfesor}");
                        Console.WriteLine();
                        Console.WriteLine("*******************************************");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functia de modificare

                static void UpdateCurs(Context context)
                {
                    Console.WriteLine("Introdu numele cursului pe care doresti sa-l actualizezi: ");
                    string cursName = Console.ReadLine();
                    Console.Clear();

                    var curs = context.Cursuri.FirstOrDefault(c => c.Name == cursName);

                    if (curs == null)
                    {
                        Console.WriteLine("Cursul nu a fost găsit.");
                        return;
                    }

                    Console.WriteLine("Introdu noul nume pentru curs (sau apasă Enter pentru a păstra numele curent): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        curs.Name = newName;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noile credite pentru curs (sau apasă Enter pentru a păstra numărul curent): ");
                    string newCreditsInput = Console.ReadLine();
                    Console.Clear();
                    if (!string.IsNullOrEmpty(newCreditsInput))
                    {
                        int newCredits;
                        if (int.TryParse(newCreditsInput, out newCredits))
                        {
                            curs.nrCredite = newCredits;
                        }
                        else
                        {
                            Console.WriteLine("Numărul de credite introdus nu este valid.");
                            return;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Introdu noul nume pentru specialitate (sau apasă Enter pentru a păstra specialitatea curentă): ");
                    string newSpecialitate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newSpecialitate))
                    {
                        var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == newSpecialitate);
                        curs.Specialitate = specialitate;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul nume pentru profesor (sau apasă Enter pentru a păstra profesorul curent): ");
                    string newProfesor = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newProfesor))
                    {
                        var profesor = context.Profesori.FirstOrDefault(p => p.Name == newProfesor);
                        curs.Profesor = profesor;

                    }
                    Console.Clear();
                    context.SaveChanges();
                    Console.WriteLine("Cursul a fost actualizat cu succes.");
                    Console.ReadLine();
                    Console.Clear();
                }

                //Functia de stergere

                static void DeleteCurs(Context context)
                {
                    Console.WriteLine("Introdu numele cursului pe care vrei sa-l stergi: ");
                    string deleteCurs = Console.ReadLine();
                    Console.Clear();
                    var curs = context.Cursuri.FirstOrDefault(c => c.Name == deleteCurs);

                    if (curs == null)
                    {
                        Console.WriteLine("Cursul cu acest nume nu a fost gasit.");
                    }
                    else
                    {
                        context.Cursuri.Remove(curs);
                    }

                    context.SaveChanges();
                    Console.WriteLine("Cursul {0} a fost sters.", deleteCurs);
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functiile pentru profesori
                static void CreateProfesor(Context context)
                {
                    Console.WriteLine("Introdu prenumele profesorului: ");
                    string prenume = Console.ReadLine();
                    Console.WriteLine("Introdu numele profesorului: ");
                    string nume = Console.ReadLine();
                    Console.WriteLine("Introdu email-ul: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Introdu telefonul: ");
                    string telefon = Console.ReadLine();
                    Console.WriteLine("Introdu titlul academic: ");
                    string titluAcademic = Console.ReadLine();

                    Console.Clear();
                    var profesor = new Profesor { Name = prenume, Surname = nume, Email = email, Phone = telefon, AcademicTitle = titluAcademic };
                    context.Profesori.Add(profesor);
                    context.SaveChanges();
                    Console.WriteLine("Profesorul a fost salvat cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                static void ReadProfesor(Context context)
                {
                    var profesori = context.Profesori.ToList();

                    foreach (var p in profesori)
                    {
                        Console.WriteLine($"Id: {p.Id}");
                        Console.WriteLine($"Prenume: {p.Name}");
                        Console.WriteLine($"Numele: {p.Surname}");
                        Console.WriteLine($"Email: {p.Email}");
                        Console.WriteLine($"Telefon: {p.Phone}");
                        Console.WriteLine($"Titlu academic: {p.AcademicTitle}");
                        Console.WriteLine("****************************************");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                static void UpdateProfesor(Context context)
                {
                    Console.WriteLine("Introdu numele  profesorului pe care vrei sa-l actualizezi: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Introdu prenumele  profesorului pe care vrei sa-l actualizezi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var profesor = context.Profesori.FirstOrDefault(p => p.Name == name && p.Surname == surname);

                    if (profesor == null)
                    {
                        Console.WriteLine("Profesorul nu a fost găsit.");
                        return;
                    }

                    Console.WriteLine("Introdu noul nume pentru profesor (sau apasă Enter pentru a păstra numele curent): ");
                    string newSurname = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newSurname))
                    {
                        profesor.Surname = newSurname;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul prenume pentru profesor (sau apasă Enter pentru a păstra numele curent): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        profesor.Name = newName;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul email (sau apasă Enter pentru a păstra email-ul curent): ");
                    string newEmail = Console.ReadLine();
                    Console.Clear();
                    if (!string.IsNullOrEmpty(newEmail))
                    {
                        profesor.Email = newEmail;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul telefon (sau apasă Enter pentru a păstra telefonul curent): ");
                    string newPhone = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPhone))
                    {
                        profesor.Phone = newPhone;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul titlu academic pentru profesor (sau apasă Enter pentru a păstra titlul curent): ");
                    string newAcademicTitle = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newAcademicTitle))
                    {
                        profesor.AcademicTitle = newAcademicTitle;
                    }
                    Console.Clear();
                    context.SaveChanges();
                    Console.WriteLine("Cursul a fost actualizat cu succes.");
                    Console.ReadLine();
                    Console.Clear();

                }

                static void DeleteProfesor(Context context)
                {
                    Console.WriteLine("Introdu numele  profesorului pe care vrei sa-l stergi: ");
                    string surname = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Introdu prenumele  profesorului pe care vrei sa-l stergi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var profesor = context.Profesori.FirstOrDefault(p => p.Name == name && p.Surname == surname);
                    if (profesor == null)
                    {
                        Console.WriteLine("Profesorul nu a fost gasit.");
                        return;
                    }

                    context.Profesori.Remove(profesor);
                    context.SaveChanges();
                    Console.WriteLine("Profesorul {0} {1} a fost sters.", profesor.Name, profesor.Surname);
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functiile pentru specialitati
                static void CreateSpecialitate(Context context)
                {
                    Console.WriteLine("Introdu numele specialitatii: ");
                    string nume = Console.ReadLine();
                    Console.WriteLine("Introdu telefonul: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Introdu numele facultatii: ");
                    string numeFacultate = Console.ReadLine();

                    Console.Clear();
                    var facultate = context.Facultati.FirstOrDefault(f => f.Name == numeFacultate);
                    var specialitate = new Specialitate { Name = nume, Phone = phone, Facultate = facultate };
                    context.Specialitati.Add(specialitate);
                    context.SaveChanges();
                    Console.WriteLine("Specialitatea a fost salvata cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                static void ReadSpecialitate(Context context)
                {
                    var specialitati = context.Specialitati.ToList();

                    foreach (var s in specialitati)
                    {
                        Console.WriteLine($"Id: {s.Id}");
                        Console.WriteLine($"Nume: {s.Name}");
                        Console.WriteLine($"Telefon: {s.Phone}");
                        var numeFacultate = (context.Facultati.FirstOrDefault(f => f.Id == s.FacultateId))?.Name;
                        Console.WriteLine($"Facultate: {numeFacultate}");
                        Console.WriteLine($"****************************************");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                static void UpdateSpecialitate(Context context)
                {
                    Console.WriteLine("Introdu numele  specialitatii pe care vrei sa o actualizezi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == name);

                    if (specialitate == null)
                    {
                        Console.WriteLine("Specialitatea nu a fost găsita.");
                        return;
                    }

                    Console.WriteLine("Introdu noul nume pentru specialitate (sau apasă Enter pentru a păstra numele curent): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        specialitate.Name = newName;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul telefon (sau apasă Enter pentru a păstra telefonul curent): ");
                    string newPhone = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPhone))
                    {
                        specialitate.Phone = newPhone;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul nume pentru facultate (sau apasă Enter pentru a păstra numele curent): ");
                    string newFacultate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newFacultate))
                    {
                        var facultate = context.Facultati.FirstOrDefault(f => f.Name == newFacultate);
                        specialitate.Facultate = facultate;
                    }
                    Console.Clear();
                    context.SaveChanges();
                    Console.WriteLine("Specialitatea a fost actualizata cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                static void DeleteSpecialitate(Context context)
                {
                    Console.WriteLine("Introdu numele  specialitatii pe care vrei sa o stergi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == name);
                    if (specialitate == null)
                    {
                        Console.WriteLine("Specialitatea nu a fost gasita.");
                        return;
                    }

                    context.Specialitati.Remove(specialitate);
                    context.SaveChanges();
                    Console.WriteLine("Specialitatea {0} a fost stearsa.", specialitate.Name);
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functiile pentru facultati

                static void CreateFacultate(Context context)
                {
                    Console.WriteLine("Introdu numele facultatii: ");
                    string nume = Console.ReadLine();
                    Console.WriteLine("Introdu numele decanului: ");
                    string decan = Console.ReadLine();
                    Console.WriteLine("Introdu numarul de studenti: ");
                    int nrStudenti = int.Parse(Console.ReadLine());

                    Console.Clear();
                    var facultate = new Facultate { Name = nume, Decan = decan, nrStudents = nrStudenti };
                    context.Facultati.Add(facultate);
                    context.SaveChanges();
                    Console.WriteLine("Facultatea a fost salvata cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                static void ReadFacultate(Context context)
                {
                    var facultati = context.Facultati.ToList();

                    foreach (var f in facultati)
                    {
                        Console.WriteLine($"Id: {f.Id}");
                        Console.WriteLine($"Nume: {f.Name}");
                        Console.WriteLine($"Decan: {f.Decan}");
                        Console.WriteLine($"Numar de studenti: {f.nrStudents}");
                        Console.WriteLine("****************************************");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                static void UpdateFacultate(Context context)
                {
                    Console.WriteLine("Introdu numele  facultatii pe care vrei sa o actualizezi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var facultate = context.Facultati.FirstOrDefault(f => f.Name == name);

                    if (facultate == null)
                    {
                        Console.WriteLine("Facultatea nu a fost găsita.");
                        return;
                    }

                    Console.WriteLine("Introdu noul nume pentru facultate (sau apasă Enter pentru a păstra numele curent): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        facultate.Name = newName;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul decan (sau apasă Enter pentru a păstra numele decanului curent): ");
                    string newDecan = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newDecan))
                    {
                        facultate.Decan = newDecan;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul numar de studenti (sau apasă Enter pentru a păstra numarul curent): ");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        if (int.TryParse(input, out int newStudents))
                        {
                            facultate.nrStudents = newStudents;
                        }
                        else
                        {
                            Console.WriteLine("Input invalid. ");
                        }
                    }
                    Console.Clear();

                    context.SaveChanges();
                    Console.WriteLine("Facultatea a fost actualizata cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                static void DeleteFacultate(Context context)
                {
                    Console.WriteLine("Introdu numele  facultatii pe care vrei sa o stergi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var facultate = context.Facultati.FirstOrDefault(f => f.Name == name);
                    if (facultate == null)
                    {
                        Console.WriteLine("Facultatea nu a fost gasita.");
                        return;
                    }

                    context.Facultati.Remove(facultate);
                    context.SaveChanges();
                    Console.WriteLine("Facultatea {0} a fost stearsa.", facultate.Name);
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functiile pentru studenti
                static void CreateStudent(Context context)
                {
                    Console.WriteLine("Introdu numele studentului: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Introdu prenumele studentului: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Introdu patronimicul studentului: ");
                    string patronymic = Console.ReadLine();
                    Console.WriteLine("Introdu data de nastere a studentului: ");
                    string input = Console.ReadLine();
                    DateTime.TryParse(input, out DateTime birthday);
                    Console.WriteLine("Introdu email-ul: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Introdu telefonul: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Introdu numele facultatii: ");
                    string numeFacultate = Console.ReadLine();
                    Console.WriteLine("Introdu  numele specialitatii: ");
                    string numeSpecialitate = Console.ReadLine();
                    Console.WriteLine("Introdu  anul de studiu: ");
                    int anStudiu = int.Parse(Console.ReadLine());

                    Console.Clear();

                    var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == numeSpecialitate);
                    var facultate = context.Facultati.FirstOrDefault(f => f.Name == numeFacultate);

                    if (specialitate == null || facultate == null)
                    {
                        Console.WriteLine("Specialitatea sau acultatea nu exista in baza de date.");
                    }
                    else
                    {
                        var student = new Student
                        {
                            Name = name,
                            Surname = surname,
                            Patronymic = patronymic,
                            Email = email,
                            Phone = phone,
                            Birthday = birthday,
                            Facultate = facultate,
                            Specialitate = specialitate,
                            anStudiu = anStudiu
                        };
                        context.Students.Add(student);
                        context.SaveChanges();
                        Console.WriteLine("Studentul a fost adaugat cu succes");
                    }

                    Console.ReadKey();
                    Console.Clear();
                }



                //Functia de afisare

                static void ReadStudent(Context context)
                {

                    var studenti = context.Students.ToList();

                    foreach (var s in studenti)
                    {
                        Console.WriteLine($"ID: {s.Id}");
                        Console.WriteLine($"Nume: {s.Surname}");
                        Console.WriteLine($"Prenume: {s.Name}");
                        Console.WriteLine($"Patronimic: {s.Patronymic}");
                        Console.WriteLine($"Zi de nastere: {s.Birthday}");
                        Console.WriteLine($"Email: {s.Email}");
                        Console.WriteLine($"Telefon: {s.Phone}");
                        var numeFacultate = context.Facultati.FirstOrDefault(f => f.Id == s.FacultateId)?.Name;
                        Console.WriteLine($"Facultate: {numeFacultate}");
                        var numeSpecialitate = context.Specialitati.FirstOrDefault(sp => sp.Id == s.SpecialitateId)?.Name;
                        Console.WriteLine($"Specialitate: {numeSpecialitate}");
                        Console.WriteLine($"An de studiu {s.anStudiu}");
                        Console.WriteLine("*******************************************");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                // Functia de modificare

                static void UpdateStudent(Context context)
                {
                    Console.WriteLine("Introdu numele studentului pe care doresti sa-l actualizezi: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Introdu prenumele studentului pe care doresti sa-l actualizezi: ");
                    string name = Console.ReadLine();
                    Console.Clear();

                    var student = context.Students.FirstOrDefault(s => s.Name == name && s.Surname == surname);

                    if (student == null)
                    {
                        Console.WriteLine("Studentul nu a fost găsit.");
                        return;
                    }

                    Console.WriteLine("Introdu noul nume pentru student (sau apasă Enter pentru a păstra numele curent): ");
                    string newSurname = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newSurname))
                    {
                        student.Surname = newSurname;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul prenume pentru student (sau apasă Enter pentru a păstra prenumele curent): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName))
                    {
                        student.Name = newName;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul patronimic pentru student (sau apasă Enter pentru a păstra patronimicul curent): ");
                    string newPatronymic = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPatronymic))
                    {
                        student.Patronymic = newPatronymic;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noua zi de nastere pentru student (sau apasă Enter pentru a păstra data curenta): ");
                    string newInputBirthday = Console.ReadLine();
                    Console.Clear();
                    if (!string.IsNullOrEmpty(newInputBirthday))
                    {
                        DateTime newBirthday;
                        if (DateTime.TryParse(newInputBirthday, out newBirthday))
                        {
                            student.Birthday = newBirthday;
                        }
                        else
                        {
                            Console.WriteLine("Data introdusa nu este valida.");
                            return;
                        }
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul email pentru student (sau apasă Enter pentru a păstra email-ul curent): ");
                    string newEmail = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newEmail))
                    {
                        student.Email = newEmail;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul telefon pentru student (sau apasă Enter pentru a păstra telefonul curent): ");
                    string newPhone = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newPhone))
                    {
                        student.Phone = newPhone;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul nume pentru facultate (sau apasă Enter pentru a păstra facultatea curentă): ");
                    string newFacultate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newFacultate))
                    {
                        var facultate = context.Facultati.FirstOrDefault(f => f.Name == newFacultate);
                        student.Facultate = facultate;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul nume pentru specialitate (sau apasă Enter pentru a păstra specialitatea curentă): ");
                    string newSpecialitate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newSpecialitate))
                    {
                        var specialitate = context.Specialitati.FirstOrDefault(s => s.Name == newSpecialitate);
                        student.Specialitate = specialitate;
                    }
                    Console.Clear();

                    Console.WriteLine("Introdu noul an de studiu pentru student (sau apasă Enter pentru a păstra anul curent): ");
                    int newAnStudiu = int.Parse(Console.ReadLine());
                    if (newAnStudiu != null)
                    {
                        student.anStudiu = newAnStudiu;
                    }
                    Console.Clear();

                    context.SaveChanges();
                    Console.WriteLine("Studentul a fost actualizat cu succes.");
                    Console.ReadKey();
                    Console.Clear();
                }

                //Functia de stergere

                static void DeleteStudent(Context context)
                {
                    Console.WriteLine("Introdu numele studentului pe care vrei sa-l stergi: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Introdu prenumele studentului pe care vrei sa-l stergi: ");
                    string name = Console.ReadLine();
                    Console.Clear();
                    var student = context.Students.FirstOrDefault(s => s.Name == name && s.Surname == surname);

                    if (student == null)
                    {
                        Console.WriteLine("Studentul cu acest nume nu a fost gasit.");
                    }
                    else
                    {
                        context.Students.Remove(student);
                    }

                    context.SaveChanges();
                    Console.WriteLine("Studentul {0} {1} a fost sters.", student.Name, student.Surname);
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    }
}